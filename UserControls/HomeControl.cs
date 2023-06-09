﻿using LibraryDisplay.Models;
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
using LibraryDisplay.Network;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Utils.Models;
using System.Runtime.CompilerServices;

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
                    break;
                case "Publisher":
                    await parentForm.publisherControl.openPublisherPanel(firstSelectedItem.SubItems[2].Text);
                    break;
            }
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.HomeControl)
            {
                bookCheckBox = booksCheckBox.Checked,
                publisherCheckBox = publishersCheckBox.Checked,
                authorCheckBox = authorsCheckBox.Checked,
                searchString = searchTextBox.Text
            });
            parentForm.navigationForwardStack.Clear();
        }



        public async void genreTreeViewPopulate()
        {
            genreTreeView.Nodes.Clear();
            HashSet<Genre> genres = await GetRequests.GetGenres();

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
            genreTreeView.Sort();
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
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.HomeControl)
            {
                bookCheckBox = booksCheckBox.Checked,
                publisherCheckBox = publishersCheckBox.Checked,
                authorCheckBox = authorsCheckBox.Checked,
                searchString = searchTextBox.Text
            });
            parentForm.navigationForwardStack.Clear();
            parentForm.genreControl.BringToFront();
        }

        private async void collectionButtonHomePanel_Click(object sender, EventArgs e)
        {
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.HomeControl)
            {
                bookCheckBox = booksCheckBox.Checked,
                publisherCheckBox = publishersCheckBox.Checked,
                authorCheckBox = authorsCheckBox.Checked,
                searchString = searchTextBox.Text
            });
            parentForm.navigationForwardStack.Clear();
            await parentForm.collectionControl.openCollectionPanel();

        }

        private void createButtonHomePanel_Click(object sender, EventArgs e)
        {
            parentForm.createControl.populateEditBookPanel(new Book(), true);
            parentForm.createControl.populateEditAuthorPanel(new Author(), CallFrom.None, true);
            parentForm.createControl.populateEditPublisherPanel(new Publisher(), CallFrom.None, true);
            parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.None, true);

            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.HomeControl)
            {
                bookCheckBox = booksCheckBox.Checked,
                publisherCheckBox = publishersCheckBox.Checked,
                authorCheckBox = authorsCheckBox.Checked,
                searchString = searchTextBox.Text
            });
            parentForm.navigationForwardStack.Clear();
            parentForm.createControl.BringToFront();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                searchButton_Click(sender, (EventArgs)e);
                e.Handled = true;
            }
        }


    }
}
