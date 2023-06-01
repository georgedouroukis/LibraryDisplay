using LibraryDisplay.Models;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils;
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
            Size size = new Size(1200, 1200);
            this.Size = size;
            homePanel.Dock = DockStyle.Fill;
            homePanel.Visible = true;
            bookPanel.Dock = DockStyle.Fill;
            bookPanel.Visible = true;
            authorPanel.Dock = DockStyle.Fill;
            authorPanel.Visible = true;
            publisherPanel.Dock = DockStyle.Fill;
            publisherPanel.Visible = true;
            collectionPanel.Dock = DockStyle.Fill;
            collectionPanel.Visible = true;
            createPanel.Dock = DockStyle.Fill;
            createPanel.Visible = true;
            genrePanel.Dock = DockStyle.Fill;
            genrePanel.Visible = true;
            editPanel.Dock = DockStyle.Fill;
            editPanel.Visible = true;
            homePanel.BringToFront();
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
            homePanel.Visible = false;
            authorPanel.Visible = false;
            publisherPanel.Visible = false;
            genrePanel.Visible = false;
            bookPanel.Visible = true;

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
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Author, this); //this param is used for id
                JObject author = await GetRequests.GetAuthorById(item.ToString());
                label.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                authorFlowBookPanel.Controls.Add(label);
            }

            //get publisher
            JObject publisher = await GetRequests.GetPublisherById(data["publisher"]!.ToString());
            ClickableLabel publisherLabel = new ClickableLabel(data["publisher"]!.ToString(), DbTable.Publisher, this);
            publisherLabel.Text = publisher["name"]!.ToString();
            publisherFlowBookPanel.Controls.Add(publisherLabel);

            //get genres
            foreach (var item in data["genres"]!)
            {
                ClickableLabel label = new ClickableLabel(item.ToString(), DbTable.Genre, this);
                JObject genre = await GetRequests.GetGenreById(item.ToString());
                label.Text = genre["genre"]!.ToString();
                genreFlowBookPanel.Controls.Add(label);
            }
            idBookPanel.Text = id;

        }

        public async Task openAuthorPanel(string id)
        {

            authorBookFlow.Controls.Clear();
            JObject authorData = await GetRequests.GetAuthorById(id);
            authorLabelAuthorPanel.Text = authorData["firstName"] + " " + authorData["lastName"] + " " + authorData["middleName"];
            descriptionLabelAuthorPanel.Text = authorData["description"]!.ToString();
            idAuthorPanel.Text = id;
            homePanel.Visible = false;
            bookPanel.Visible = false;
            authorPanel.Visible = true;

            foreach (var item in authorData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, this);
                JObject author = await GetRequests.GetBookById(item.ToString());
                authorBookFlow.Controls.Add(book);
            }
        }

        public async Task openPublisherPanel(string id)
        {
            publisherBookFlow.Controls.Clear();
            JObject publisherData = await GetRequests.GetPublisherById(id);
            publisherLabelPublisherPanel.Text = "Publisher " + publisherData["name"]!.ToString();
            emailLabelPublisherPanel.Text = publisherData["email"]!.ToString();
            phoneLabelPublisherPanel.Text = publisherData["phone"]!.ToString();
            idPublisherPanel.Text = id;
            homePanel.Visible = false;
            bookPanel.Visible = false;
            publisherPanel.Visible = true;

            foreach (var item in publisherData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, this);
                JObject author = await GetRequests.GetBookById(item.ToString());
                publisherBookFlow.Controls.Add(book);
            }
        }

        public async Task openGenrePanel(string id)
        {
            genreBookFlow.Controls.Clear();
            JObject genreData = await GetRequests.GetGenreById(id);
            genreLabelGenrePanel.Text = genreData["genre"].ToString();
            idGenrePanel.Text = id;
            homePanel.Visible = false;
            bookPanel.Visible = false;
            genrePanel.Visible = true;

            foreach (var item in genreData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, this);
                JObject author = await GetRequests.GetBookById(item.ToString());
                genreBookFlow.Controls.Add(book);
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
            await openGenrePanel(e.Node.Tag.ToString());
        }

        private void homeButtonGenrePanel_Click(object sender, EventArgs e)
        {
            genrePanel.Visible = false;
            homePanel.Visible = true;
        }

        private async void openEditBookPanel()
        {
            titleTextBoxEditBookPanel.Text = bookLabelBookPanel.Text;
            pagesTextBoxEditBookPanel.Text = pagesLabelBookPanel.Text;
            dateTextBoxEditBookPanel.Text = publicationDateLabelBookPanel.Text;
            isbnTextBoxEditBookPanel.Text = isbnLabelBookPanel.Text;
            descriptionTextBoxEditBookPanel.Text = descriptionLabelBookPanel.Text;

            List<JObject> authors = await GetRequests.GetAuthors();
            authorComboBoxEditBookPanel.Controls.Clear();
            foreach (JObject author in authors)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                item.Id = author["id"]!.ToString();
                authorComboBoxEditBookPanel.Items.Add(item);
            }

            List<JObject> publishers = await GetRequests.GetPublishers();
            publisherComboBoxEditBookPanel.Controls.Clear();
            foreach (JObject publisher in publishers)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = publisher["name"]!.ToString();
                item.Id = publisher["id"]!.ToString();
                publisherComboBoxEditBookPanel.Items.Add(item);
            }

            List<JObject> genres = await GetRequests.GetGenres();
            genreComboBoxEditBookPanel.Controls.Clear();
            foreach (JObject genre in genres)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = genre["genre"]!.ToString();
                item.Id = genre["id"]!.ToString();
                genreComboBoxEditBookPanel.Items.Add(item);
            }

            bookPanel.Visible = false;
            editPanel.Visible = true;
            editTabs.SelectedTab = bookEditTab;
            authorEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            genreEditTab.Enabled = false;

        }

        private void editButtonBookPanel_Click(object sender, EventArgs e)
        {
            openEditBookPanel();
        }

        private void editTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
                e.Cancel = true;
        }
    }
}