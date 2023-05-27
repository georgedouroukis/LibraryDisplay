using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryDisplay
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            genreTreeViewPopulate();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            Size size = new Size(800, 800);
            this.Size = size;
            homePanel.Dock = DockStyle.Fill;
            homePanel.Visible = true;
            bookPanel.Dock = DockStyle.Fill;
            bookPanel.Visible = false;
            authorPanel.Dock = DockStyle.Fill;
            authorPanel.Visible = false;
            publisherPanel.Dock = DockStyle.Fill;
            publisherPanel.Visible = false;
            collectionPanel.Dock = DockStyle.Fill;
            collectionPanel.Visible = false;
            createPanel.Dock = DockStyle.Fill;
            createPanel.Visible = false;
            genrePanel.Dock = DockStyle.Fill;
            genrePanel.Visible = false;
            editPanel.Dock = DockStyle.Fill;
            editPanel.Visible = false;
        }

        private void collectionButtonHomePanel_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            collectionPanel.Visible = true;

        }

        private void homeButtonCollectionPanel_Click(object sender, EventArgs e)
        {
            collectionPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void createButtonHomePanel_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            createPanel.Visible = true;
        }

        private void homeButtonBookPanel_Click(object sender, EventArgs e)
        {
            bookPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void homeButtonCreatePanel_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void homeButtonPublisherPanel_Click(object sender, EventArgs e)
        {
            publisherPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void homeButtonAuthorPanel_Click(object sender, EventArgs e)
        {
            authorPanel.Visible = false;
            homePanel.Visible = true;
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
                    await openBookPanel(firstSelectedItem.SubItems[2].Text);
                    break;
                case "Author":
                    await openAuthorPanel(firstSelectedItem.SubItems[2].Text);
                    break;
                case "Publisher":
                    await openPublisherPanel(firstSelectedItem.SubItems[2].Text);
                    break;
            }
        }

        private async Task openBookPanel(string id)
        {
            authorFlowBookPanel.Controls.Clear();
            authorFlowBookPanel.Controls.Add(new Label() { Text = "Author: ", AutoSize = true });
            publisherFlowBookPanel.Controls.Clear();
            publisherFlowBookPanel.Controls.Add(new Label() { Text = "Publisher: ", AutoSize = true });
            genreFlowBookPanel.Controls.Clear();
            genreFlowBookPanel.Controls.Add(new Label() { Text = "Genre: ", AutoSize = true });

            JObject data = await GetRequests.GetBookById(id);
            pagesLabelBookPanel.Text = data["pageNumber"]!.ToString();
            isbnLabelBookPanel.Text = data["isbn"]!.ToString();
            publicationDateLabelBookPanel.Text = data["publicationDate"]!.ToString();
            bookLabelBookPanel.Text = data["title"]!.ToString();

            JObject publisher = await GetRequests.GetPublisherById(data["publisher"]!.ToString());
            ClickableLabel publisherLabel = new ClickableLabel(data["publisher"]!.ToString(), DbTable.Publisher);
            publisherLabel.Text = publisher["name"]!.ToString();
            publisherFlowBookPanel.Controls.Add(publisherLabel);

            foreach (var item in data["authors"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Author);
                JObject author = await GetRequests.GetAuthorById(item.ToString());
                label.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                authorFlowBookPanel.Controls.Add(label);
            }

            foreach (var item in data["genres"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Genre);
                JObject genre = await GetRequests.GetGenreById(item.ToString());
                label.Text = genre["genre"]!.ToString();
                genreFlowBookPanel.Controls.Add(label);
            }
            idBookPanel.Text = id;
            homePanel.Visible = false;
            bookPanel.Visible = true;
        }

        private async Task openAuthorPanel(string id)
        {
            JObject authorData = await GetRequests.GetAuthorById(id);
            authorLabelAuthorPanel.Text = authorData["firstName"] + " " + authorData["lastName"] + " " + authorData["middleName"];
            idAuthorPanel.Text = id;
            homePanel.Visible = false;
            authorPanel.Visible = true;
        }

        private async Task openPublisherPanel(string id)
        {
            JObject publisherData = await GetRequests.GetPublisherById(id);
            publisherLabelPublisherPanel.Text = "Publisher " + publisherData["name"]!.ToString();
            emailLabelPublisherPanel.Text = publisherData["email"]!.ToString();
            phoneLabelPublisherPanel.Text = publisherData["phone"]!.ToString();
            idPublisherPanel.Text = id;
            homePanel.Visible = false;
            publisherPanel.Visible = true;
        }

        private async Task openGenrePanel(string id)
        {
            JObject genreData = await GetRequests.GetGenreById(id);
            genreLabelGenrePanel.Text = genreData["genre"].ToString();
            idGenrePanel.Text = id;
            homePanel.Visible = false;
            genrePanel.Visible = true;
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
            await openGenrePanel(e.Node.Tag.ToString());
        }

        private void homeButtonGenrePanel_Click(object sender, EventArgs e)
        {
            genrePanel.Visible = false;
            homePanel.Visible = true;
        }
    }
}