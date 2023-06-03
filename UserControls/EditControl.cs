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
    public partial class EditControl : UserControl
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

        public EditControl(LibraryForm parentForm)
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
                                await PutRequests.SaveBookChanges(tempBook);
                                await parentForm.bookControl.openBookPanel(tempBook.id.ToString());
                                break;
                            case DbTable.Author:
                                //SaveAuthorChanges(tempAuthor);
                                parentForm.authorControl.openAuthorPanel(tempAuthor.id.ToString());
                                break;
                            case DbTable.Publisher:
                                //SavePublisherChanges(tempPublisher);
                                parentForm.publisherControl.openPublisherPanel(tempPublisher.id.ToString());
                                break;
                            case DbTable.Genre:
                                //SaveGenreChanges(tempGenre);
                                parentForm.genreControl.openGenrePanel(tempGenre.id.ToString());
                                break;
                        }
                        Console.WriteLine("saving");
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

            ////////////////////////////////disable othe tabs
            editTabs.SelectedTab = bookEditTab;
            authorEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            genreEditTab.Enabled = false;
            parentForm.editControl.BringToFront();
        }

        private void editTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
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

        }
        private void createTempPublisher()
        {

        }
        private void createTempGenre()
        {

        }

        
    }
}
