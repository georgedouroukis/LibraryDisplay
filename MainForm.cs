using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.UserControls;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
using LibraryDisplay.Utils.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Eventing.Reader;

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

            navigationBackStack.Push(new NavigationItem(PanelState.HomeControl) { bookCheckBox = true, publisherCheckBox = false, authorCheckBox = false, searchString = "" }) ;
            homeControl.BringToFront();


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Console.WriteLine(msg);
            if (keyData == Keys.XButton1)
            {
                Console.WriteLine("keyboard back");
            }
            else if (keyData == Keys.XButton2)
            {
                Console.WriteLine("keyboard forward");
            }
            else if (keyData == Keys.Back)
            {
                Console.WriteLine("keyboard BackSpace");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void WndProc(ref Message m)
        {
            //Console.WriteLine(m);
            if (m.Msg==0x319) //793
            {
                if (m.LParam == 0x80010000)
                {
                    Console.WriteLine("Back Button Mouse");
                }
                else if (m.LParam == 0x80020000)
                {
                    Console.WriteLine("Forward Button Mouse");
                }
            }
            base.WndProc(ref m);  // Process other messages normally
        }
    }
}