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
    public partial class AuthorControl : UserControl
    {
        private LibraryForm parentForm;
        public AuthorControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            authorPanel.Dock = DockStyle.Fill;
        }

        private void AuthorControl_Load(object sender, EventArgs e)
        {

        }

        private void homeButtonAuthorPanel_Click(object sender, EventArgs e)
        {
            parentForm.homeControl.BringToFront();
        }

        public async Task openAuthorPanel(string id)
        {

            authorBookFlow.Controls.Clear();
            JObject authorData = await GetRequests.GetAuthorById(id);
            authorLabelAuthorPanel.Text = authorData["firstName"] + " " + authorData["lastName"] + " " + authorData["middleName"];
            descriptionLabelAuthorPanel.Text = authorData["description"]!.ToString();
            


            foreach (var item in authorData["books"]!)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), DbTable.Author, parentForm, authorBookFlow);
                JObject author = await GetRequests.GetBookById(item.ToString());
                authorBookFlow.Controls.Add(book);
            }
        }
    }
}
