using LibraryDisplay.Models;
using LibraryDisplay.UserControls;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryDisplay
{
    public partial class LibraryForm : Form
    {
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


            homeControl.BringToFront();


        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.XButton1:
                    //NavigateBack(sender, e); // call the back button event handler
                    Console.WriteLine("Mouse back");
                    break;
                case MouseButtons.XButton2:
                    //NavigateForward(sender, e); // call the forward button event handler
                    Console.WriteLine("Mouse Forward back");
                    break;
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine($"Key '{keyData}' pressed!");
            if (keyData == Keys.XButton1)
            {
                Console.WriteLine("keyboard back");
                return false; 
            }
            else if (keyData == Keys.XButton2)
            {
                Console.WriteLine("keyboard forward");
                return false;
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
            const int WM_LBUTTONDOWN = 528;  // Left mouse button down message
            const int WM_RBUTTONDOWN = 123;  // Right mouse button down message
            switch (m.Msg)
            {
                case WM_LBUTTONDOWN:
                    // Handle left mouse button down event
                    Console.WriteLine("Left mouse button down!");
                    break;

                case WM_RBUTTONDOWN:
                    // Handle right mouse button down event
                    Console.WriteLine("Right mouse button down!");
                    break;

                // Add additional cases for other mouse-related messages if needed

                default:
                    Console.WriteLine($"{m.Msg}");
                    base.WndProc(ref m);  // Process other messages normally
                    break;
            }
        }

    }
}