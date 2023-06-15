using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Publisher = LibraryDisplay.Models.Publisher;

namespace LibraryDisplay.UserControls
{
    public abstract partial class AbstractEditCreate : UserControl
    {
        protected LibraryForm parentForm;
        public Book tempBook;
        public Author tempAuthor;
        public Publisher tempPublisher;
        public Genre tempGenre;
        protected Book? referencedBook;
        protected Author? referencedAuthor;
        protected Publisher? referencedPublisher;
        protected Genre? referencedGenre;
        public CallFrom calledFrom;


        public AbstractEditCreate(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            editPanel.Dock = DockStyle.Fill;
            tempBook = new Book();
            tempAuthor = new Author();
            tempPublisher = new Publisher();
            tempGenre = new Genre();
            new AutoCompleteBehavior(authorComboBoxEditBookPanel);
            new AutoCompleteBehavior(publisherComboBoxEditBookPanel);
            new AutoCompleteBehavior(genreComboBoxEditBookPanel);
            new AutoCompleteBehavior(parentGenreComboBoxEditGenrePanel);
            new AutoCompleteBehavior(subComboBoxEditGenrePanel);
            authorComboBoxEditBookPanel.Sorted = true;
            publisherComboBoxEditBookPanel.Sorted = true;
            genreComboBoxEditBookPanel.Sorted = true;
            parentGenreComboBoxEditGenrePanel.Sorted = true;
            subComboBoxEditGenrePanel.Sorted = true;
        }

        protected abstract void saveButtonEditPanel_Click(object sender, EventArgs e);

        protected abstract void editTabs_Selecting(object sender, TabControlCancelEventArgs e);

        protected abstract void deleteButtonEditPanel_Click(object sender, EventArgs e);

        protected abstract void homeButtonEditPanel_Click(object sender, EventArgs e);
        

        protected EditStatus checkStatus()
        {
            bool checkChanges = true;
            DbTable table;
            if (editTabs.SelectedTab == bookEditTab)
            {
                createTempBook();
                checkChanges = !referencedBook!.Equals(tempBook);
                table = DbTable.Book;
            }
            else if (editTabs.SelectedTab == authorEditTab)
            {
                createTempAuthor();
                checkChanges = !referencedAuthor!.Equals(tempAuthor);
                table = DbTable.Author;
            }
            else if (editTabs.SelectedTab == publisherEditTab)
            {
                createTempPublisher();
                checkChanges = !referencedPublisher!.Equals(tempPublisher);
                table = DbTable.Publisher;
            }
            else
            {
                createTempGenre();
                checkChanges = !referencedGenre!.Equals(tempGenre);
                table = DbTable.Genre;
            }
            return new EditStatus(checkChanges, table);
        }

        public async void populateEditBookPanel(string bookId)
        {
            Book book = await GetRequests.GetBookById(bookId);
            populateEditBookPanel(book, true);
        }

        public async void populateEditBookPanel(Book book, bool firstCall)
        {

            if (firstCall)
                referencedBook = book;

            ////////////////////////////////populate Info
            titleTextBoxEditBookPanel.Text = book.title;
            pagesTextBoxEditBookPanel.Text = book.pageNumber == 0 ? string.Empty : book.pageNumber.ToString();
            dateTextBoxEditBookPanel.Text = book.publicationDate;
            isbnTextBoxEditBookPanel.Text = book.isbn;
            descriptionTextBoxEditBookPanel.Text = book.description;
            imageURLTextBoxEditBookPanel.Text = book.imageUrl;

            ////////////////////////////////populate Authors
            HashSet<Author> authors = await GetRequests.GetAuthors();
            authorComboBoxEditBookPanel.Items.Clear();
            authorComboBoxEditBookPanel.Text = string.Empty;

            //populate combobox and flowpanel
            authorFlowBookEditPanel.Controls.Clear();
            foreach (Author author in authors)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = author.lastName + " " + author.firstName + " " + author.middleName;
                item.Id = author.id!.ToString();
                authorComboBoxEditBookPanel.Items.Add(item);
                if (book.authors != null)
                    if (book.authors.Contains(Int32.Parse(item.Id)))
                    {
                        RemovableLabel label = new RemovableLabel(item.Id, DbTable.Author, parentForm, authorFlowBookEditPanel);
                        label.Text = item.Text;
                        label.Tag = item.Id;
                        authorFlowBookEditPanel.Controls.Add(label);
                    }
            }
            authorComboBoxEditBookPanel.Text = string.Empty;

            ////////////////////////////////populate Publishers
            HashSet<Publisher> publishers = await GetRequests.GetPublishers();
            publisherComboBoxEditBookPanel.Items.Clear();

