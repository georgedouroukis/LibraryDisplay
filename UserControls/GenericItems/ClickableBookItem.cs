using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.Utils.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryDisplay.UserControls.GenericItems
{
    public partial class ClickableBookItem : UserControl
    {
        string id;
        string callerId;
        DbTable table;
        LibraryForm form;
        FlowLayoutPanel parentFlow;
        public ClickableBookItem(string id, string callerId, DbTable? table, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
            this.parentFlow = parentFlow;
            Size = new Size(170, 340);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MouseEnter += enableBorder;
            textBox.MouseEnter += enableBorder;
            pictureBox.MouseEnter += enableBorder;

            MouseLeave += disableBorder;
            textBox.MouseLeave += disableBorder;
            pictureBox.MouseLeave += disableBorder;
            this.id = id;
            this.callerId = callerId;

            this.form = form;
            if (table != null) this.table = table.Value;
            MouseClick += MouseClicked;
            textBox.MouseClick += MouseClicked;
            pictureBox.MouseClick += MouseClicked;
            
            

            populate();
        }

        private async void populate()
        {
            Book book = await GetRequests.GetBookById(id);

            textBox.Text = book.title;

            Image image = await ImageHandler.GetImageFromUrl(book.imageUrl);
            pictureBox.Image = image;
        }

        public void enableBorder(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void disableBorder(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        public async void MouseClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await form.bookControl.openBookPanel(id);
                backNavigationPush();
                form.bookControl.BringToFront();
            }
        }

        private void backNavigationPush()
        {
            if (table == DbTable.Book)
                form.navigationBackStack.Push(new NavigationItem(PanelState.BookControl) { referencedId = callerId });
            else if (table == DbTable.Author)
                form.navigationBackStack.Push(new NavigationItem(PanelState.AuthorControl) { referencedId = callerId });
            else if (table == DbTable.Publisher)
                form.navigationBackStack.Push(new NavigationItem(PanelState.PublisherControl) { referencedId = callerId });
            else if (table == DbTable.Genre)
                form.navigationBackStack.Push(new NavigationItem(PanelState.GenreControl) { referencedId = callerId });
            else
                form.navigationBackStack.Push(new NavigationItem(PanelState.CollectionContol));
            form.navigationForwardStack.Clear();
        }
    }
}
