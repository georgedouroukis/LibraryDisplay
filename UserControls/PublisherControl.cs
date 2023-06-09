﻿using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils.Models;
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
        public Publisher referencedPublisher;
        public PublisherControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            publisherPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonPublisherPanel_Click(object sender, EventArgs e)
        {
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.PublisherControl) { publisher = referencedPublisher});
            parentForm.navigationForwardStack.Clear();
            parentForm.homeControl.BringToFront();
        }

        public async Task openPublisherPanel(string id)
        {
            publisherBookFlow.Controls.Clear();
            Publisher publisher = await GetRequests.GetPublisherById(id);
            referencedPublisher = publisher;

            publisherLabelPublisherPanel.Text = "Publisher " + publisher.name;
            emailLabelPublisherPanel.Text = publisher.email;
            phoneLabelPublisherPanel.Text = publisher.phone;


            foreach (var item in publisher.books)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), id, DbTable.Author, parentForm, publisherBookFlow);
                publisherBookFlow.Controls.Add(book);
            }
            this.BringToFront();
        }

        private void editButtonPublisherPanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.BringToFront();
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.PublisherControl) { publisher = referencedPublisher });
            parentForm.navigationForwardStack.Clear();
            parentForm.editControl.populateEditPublisherPanel(referencedPublisher, CallFrom.None, true);
        }
    }
}
