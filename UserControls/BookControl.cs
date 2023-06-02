﻿using LibraryDisplay.Models;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
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
        private Book referencedBook;
        public BookControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            bookPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonBookPanel_Click(object sender, EventArgs e)
        {
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
            JObject data = await GetRequests.GetBookById(id);
            Book book = JsonConvert.DeserializeObject<Book>(data.ToString());
            referencedBook = book;

            bookLabelBookPanel.Text = book.title;
            pagesLabelBookPanel.Text = book.pageNumber.ToString();
            isbnLabelBookPanel.Text = book.isbn;
            publicationDateLabelBookPanel.Text = book.publicationDate;
            descriptionLabelBookPanel.Text = book.description;

            //get picture
            pictureBoxBookPanel.Image = await ImageHandler.GetImageFromUrl(book.imageUrl);
            //pictureBoxBookPanel.LoadAsync(data["imageUrl"]!.ToString());

            //get authors
            foreach (var item in data["authors"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Author, parentForm, authorFlowBookPanel); //this param is used for id
                JObject author = await GetRequests.GetAuthorById(item.ToString());
                label.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                authorFlowBookPanel.Controls.Add(label);
            }

            //get publisher
            JObject publisher = await GetRequests.GetPublisherById(data["publisher"]!.ToString());
            ClickableLabel publisherLabel = new ClickableLabel(data["publisher"]!.ToString(), DbTable.Publisher, parentForm, publisherFlowBookPanel);
            publisherLabel.Text = publisher["name"]!.ToString();
            publisherFlowBookPanel.Controls.Add(publisherLabel);

            //get genres
            foreach (var item in data["genres"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Genre, parentForm, genreFlowBookPanel);
                JObject genre = await GetRequests.GetGenreById(item.ToString());
                label.Text = genre["genre"]!.ToString();
                genreFlowBookPanel.Controls.Add(label);
            }
            

        }

        private void editButtonBookPanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.openEditBookPanel(referencedBook);
        }
    }
}
