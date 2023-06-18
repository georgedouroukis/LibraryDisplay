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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDisplay.UserControls
{
    public partial class AuthorControl : UserControl
    {
        private LibraryForm parentForm;
        public Author referencedAuthor;
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
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.AuthorControl) { author = referencedAuthor});
            parentForm.homeControl.BringToFront();
        }

        public async Task openAuthorPanel(string id)
        {
            authorBookFlow.Controls.Clear();
            Author author = await GetRequests.GetAuthorById(id);
            referencedAuthor = author;

            authorLabelAuthorPanel.Text = author.firstName + " " + author.lastName + " " + author.middleName;
            descriptionLabelAuthorPanel.Text = author.description;

            foreach (var item in author.books)
            {
                ClickableBookItem book = new ClickableBookItem(item.ToString(), id, DbTable.Author, parentForm, authorBookFlow);
                authorBookFlow.Controls.Add(book);
            }
            this.BringToFront();
        }

        private void editButtonAuthorPanel_Click(object sender, EventArgs e)
        {
            parentForm.editControl.BringToFront();
            parentForm.navigationBackStack.Push(new Utils.Models.NavigationItem(PanelState.AuthorControl) { author = referencedAuthor });
            parentForm.editControl.populateEditAuthorPanel(referencedAuthor, CallFrom.None, true);
        }
    }
}
