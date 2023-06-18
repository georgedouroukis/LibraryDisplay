using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.UserControls.GenericItems;
using LibraryDisplay.Utils.Models;
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
    public partial class CollectionControl : UserControl
    {
        private LibraryForm parentForm;
        public CollectionControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            collectionPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonCollectionPanel_Click(object sender, EventArgs e)
        {
            parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CollectionContol));
            parentForm.navigationForwardStack.Clear();
            parentForm.homeControl.BringToFront();
        }

        public async Task openCollectionPanel()
        {
            collectionBookFlow.Controls.Clear();
            HashSet<Book> set = await GetRequests.GetBooks();

            foreach (var book in set)
            {
                ClickableBookItem item = new ClickableBookItem(book.id.ToString(), string.Empty, null, parentForm, collectionBookFlow);
                collectionBookFlow.Controls.Add(item);
            }
            this.BringToFront();
        }
    }
}
