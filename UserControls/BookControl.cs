﻿using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
    public partial class BookControl : UserControl
    {
        private LibraryForm parentForm;
        public Book referencedBook;
        public BookControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            bookPanel.Dock = DockStyle.Fill;

        }

        private void homeButtonBookPanel_Click(object sender, EventArgs e)
        {
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.BookControl) { book = referencedBook});
            parentForm.navigationForwardStack.Clear();
            parentForm.homeControl.BringToFront();
        }

        public async Task openBookPanel(string id)
        {
            //initialise panel
            authorFlowBookPanel.Controls.Clear();
            authorFlowBookPanel.Controls.Add(new Label() { Text = "Author: ", AutoSize = true });
            publisherFlowBookPanel.Controls.Clear();
            publisherFlowBookPanel.Controls.Add(new Label() { Text = "Publisher: ", AutoSize = true });
            genreFlowBookPanel.Controls.Clear();
            genreFlowBookPanel.Controls.Add(new Label() { Text = "Genre: ", AutoSize = true });
            pictureBoxBookPanel.Image = null;

            //get book
            Book book = await GetRequests.GetBookById(id);
            referencedBook = book;


            bookLabelBookPanel.Text = book.title;
            pagesLabelBookPanel.Text = book.pageNumber == 0 ? string.Empty : book.pageNumber.ToString();
            isbnLabelBookPanel.Text = book.isbn;
            publicationDateLabelBookPanel.Text = book.publicationDate;
            descriptionLabelBookPanel.Text = book.description;

            //get authors
            foreach (var item in book.authors)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), id, DbTable.Author, DbTable.Author, parentForm, authorFlowBookPanel); //this param is used for id
                Author author = await GetRequests.GetAuthorById(item.ToString());
                label.Text = author.firstName + " " + author.lastName + " " + author.middleName;
                authorFlowBookPanel.Controls.Add(label);
            }

            //get publisher
            Publisher publisher = await GetRequests.GetPublisherById(book.publisher.ToString());
            ClickableLabel publisherLabel = new ClickableLabel(book.publisher.ToString(), id, DbTable.Publisher, DbTable.Publisher, parentForm, publisherFlowBookPanel);
            publisherLabel.Text = publisher.name;
            publisherFlowBookPanel.Controls.Add(publisherLabel);

            //get genres
            foreach (var item in book.genres)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), id, DbTable.Book, DbTable.Genre, parentForm, genreFlowBookPanel);
                Genre genre = await GetRequests.GetGenreById(item.ToString());
                label.Text = genre.genre;
                genreFlowBookPanel.Controls.Add(label);
            }

            this.BringToFront();

            //get picture
            pictureBoxBookPanel.Image = await ImageHandler.GetImageFromUrl(book.imageUrl);
            //pictureBoxBookPanel.LoadAsync(data["imageUrl"]!.ToString());
        }

        private void editButtonBookPanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.BringToFront();
            parentForm.editControl.populateEditBookPanel(referencedBook, true);
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.BookControl) { book = referencedBook });
            parentForm.navigationForwardStack.Clear();
        }

        private void pictureBoxBookPanel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string url = referencedBook.imageUrl;
                if (!string.IsNullOrEmpty(url))
                {
                    Form checkImageForm = new CheckImage(url);
                }
            }
        }
    }
}
