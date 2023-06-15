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

            navigationBackStack.Push(new NavigationItem(PanelState.HomeControl) { bookCheckBox = true, publisherCheckBox = false, authorCheckBox = false, searchString = "" });
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
                }
            }
            base.WndProc(ref m);  // Process other messages normally
        }

        //private void LibraryForm_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.XButton1) //doesnt work
        //    {
        //        Console.WriteLine("Back Button Mouse");
        //    }
        //    else if (e.Button == MouseButtons.XButton2)
        //    {
        //        Console.WriteLine("Forward Button Mouse");
        //    }
        //}

        private async void navigateBack()
        {
            try
            {
                NavigationItem current = navigationBackStack.Pop();
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
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        
    }
}