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
    public partial class PublisherControl : UserControl
    {
        private LibraryForm parentForm;
        public PublisherControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            publisherPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonPublisherPanel_Click(object sender, EventArgs e)
        {
            parentForm.homeControl.BringToFront();
        }

        public async Task openPublisherPanel(string id)
        {
            publisherBookFlow.Controls.Clear();
            JObject publisherData = await GetRequests.GetPublisherById(id);
            publisherLabelPublisherPanel.Text = "Publisher " + publisherData["name"]!.ToString();
            emailLabelPublisherPanel.Text = publisherData["email"]!.ToString();
            phoneLabelPublisherPanel.Text = publisherData["phone"]!.ToString();
            idPublisherPanel.Text = id;

            foreach (var item in publisherData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, parentForm);
                JObject author = await GetRequests.GetBookById(item.ToString());
                publisherBookFlow.Controls.Add(book);
            }
        }
    }
}
