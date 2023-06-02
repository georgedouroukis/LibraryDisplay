using LibraryDisplay.Models;
using LibraryDisplay.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
    public partial class HomeControl : UserControl
    {
        private LibraryForm parentForm;
        public HomeControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            homePanel.Dock = DockStyle.Fill;
            genreTreeViewPopulate();
        }

        private void createButtonHomePanel_Click(object sender, EventArgs e)
        {
            parentForm.createControl.BringToFront();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            searchListView.Items.Clear();
            List<ListViewItem> result = await SearchUtility.Search(searchTextBox.Text, booksCheckBox.Checked, authorsCheckBox.Checked, publishersCheckBox.Checked);
            foreach (ListViewItem item in result)
            {
                searchListView.Items.Add(item);
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked)
            {
                booksCheckBox.Checked = true;
                authorsCheckBox.Checked = true;
                publishersCheckBox.Checked = true;
            }
            else
            {
                booksCheckBox.Checked = false;
                authorsCheckBox.Checked = false;
                publishersCheckBox.Checked = false;
            }
        }

        private async void searchListView_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = searchListView.SelectedItems[0];

            switch (firstSelectedItem.SubItems[1].Text)
            {
                case "Book":
                    await parentForm.bookControl.openBookPanel(firstSelectedItem.SubItems[2].Text);
                    parentForm.bookControl.BringToFront();
                    break;
                case "Author":
                    await parentForm.authorControl.openAuthorPanel(firstSelectedItem.SubItems[2].Text);
                    parentForm.authorControl.BringToFront();
                    break;
                case "Publisher":
                    await parentForm.publisherControl.openPublisherPanel(firstSelectedItem.SubItems[2].Text);
                    parentForm.publisherControl.BringToFront();
                    break;
            }
        }



        private async void genreTreeViewPopulate()
        {
            List<JObject> data = await GetRequests.GetGenres();

            List<Genre> genres = data.Select(x => JsonConvert.DeserializeObject<Genre>(x.ToString())).ToList();

            Dictionary<int, Genre> genreDictionary = new Dictionary<int, Genre>();
            foreach (var genre in genres)
            {
                genreDictionary.Add(genre.id, genre);
            }

            foreach (var genre in genres)
            {
                if (genre.parentGenre == null)
                {
                    TreeNode rootNode = new TreeNode(genre.genre);
                    rootNode.Tag = genre.id;
                    AddChildGenres(genre, rootNode, genreDictionary);
                    genreTreeView.Nodes.Add(rootNode);
                }
            }

            genreTreeView.ExpandAll();
        }

        private void AddChildGenres(Genre parentGenre, TreeNode parentNode, Dictionary<int, Genre> genreDictionary)
        {
            if (parentGenre.subGenres.Count == 0)
                return;

            foreach (var subGenreId in parentGenre.subGenres)
            {
                if (genreDictionary.TryGetValue(subGenreId, out Genre subGenre))
                {
                    TreeNode subGenreNode = new TreeNode(subGenre.genre);
                    subGenreNode.Tag = subGenre.id;
                    AddChildGenres(subGenre, subGenreNode, genreDictionary);
                    parentNode.Nodes.Add(subGenreNode);
                }
            }
        }



        private async void genreTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            await parentForm.genreControl.openGenrePanel(e.Node.Tag.ToString());
            parentForm.genreControl.BringToFront();
        }

        private void collectionButtonHomePanel_Click(object sender, EventArgs e)
        {
            parentForm.collectionControl.BringToFront();
        }
    }
}
