using LibraryDisplay.Models;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
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
    public partial class GenreControl : UserControl
    {
        private LibraryForm parentForm;
        private Genre referencedGenre;
        public GenreControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            genrePanel.Dock = DockStyle.Fill;
        }

        private void homeButtonGenrePanel_Click(object sender, EventArgs e)
        {
            parentForm.homeControl.BringToFront();
        }

        private void GenreControl_Load(object sender, EventArgs e)
        {

        }
        public async Task openGenrePanel(string id)
        {
            genreBookFlow.Controls.Clear();
            Genre genre = await GetRequests.GetGenreById(id);
            referencedGenre = genre;

            genreLabelGenrePanel.Text = genre.genre;

            foreach (var item in genre.books)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, parentForm, genreBookFlow);
                genreBookFlow.Controls.Add(book);
            }
            this.BringToFront();
        }

        private void editButtonGenrePanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.BringToFront();
            parentForm.editControl.openEditGenrePanel(referencedGenre);
        }
    }
}
