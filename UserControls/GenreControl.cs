using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDisplay.UserControls
{
    public partial class GenreControl : UserControl
    {
        private LibraryForm parentForm;
        public Genre referencedGenre;
        public GenreControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            genrePanel.Dock = DockStyle.Fill;
        }

        private void homeButtonGenrePanel_Click(object sender, EventArgs e)
        {
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.GenreControl) { genre = referencedGenre });
            parentForm.navigationForwardStack.Clear();
            parentForm.homeControl.BringToFront();
        }

        private void GenreControl_Load(object sender, EventArgs e)
        {

        }

        public async void populateGenrePath()
        {
            genrePathFlowGenrePanel.Controls.Clear();
            Stack<Genre> path = new Stack<Genre>();
            path.Push(referencedGenre);
            while (path.Peek().parentGenre != null)
            {
                Genre temp = await GetRequests.GetGenreById(path.Peek().parentGenre.ToString());
                path.Push(temp);
            }
            while (path.Count > 0)
            {
                Genre g = path.Pop();
                ClickableLabel label = new ClickableLabel(g.id.ToString(), referencedGenre.id.ToString(), DbTable.Genre, DbTable.Genre, parentForm, genrePathFlowGenrePanel);
                label.Text = g.genre;
                genrePathFlowGenrePanel.Controls.Add(label);

                if (path.Count > 0)
                    genrePathFlowGenrePanel.Controls.Add(new Label() { Text = "→", AutoSize = true });

            }
        }

        public async Task openGenrePanel(string id)
        {
            genreBookFlow.Controls.Clear();
            Genre genre = await GetRequests.GetGenreById(id);
            referencedGenre = genre;

            genreLabelGenrePanel.Text = genre.genre;

            foreach (var item in genre.books)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), id, DbTable.Genre, parentForm, genreBookFlow);
                genreBookFlow.Controls.Add(book);
            }
            this.BringToFront();
            populateGenrePath();
        }

        private void editButtonGenrePanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.BringToFront();
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.GenreControl) { genre = referencedGenre });
            parentForm.navigationForwardStack.Clear();
            parentForm.editControl.populateEditGenrePanel(referencedGenre, CallFrom.None, true);
        }


    }
}
