using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.UserControls;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
using LibraryDisplay.Utils.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace LibraryDisplay
{
    public partial class LibraryForm : Form
    {
        public Stack<NavigationItem> navigationBackStack;
        public Stack<NavigationItem> navigationForwardStack;
        public HomeControl homeControl;
        public BookControl bookControl;
        public AuthorControl authorControl;
        public PublisherControl publisherControl;
        public GenreControl genreControl;
        public CollectionControl collectionControl;
        public AbstractEditCreate editControl;
        public AbstractEditCreate createControl;
        private bool navigatedBackOneTime;
        private bool navigatedForwardOneTime;
        public LibraryForm()
        {
            InitializeComponent();
            homeControl = new HomeControl(this);
            bookControl = new BookControl(this);
            authorControl = new AuthorControl(this);
            publisherControl = new PublisherControl(this);
            genreControl = new GenreControl(this);
            collectionControl = new CollectionControl(this);
            editControl = new EditControl(this);
            createControl = new CreateControl(this);

            this.Controls.Add(homeControl);
            this.Controls.Add(bookControl);
            this.Controls.Add(authorControl);
            this.Controls.Add(publisherControl);
            this.Controls.Add(genreControl);
            this.Controls.Add(collectionControl);
            this.Controls.Add(editControl);
            this.Controls.Add(createControl);

            this.navigationBackStack = new Stack<NavigationItem>();
            this.navigationForwardStack = new Stack<NavigationItem>();

            this.navigatedBackOneTime = false;
            this.navigatedForwardOneTime = false;
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            Size size = new Size(1200, 1200);
            this.Size = size;
            homeControl.Visible = true;
            bookControl.Visible = true;
            authorControl.Visible = true;
            publisherControl.Visible = true;
            genreControl.Visible = true;
            collectionControl.Visible = true;
            editControl.Visible = true;
            createControl.Visible = true;

            homeControl.Dock = DockStyle.Fill;
            bookControl.Dock = DockStyle.Fill;
            authorControl.Dock = DockStyle.Fill;
            publisherControl.Dock = DockStyle.Fill;
            genreControl.Dock = DockStyle.Fill;
            collectionControl.Dock = DockStyle.Fill;
            editControl.Dock = DockStyle.Fill;
            createControl.Dock = DockStyle.Fill;

            //navigationBackStack.Push(new NavigationItem(PanelState.HomeControl) { bookCheckBox = true, publisherCheckBox = false, authorCheckBox = false, searchString = "" });
            homeControl.BringToFront();


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Console.WriteLine(msg);
            if (keyData == Keys.XButton1)
            {
                Console.WriteLine("keyboard back");
                return true;
            }
            else if (keyData == Keys.XButton2)
            {
                Console.WriteLine("keyboard forward");
                return true;
            }
            else if (keyData == Keys.Back)
            {
                Console.WriteLine("keyboard BackSpace");
                return false;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void WndProc(ref Message m)
        {
            //Console.WriteLine(m);
            if (m.Msg == 0x319) //793 // Cannot use e.Button == MouseButtons.XButton1 because every component consumes the event 
            {
                if (m.LParam == 0x80010000)
                {
                    Console.WriteLine("Back Button Mouse");
                    navigateBack();
                }
                else if (m.LParam == 0x80020000)
                {
                    Console.WriteLine("Forward Button Mouse");
                    navigateForward();
                }
            }
            base.WndProc(ref m);  // Process other messages normally
        }

        private NavigationItem findCurrentPanelState()
        {
            Control frontControl = homeControl;
 
            foreach (Control control in Controls) 
            {
                if (Controls.IndexOf(control) == 0)
                {
                    frontControl = control;
                    break;
                } 
            }
            var type = frontControl.GetType();
            if (type == typeof(BookControl))
                return new NavigationItem(PanelState.BookControl) { book = this.bookControl.referencedBook};
            else if (type == typeof(AuthorControl))
                return new NavigationItem(PanelState.AuthorControl) { author = this.authorControl.referencedAuthor};
            else if (type == typeof(PublisherControl))
                return new NavigationItem(PanelState.PublisherControl) { publisher = this.publisherControl.referencedPublisher};
            else if (type == typeof(GenreControl))
                return new NavigationItem(PanelState.GenreControl) { genre = this.genreControl.referencedGenre};
            else if (type == typeof(CollectionControl))
                return new NavigationItem(PanelState.CollectionContol);


            else 
                return new NavigationItem(PanelState.HomeControl);

        }

        private void navigateBack()
        {

            try
            {
                if (!navigatedBackOneTime)
                {
                    navigatedBackOneTime = true;
                    NavigationItem current = findCurrentPanelState();
                    navigationForwardStack.Push(current);
                }
                NavigationItem previous = navigationBackStack.Pop();
                navigationForwardStack.Push(previous);
                navigate(previous);
                navigatedForwardOneTime = false;
            }
            catch { Console.WriteLine("empty back stack"); }
        }

        private void navigateForward()
        {
            try
            {
                if (!navigatedForwardOneTime)
                {
                    NavigationItem first = navigationForwardStack.Pop();
                    navigatedForwardOneTime = true;
                    navigationBackStack.Push(first);
                }
                NavigationItem next = navigationForwardStack.Pop();
                navigationBackStack.Push(next);
                navigate(next);
                navigatedBackOneTime = false;
                if (navigationForwardStack.Count == 0)
                {
                    navigationBackStack.Pop();//remove the state that got pushed in the beginning
                }
            }
            catch { Console.WriteLine("empty forward stack"); }
        }

        private async void navigate(NavigationItem current)
        {
            
            switch (current.panelState)
            {
                case PanelState.HomeControl:
                    homeControl.BringToFront();
                    break;

                case PanelState.CollectionContol:
                    collectionControl.BringToFront();
                    break;

                case PanelState.BookControl:
                    if (current.book != null)
                        current.referencedId = current.book.id.ToString();
                    await bookControl.openBookPanel(current.referencedId!);
                    break;

                case PanelState.AuthorControl:
                    if (current.author != null)
                        current.referencedId = current.author.id.ToString();
                    await authorControl.openAuthorPanel(current.referencedId!);
                    break;

                case PanelState.PublisherControl:
                    if (current.publisher != null)
                        current.referencedId = current.publisher.id.ToString();
                    await publisherControl.openPublisherPanel(current.referencedId!);
                    break;

                case PanelState.GenreControl:
                    if (current.genre != null)
                        current.referencedId = current.genre.id.ToString();
                    await genreControl.openGenrePanel(current.referencedId!);
                    break;


                case PanelState.CreateBook:
                    if (current.book != null)
                        createControl.populateEditBookPanel(current.book, false);
                    createControl.BringToFront();
                    break;

                case PanelState.CreateAuthor:
                    if (current.author != null)
                        createControl.populateEditAuthorPanel(current.author, CallFrom.None, false);
                    createControl.BringToFront();
                    break;

                case PanelState.CreatePublisher:
                    if (current.publisher != null)
                        createControl.populateEditPublisherPanel(current.publisher, CallFrom.None, false);
                    createControl.BringToFront();
                    break;

                case PanelState.CreateGenre:
                    if (current.genre != null)
                        createControl.populateEditGenrePanel(current.genre, CallFrom.None, false);
                    createControl.BringToFront();
                    break;
                    

                case PanelState.EditBook:
                    if (current.book != null)
                        editControl.populateEditBookPanel(current.book, false);
                    else
                        editControl.populateEditBookPanel(current.referencedId!);
                    editControl.BringToFront();
                    break;

                case PanelState.EditAuthor:
                    if (current.author != null)
                        current.referencedId = current.author.id.ToString();
                    editControl.populateEditAuthorPanel(current.referencedId!);
                    editControl.BringToFront();
                    break;

                case PanelState.EditPublisher:
                    if (current.publisher != null)
                        current.referencedId = current.publisher.id.ToString();
                    editControl.populateEditPublisherPanel(current.referencedId!);
                    editControl.BringToFront();
                    break;

                case PanelState.EditGenre:
                    if (current.genre != null)
                        current.referencedId = current.genre.id.ToString();
                    editControl.populateEditGenrePanel(current.referencedId!);
                    editControl.BringToFront();
                    break;

            }
        } 
    }
}