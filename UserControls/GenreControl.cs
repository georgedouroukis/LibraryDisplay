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
            JObject genreData = await GetRequests.GetGenreById(id);
            genreLabelGenrePanel.Text = genreData["genre"].ToString();
            

            foreach (var item in genreData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, parentForm, genreBookFlow);
                JObject author = await GetRequests.GetBookById(item.ToString());
                genreBookFlow.Controls.Add(book);
            }
        }
    }
}
