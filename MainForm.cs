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
        public CreateControl createControl;
        public EditControl editControl;
        public LibraryForm()
        {
            InitializeComponent();
            homeControl = new HomeControl(this);
            bookControl = new BookControl(this);
            authorControl = new AuthorControl(this);
            publisherControl = new PublisherControl(this);
            genreControl = new GenreControl(this);
            collectionControl = new CollectionControl(this);
            createControl = new CreateControl(this);
            editControl = new EditControl(this);

            this.Controls.Add(homeControl);
            this.Controls.Add(bookControl);
            this.Controls.Add(authorControl);
            this.Controls.Add(publisherControl);
            this.Controls.Add(genreControl);
            this.Controls.Add(collectionControl);
            this.Controls.Add(createControl);
            this.Controls.Add(editControl);
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
            createControl.Visible = true;
            editControl.Visible = true;

            homeControl.Dock = DockStyle.Fill;
            bookControl.Dock = DockStyle.Fill;
            authorControl.Dock = DockStyle.Fill;
            publisherControl.Dock = DockStyle.Fill;
            genreControl.Dock = DockStyle.Fill;
            collectionControl.Dock = DockStyle.Fill;
            createControl.Dock = DockStyle.Fill;
            editControl.Dock = DockStyle.Fill;


            homeControl.BringToFront();
            
            
        }

    }
}