            //create no publisher item 
            ComboBoxItem noPublisher = new ComboBoxItem();
            noPublisher.Text = "--";
            noPublisher.Id = "0";
            publisherComboBoxEditBookPanel.Items.Add(noPublisher);

            //populate combobox and selected
            publisherComboBoxEditBookPanel.Text = string.Empty;
            foreach (Publisher publisher in publishers)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = publisher.name;
                item.Id = publisher.id.ToString();
                publisherComboBoxEditBookPanel.Items.Add(item);
                if (book.publisher == Int32.Parse(item.Id))
                {
                    publisherComboBoxEditBookPanel.SelectedItem = item;
                }
            }

            ////////////////////////////////populate genres
            HashSet<Genre> genres = await GetRequests.GetGenres();
            genreComboBoxEditBookPanel.Items.Clear();

            //populate combobox and flowpanel
            genreFlowBookEditPanel.Controls.Clear();
            foreach (Genre genre in genres)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = genre.genre;
                item.Id = genre.id.ToString();
                genreComboBoxEditBookPanel.Items.Add(item);
                if (book.genres != null)
                    if (book.genres.Contains(Int32.Parse(item.Id)))
                    {
                        RemovableLabel label = new RemovableLabel(item.Id, DbTable.Genre, parentForm, genreFlowBookEditPanel);
                        label.Text = item.Text;
                        genreFlowBookEditPanel.Controls.Add(label);
                    }
            }
            genreComboBoxEditBookPanel.Text = string.Empty;

            bookEditTab.Enabled = true;
            editTabs.SelectedTab = bookEditTab;
        }

        public async void populateEditAuthorPanel(string authorId)
        {
            Author author = await GetRequests.GetAuthorById(authorId);
            populateEditAuthorPanel(author, CallFrom.None, true);
        }

        public void populateEditAuthorPanel(Author author, CallFrom openedFrom, bool firstCall)
        {
            calledFrom = openedFrom;
            if (firstCall)
                referencedAuthor = author;

            ////////////////////////////////populate Info
            firstNameTextBoxEditAuthorPanel.Text = author.firstName;
            lastNameTextBoxEditAuthorPanel.Text = author.lastName;
            middleNameTextBoxEditAuthorPanel.Text = author.middleName;
            descriptionTextBoxEditAuthorPanel.Text = author.description;

            authorEditTab.Enabled = true;
            editTabs.SelectedTab = authorEditTab;
        }

        public async void populateEditPublisherPanel(string publisherId)
        {
            Publisher publisher = await GetRequests.GetPublisherById(publisherId);
            populateEditPublisherPanel(publisher, CallFrom.None, true);
        }

        public void populateEditPublisherPanel(Publisher publisher, CallFrom openedFrom, bool firstCall)
        {
            calledFrom = openedFrom;
            if (firstCall)
                referencedPublisher = publisher;

            nameTextBoxEditPublisherPanel.Text = publisher.name;
            emailTextBoxEditPublisherPanel.Text = publisher.email;
            phoneTextBoxEditPublisherPanel.Text = publisher.phone;

            publisherEditTab.Enabled = true;
            editTabs.SelectedTab = publisherEditTab;
        }

        public async void populateEditGenrePanel(Genre genre, CallFrom openedFrom, bool firstCall)
        {
            calledFrom = openedFrom;
            if (firstCall)
                referencedGenre = genre;

            genreTextBoxEditGenrePanel.Text = genre.genre;
            ////////////////////////////////populate Parent
            HashSet<Genre> parents = await GetRequests.GetGenres();
            parentGenreComboBoxEditGenrePanel.Items.Clear();

            //create noParent item 
            ComboBoxItem noParent = new ComboBoxItem();
            noParent.Text = "--";
            noParent.Id = "0";
            parentGenreComboBoxEditGenrePanel.Items.Add(noParent);

            //populate combobox and selected
            foreach (Genre g in parents)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = g.genre;
                item.Id = g.id.ToString();
                parentGenreComboBoxEditGenrePanel.Items.Add(item);
                if (genre.parentGenre == Int32.Parse(item.Id))
                {
                    parentGenreComboBoxEditGenrePanel.SelectedItem = item;
                }
            }
            parentGenreComboBoxEditGenrePanel.Text = string.Empty;
            if (genre.parentGenre == null)
            {
                parentGenreComboBoxEditGenrePanel.SelectedItem = noParent;
            }

            ////////////////////////////////populate sub genres
            HashSet<Genre> subs = await GetRequests.GetGenres();
            subComboBoxEditGenrePanel.Items.Clear();

            //populate combobox and flowpanel
            subFlowEditGenrePanel.Controls.Clear();
            foreach (Genre s in subs)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = s.genre;
                item.Id = s.id.ToString();
                subComboBoxEditGenrePanel.Items.Add(item);
                if (genre.subGenres.Contains(Int32.Parse(item.Id)))
                {
                    RemovableLabel label = new RemovableLabel(item.Id, DbTable.Genre, parentForm, subFlowEditGenrePanel);
                    label.Text = item.Text;
                    subFlowEditGenrePanel.Controls.Add(label);
                }
            }
            subComboBoxEditGenrePanel.Text = string.Empty;

            genreEditTab.Enabled = true;
            editTabs.SelectedTab = genreEditTab;
        }

        private void authorFlowBookEditPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (authorFlowBookEditPanel.Controls.Count == 0)
            {

                authorComboBoxEditBookPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
                authorFlowBookEditPanel.Visible = false;
            }
        }

        private void authorFlowBookEditPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (authorFlowBookEditPanel.Controls.Count == 1)
            {
                authorFlowBookEditPanel.Visible = true;
                authorComboBoxEditBookPanel.Margin = new System.Windows.Forms.Padding(3);
            }
        }

        private void genreFlowBookEditPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (genreFlowBookEditPanel.Controls.Count == 0)
            {

                genreComboBoxEditBookPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
                genreFlowBookEditPanel.Visible = false;
            }
        }

        private void genreFlowBookEditPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (genreFlowBookEditPanel.Controls.Count == 1)
            {
                genreFlowBookEditPanel.Visible = true;
                genreComboBoxEditBookPanel.Margin = new System.Windows.Forms.Padding(3);
            }
        }
        private void subComboBoxEditGenrePanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (subFlowEditGenrePanel.Controls.Count == 1)
            {
                subFlowEditGenrePanel.Visible = true;
                subComboBoxEditGenrePanel.Margin = new System.Windows.Forms.Padding(3);
            }
        }

        private void subComboBoxEditGenrePanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (subFlowEditGenrePanel.Controls.Count == 0)
            {

                subComboBoxEditGenrePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
                subFlowEditGenrePanel.Visible = false;
            }
        }

        private void authorComboBoxEditBookPanel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxItem? selection = authorComboBoxEditBookPanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in authorFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }
            if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Author, parentForm, authorFlowBookEditPanel);
                label.Text = selection!.Text;
                authorFlowBookEditPanel.Controls.Add(label);
            }
            authorComboBoxEditBookPanel.SelectedItem = null;
        }

        private void genreComboBoxEditBookPanel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxItem? selection = genreComboBoxEditBookPanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in genreFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }
            if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Genre, parentForm, genreFlowBookEditPanel);
                label.Text = selection!.Text;
                genreFlowBookEditPanel.Controls.Add(label);
            }
            genreComboBoxEditBookPanel.SelectedItem = null;
        }

        private void subComboBoxEditGenrePanel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxItem? selection = subComboBoxEditGenrePanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in subFlowEditGenrePanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }
            if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Genre, parentForm, subFlowEditGenrePanel);
                label.Text = selection!.Text;
                subFlowEditGenrePanel.Controls.Add(label);
            }
            subComboBoxEditGenrePanel.SelectedItem = null;
        }

        protected void createTempBook()
        {
            tempBook.id = referencedBook.id;
            tempBook.title = titleTextBoxEditBookPanel.Text;
            tempBook.isbn = isbnTextBoxEditBookPanel.Text;
            tempBook.pageNumber = pagesTextBoxEditBookPanel.Text == string.Empty ? 0 : Int32.Parse(pagesTextBoxEditBookPanel.Text);
            tempBook.imageUrl = imageURLTextBoxEditBookPanel.Text;
            tempBook.publicationDate = dateTextBoxEditBookPanel.Text;
            tempBook.description = descriptionTextBoxEditBookPanel.Text;
            ComboBoxItem? p = publisherComboBoxEditBookPanel.SelectedItem as ComboBoxItem;
            tempBook.publisher = p == null ? 0 : Int32.Parse(p!.Id);
            HashSet<int> a = new HashSet<int>();
            foreach (RemovableLabel l in authorFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                a.Add(Int32.Parse(l.id));
            }
            tempBook.authors = a;
            HashSet<int> g = new HashSet<int>();
            foreach (RemovableLabel l in genreFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                g.Add(Int32.Parse(l.id));
            }
            tempBook.genres = g;

        }
        protected void createTempAuthor()
        {
            tempAuthor.id = referencedAuthor.id;
            tempAuthor.firstName = firstNameTextBoxEditAuthorPanel.Text;
            tempAuthor.lastName = lastNameTextBoxEditAuthorPanel.Text;
            tempAuthor.middleName = middleNameTextBoxEditAuthorPanel.Text;
            tempAuthor.description = descriptionTextBoxEditAuthorPanel.Text;
            tempAuthor.books = referencedAuthor.books;
        }
        protected void createTempPublisher()
        {
            tempPublisher.id = referencedPublisher.id;
            tempPublisher.name = nameTextBoxEditPublisherPanel.Text;
            tempPublisher.email = emailTextBoxEditPublisherPanel.Text;
            tempPublisher.phone = phoneTextBoxEditPublisherPanel.Text;
            tempPublisher.books = referencedPublisher.books;

        }
        protected void createTempGenre()
        {
            tempGenre.id = referencedGenre.id;
            tempGenre.genre = genreTextBoxEditGenrePanel.Text;
            ComboBoxItem? p = parentGenreComboBoxEditGenrePanel.SelectedItem as ComboBoxItem;
            tempGenre.parentGenre = p == null || p.Id == "" || p.Id == "0" ? null : Int32.Parse(p!.Id);
            HashSet<int> s = new HashSet<int>();
            foreach (RemovableLabel l in subFlowEditGenrePanel.Controls.OfType<RemovableLabel>())
            {
                s.Add(Int32.Parse(l.id));
            }
            tempGenre.subGenres = s;
            tempGenre.books = referencedGenre.books;

        }

        private void pagesTextBoxEditBookPanel_TextChanged(object sender, EventArgs e)
        {
            string original = pagesTextBoxEditBookPanel.Text;
            string formated = string.Concat(original.Where(c => (c >= '0' && c <= '9')));
            if (formated != original)
            {
                int s = pagesTextBoxEditBookPanel.SelectionStart;
                if (s > 0 && formated.Length > s && original[s - 1] != formated[s - 1]) s--;
                pagesTextBoxEditBookPanel.Text = formated;
                pagesTextBoxEditBookPanel.SelectionStart = s;
            }
        }

        private void imageCheckButonEditBookPanel_Click(object sender, EventArgs e)
        {
            string url = imageURLTextBoxEditBookPanel.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                Form checkImageForm = new CheckImage(url);
            }
        }

        private void createAuthorButtonEditBookPanel_Click(object sender, EventArgs e)
        {
            createTempBook();
            if (this.GetType() == typeof(CreateControl))
            {
                parentForm.createControl.populateEditAuthorPanel(new Author(), CallFrom.CreateBook, true);
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreateBook) { book = tempBook });
            }
            if (this.GetType() == typeof(EditControl))
            {
                parentForm.createControl.populateEditAuthorPanel(new Author(), CallFrom.EditBook, true);
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditBook) { book = tempBook });
            }
            parentForm.createControl.BringToFront();
        }

        private void createPublisherButtonEditBookPanel_Click(object sender, EventArgs e)
        {
            createTempBook();
            if (this.GetType() == typeof(CreateControl))
            {
                parentForm.createControl.populateEditPublisherPanel(new Publisher(), CallFrom.CreateBook, true);
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreateBook) { book = tempBook });
            }
            if (this.GetType() == typeof(EditControl))
            {
                parentForm.createControl.populateEditPublisherPanel(new Publisher(), CallFrom.EditBook, true);
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditBook) { book = tempBook });
            }
            parentForm.createControl.BringToFront();
        }

        private void createGenreButtonEditBookPanel_Click(object sender, EventArgs e)
        {
            createTempBook();
            if (this.GetType() == typeof(CreateControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.CreateBook, true);
            if (this.GetType() == typeof(EditControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.EditBook, true);
            parentForm.createControl.BringToFront();
        }

        private void createParentButtonEditGenrePanel_Click(object sender, EventArgs e)
        {
            createTempGenre();
            if (this.GetType() == typeof(CreateControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.CreateGenreParent, true);
            if (this.GetType() == typeof(EditControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.EditGenreParent, true);
            parentForm.createControl.BringToFront();
        }

        private void createSubButtonEditGenrePanel_Click(object sender, EventArgs e)
        {
            createTempGenre();
            if (this.GetType() == typeof(CreateControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.CreateGenreSub, true);
            if (this.GetType() == typeof(EditControl))
                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.EditGenreSub, true);
            parentForm.createControl.BringToFront();
        }

        private void authorComboBoxEditBookPanel_Click(object sender, EventArgs e)
        {
            authorComboBoxEditBookPanel.DroppedDown = true;
        }

        private void publisherComboBoxEditBookPanel_Click(object sender, EventArgs e)
        {
            publisherComboBoxEditBookPanel.DroppedDown = true;
        }

        private void genreComboBoxEditBookPanel_Click(object sender, EventArgs e)
        {
            genreComboBoxEditBookPanel.DroppedDown = true;
        }

        private void parentGenreComboBoxEditGenrePanel_Click(object sender, EventArgs e)
        {
            parentGenreComboBoxEditGenrePanel.DroppedDown = true;
        }

        private void subComboBoxEditGenrePanel_Click(object sender, EventArgs e)
        {
            subComboBoxEditGenrePanel.DroppedDown = true;
        }

    }
}
