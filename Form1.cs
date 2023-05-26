using Newtonsoft.Json.Linq;

namespace LibraryDisplay
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
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
                    JObject data = await GetRequests.GetBookById(firstSelectedItem.SubItems[2].Text);
                    pagesLabelBookPanel.Text = data["pageNumber"].ToString();
                    isbnLabelBookPanel.Text = data["isbn"].ToString();
                    publicationDateLabelBookPanel.Text = data["publicationDate"].ToString();
                    bookLabelBookPanel.Text = data["title"].ToString();
                    JObject publisher = await GetRequests.GetPublisherById(data["publisher"].ToString());
                    publisherLabelBookPanel.Text = publisher["name"].ToString();
                    foreach (var item in data["authors"])
                    {
                        Label label = new Label();
                        JObject author = await GetRequests.GetAuthorsById(item.ToString());
                        label.Text = author["firstName"] + " " + author["lastName"] + " " + author["middleName"];
                        label.AutoSize = true;
                        label.BorderStyle = BorderStyle.FixedSingle;
                        authorFlowBookPanel.Controls.Add(label);
                    }
                    homePanel.Visible = false;
                    bookPanel.Visible = true;
                    break;
                case "Author":
                    Console.WriteLine(firstSelectedItem.SubItems[2].Text + " Author2");
                    break;
                case "Publisher":
                    Console.WriteLine(firstSelectedItem.SubItems[2].Text + " Publisher3");
                    break;
            }
        }


    }
}