using LibraryDisplay.Models;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDisplay.UserControls
{
    public abstract partial class AbstractEditCreate : UserControl
    {
        private LibraryForm parentForm;
        private Book tempBook;
        private Author tempAuthor;
        private Publisher tempPublisher;
        private Genre tempGenre;
        private Book? referencedBook;
        private Author? referencedAuthor;
        private Publisher? referencedPublisher;
        private Genre? referencedGenre;

        public AbstractEditCreate(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            editPanel.Dock = DockStyle.Fill;
            tempBook = new Book();
            tempAuthor = new Author();
            tempPublisher = new Publisher();
            tempGenre = new Genre();
        }

        private EditStatus checkStatus()
        {
            bool checkChanges = true;
            DbTable table;
            if (bookEditTab.Enabled == true)
            {
                createTempBook();
                checkChanges = !referencedBook!.Equals(tempBook);
                table = DbTable.Book;
            }
            else if (authorEditTab.Enabled == true)
            {
                createTempAuthor();
                checkChanges = !referencedAuthor!.Equals(tempAuthor);
                table = DbTable.Author;
            }
            else if (publisherEditTab.Enabled == true)
            {
                createTempPublisher();
                checkChanges = !referencedPublisher!.Equals(tempAuthor);
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

        private void homeButtonEditPanel_Click(object sender, EventArgs e)
        {
            if (checkStatus().HasChanges)
            {
                DialogResult dr = MessageBox.Show("Discard Changes?", "Unsaved Changes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        parentForm.homeControl.BringToFront();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                parentForm.homeControl.BringToFront();
            }
        }

        private async void saveButtonEditPanel_Click(object sender, EventArgs e)
        {
            EditStatus status = checkStatus();
            if (status.HasChanges)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Save Changes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        switch (status.Table)
                        {
                            case DbTable.Book:
                                await PutRequests.UpdateEntity<Book>(tempBook);
                                await parentForm.bookControl.openBookPanel(tempBook.id.ToString());
                                break;
                            case DbTable.Author:
                                await PutRequests.UpdateEntity<Author>(tempAuthor);
                                await parentForm.authorControl.openAuthorPanel(tempAuthor.id.ToString());
                                break;
                            case DbTable.Publisher:
                                await PutRequests.UpdateEntity<Publisher>(tempPublisher);
                                await parentForm.publisherControl.openPublisherPanel(tempPublisher.id.ToString());
                                break;
                            case DbTable.Genre:
                                await PutRequests.UpdateEntity<Genre>(tempGenre);
                                await parentForm.genreControl.openGenrePanel(tempGenre.id.ToString());
                                break;
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                Console.WriteLine("no changes found");
            }
        }

        public async void openEditBookPanel(Book book)
        {
            referencedBook = book;
            ////////////////////////////////populate Info
            titleTextBoxEditBookPanel.Text = book.title;
            pagesTextBoxEditBookPanel.Text = book.pageNumber.ToString();
            dateTextBoxEditBookPanel.Text = book.publicationDate;
            isbnTextBoxEditBookPanel.Text = book.isbn;
            descriptionTextBoxEditBookPanel.Text = book.description;
            imageURLTextBoxEditBookPanel.Text = book.imageUrl;

            ////////////////////////////////populate Authors
            HashSet<Author> authors = await GetRequests.GetAuthors();
            authorComboBoxEditBookPanel.Items.Clear();

            //create new author item 
            ComboBoxItem createAuthor = new ComboBoxItem();
            createAuthor.Text = "Create New Author...";
            createAuthor.Id = "-1";
            authorComboBoxEditBookPanel.Items.Add(createAuthor);


            //populate combobox and flowpanel
            authorFlowBookEditPanel.Controls.Clear();
            foreach (Author author in authors)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = author.lastName + " " + author.firstName + " " + author.middleName;
                item.Id = author.id!.ToString();
                authorComboBoxEditBookPanel.Items.Add(item);
                if (book.authors.Contains(Int32.Parse(item.Id)))
                {
                    RemovableLabel label = new RemovableLabel(item.Id, DbTable.Author, parentForm, authorFlowBookEditPanel);
                    label.Text = item.Text;
                    label.Tag = item.Id;
                    authorFlowBookEditPanel.Controls.Add(label);
                }
            }

            ////////////////////////////////populate Publishers
            HashSet<Publisher> publishers = await GetRequests.GetPublishers();
            publisherComboBoxEditBookPanel.Items.Clear();

            //create new publisher item 
            ComboBoxItem createPublisher = new ComboBoxItem();
            createPublisher.Text = "Create New Publisher...";
            createPublisher.Id = "-1";
            publisherComboBoxEditBookPanel.Items.Add(createPublisher);

            //create no publisher item 
            ComboBoxItem noPublisher = new ComboBoxItem();
            noPublisher.Text = "--";
            noPublisher.Id = "0";
            publisherComboBoxEditBookPanel.Items.Add(noPublisher);

            //populate combobox and selected
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

            //create new genre item 
            ComboBoxItem createGenre = new ComboBoxItem();
            createGenre.Text = "Create New Genre...";
            createGenre.Id = "-1";
            genreComboBoxEditBookPanel.Items.Add(createGenre);

            //populate combobox and flowpanel
            genreFlowBookEditPanel.Controls.Clear();
            foreach (Genre genre in genres)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = genre.genre;
                item.Id = genre.id.ToString();
                genreComboBoxEditBookPanel.Items.Add(item);
                if (book.genres.Contains(Int32.Parse(item.Id)))
                {
                    RemovableLabel label = new RemovableLabel(item.Id, DbTable.Genre, parentForm, genreFlowBookEditPanel);
                    label.Text = item.Text;
                    genreFlowBookEditPanel.Controls.Add(label);
                }
            }

            ////////////////////////////////disable other tabs
            bookEditTab.Enabled = true;
            editTabs.SelectedTab = bookEditTab;
            authorEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            genreEditTab.Enabled = false;
            this.BringToFront();
        }

        public void openEditAuthorPanel(Author author)
        {
            referencedAuthor = author;
            ////////////////////////////////populate Info
            firstNameTextBoxEditAuthorPanel.Text = author.firstName;
            lastNameTextBoxEditAuthorPanel.Text = author.lastName;
            middleNameTextBoxEditAuthorPanel.Text = author.middleName;
            descriptionTextBoxEditAuthorPanel.Text = author.description;


            ////////////////////////////////disable other tabs
            authorEditTab.Enabled = true;
            editTabs.SelectedTab = authorEditTab;
            bookEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            genreEditTab.Enabled = false;
            this.BringToFront();
        }

        public void openEditPublisherPanel(Publisher publisher)
        {
            referencedPublisher = publisher;
            nameTextBoxEditPublisherPanel.Text = publisher.name;
            emailTextBoxEditPublisherPanel.Text = publisher.email;
            phoneTextBoxEditPublisherPanel.Text = publisher.phone;

            ////////////////////////////////disable other tabs
            publisherEditTab.Enabled = true;
            editTabs.SelectedTab = publisherEditTab;
            bookEditTab.Enabled = false;
            authorEditTab.Enabled = false;
            genreEditTab.Enabled = false;
            this.BringToFront();
        }

        public async void openEditGenrePanel(Genre genre)
        {
            referencedGenre = genre;
            genreTextBoxEditGenrePanel.Text = genre.genre;



            ////////////////////////////////populate Parent
            HashSet<Genre> parents = await GetRequests.GetGenres();
            parentGenreComboBoxEditGenrePanel.Items.Clear();

            //create new genreParent item 
            ComboBoxItem createParent = new ComboBoxItem();
            createParent.Text = "Create New Parent Genre...";
            createParent.Id = "-1";
            parentGenreComboBoxEditGenrePanel.Items.Add(createParent);

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
            if (genre.parentGenre == null)
            {
                parentGenreComboBoxEditGenrePanel.SelectedItem = noParent;
            }

            ////////////////////////////////populate sub genres
            HashSet<Genre> subs = await GetRequests.GetGenres();
            subComboBoxEditGenrePanel.Items.Clear();

            //create new sub genre item 
            ComboBoxItem createSub = new ComboBoxItem();
            createSub.Text = "Create New Sub Genre...";
            createSub.Id = "-1";
            subComboBoxEditGenrePanel.Items.Add(createSub);

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
            ////////////////////////////////disable other tabs
            genreEditTab.Enabled = true;
            editTabs.SelectedTab = genreEditTab;
            bookEditTab.Enabled = false;
            authorEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            this.BringToFront();
        }

        private void editTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //to not navigate to disabled tabs
            if (e.TabPage.Enabled == false)
                e.Cancel = true;
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

        private void authorComboBoxEditBookPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem? selection = authorComboBoxEditBookPanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in authorFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }

            if (selection!.Id == "-1")
            {

            }
            else if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Author, parentForm, authorFlowBookEditPanel);
                label.Text = selection!.Text;
                authorFlowBookEditPanel.Controls.Add(label);
            }
        }

        private void genreComboBoxEditBookPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem? selection = genreComboBoxEditBookPanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in genreFlowBookEditPanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }

            if (selection!.Id == "-1")
            {

            }
            else if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Genre, parentForm, genreFlowBookEditPanel);
                label.Text = selection!.Text;
                genreFlowBookEditPanel.Controls.Add(label);
            }
        }
        private void subComboBoxEditGenrePanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem? selection = subComboBoxEditGenrePanel.SelectedItem as ComboBoxItem;

            List<string> list = new List<string>();
            foreach (RemovableLabel l in subFlowEditGenrePanel.Controls.OfType<RemovableLabel>())
            {
                list.Add(l.id);
            }

            if (selection!.Id == "-1")
            {

            }
            else if (!list.Contains(selection!.Id))
            {
                RemovableLabel label = new RemovableLabel(selection!.Id, DbTable.Genre, parentForm, subFlowEditGenrePanel);
                label.Text = selection!.Text;
                subFlowEditGenrePanel.Controls.Add(label);
            }
        }

        private void createTempBook()
        {
            tempBook.id = referencedBook.id;
            tempBook.title = titleTextBoxEditBookPanel.Text;
            tempBook.isbn = isbnTextBoxEditBookPanel.Text;
            tempBook.pageNumber = Int32.Parse(pagesTextBoxEditBookPanel.Text);
            tempBook.imageUrl = imageURLTextBoxEditBookPanel.Text;
            tempBook.publicationDate = dateTextBoxEditBookPanel.Text;
            tempBook.description = descriptionTextBoxEditBookPanel.Text;
            ComboBoxItem? p = publisherComboBoxEditBookPanel.SelectedItem as ComboBoxItem;
            tempBook.publisher = Int32.Parse(p!.Id);
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
        private void createTempAuthor()
        {
            tempAuthor.id = referencedAuthor.id;
            tempAuthor.firstName = firstNameTextBoxEditAuthorPanel.Text;
            tempAuthor.lastName = lastNameTextBoxEditAuthorPanel.Text;
            tempAuthor.middleName = middleNameTextBoxEditAuthorPanel.Text;
            tempAuthor.description = descriptionTextBoxEditAuthorPanel.Text;
            tempAuthor.books = referencedAuthor.books;
        }
        private void createTempPublisher()
        {
            tempPublisher.id = referencedPublisher.id;
            tempPublisher.name = nameTextBoxEditPublisherPanel.Text;
            tempPublisher.email = emailTextBoxEditPublisherPanel.Text;
            tempPublisher.phone = phoneTextBoxEditPublisherPanel.Text;
            tempPublisher.books = referencedPublisher.books;

        }
        private void createTempGenre()
        {
            tempGenre.id = referencedGenre.id;
            tempGenre.genre = genreTextBoxEditGenrePanel.Text;
            ComboBoxItem? p = parentGenreComboBoxEditGenrePanel.SelectedItem as ComboBoxItem;
            tempGenre.parentGenre = Int32.Parse(p!.Id)==0?null: Int32.Parse(p!.Id);
            HashSet<int> s = new HashSet<int>();
            foreach (RemovableLabel l in subFlowEditGenrePanel.Controls.OfType<RemovableLabel>())
            {
                s.Add(Int32.Parse(l.id));
            }
            tempGenre.subGenres = s;
            tempGenre.books = referencedGenre.books;

        }

        
    }
}
