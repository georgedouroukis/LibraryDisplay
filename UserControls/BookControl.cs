using LibraryDisplay.Models;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
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
            bookLabelBookPanel.Text = data["title"]!.ToString();
            pagesLabelBookPanel.Text = data["pageNumber"]!.ToString();
            isbnLabelBookPanel.Text = data["isbn"]!.ToString();
            publicationDateLabelBookPanel.Text = data["publicationDate"]!.ToString();
            descriptionLabelBookPanel.Text = data["description"]!.ToString();

            //get picture
            pictureBoxBookPanel.Image = await ImageHandler.GetImageFromUrl(data["imageUrl"]!.ToString());
            //pictureBoxBookPanel.LoadAsync(data["imageUrl"]!.ToString());

            //get authors
            foreach (var item in data["authors"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Author, parentForm); //this param is used for id
                JObject author = await GetRequests.GetAuthorById(item.ToString());
                label.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                authorFlowBookPanel.Controls.Add(label);
            }

            //get publisher
            JObject publisher = await GetRequests.GetPublisherById(data["publisher"]!.ToString());
            ClickableLabel publisherLabel = new ClickableLabel(data["publisher"]!.ToString(), DbTable.Publisher, parentForm);
            publisherLabel.Text = publisher["name"]!.ToString();
            publisherFlowBookPanel.Controls.Add(publisherLabel);

            //get genres
            foreach (var item in data["genres"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Genre, parentForm);
                JObject genre = await GetRequests.GetGenreById(item.ToString());
                label.Text = genre["genre"]!.ToString();
                genreFlowBookPanel.Controls.Add(label);
            }
            idBookPanel.Text = id;

        }
    }
}
