using LibraryDisplay.Models;
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
    public partial class EditControl : UserControl
    {
        private LibraryForm parentForm;
        public EditControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            editPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonEditPanel_Click(object sender, EventArgs e)
        {
            parentForm.homeControl.BringToFront();
        }

        private async void openEditBookPanel()
        {
            //titleTextBoxEditBookPanel.Text = bookLabelBookPanel.Text;
            //pagesTextBoxEditBookPanel.Text = pagesLabelBookPanel.Text;
            //dateTextBoxEditBookPanel.Text = publicationDateLabelBookPanel.Text;
            //isbnTextBoxEditBookPanel.Text = isbnLabelBookPanel.Text;
            //descriptionTextBoxEditBookPanel.Text = descriptionLabelBookPanel.Text;

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
