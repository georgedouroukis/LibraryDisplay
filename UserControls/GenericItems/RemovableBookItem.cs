using LibraryDisplay.Models;
using LibraryDisplay.Network;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.UserControls.GenericItems
{
    internal class RemovableBookItem : UserControl
    {

        string id;
        //DbTable table;
        LibraryForm form;
        PictureBox pictureBox = new PictureBox();
        Label label = new Label();
        FlowLayoutPanel parentFlow;

        public RemovableBookItem(string id, DbTable table, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            Cursor = Cursors.Hand;
            this.parentFlow = parentFlow;
            Margin = new Padding(10);
            Padding = new Padding(0);
            pictureBox.Margin = new Padding(10);
            pictureBox.Padding = new Padding(0);
            label.Margin = new Padding(0);
            label.Padding = new Padding(0);
            Size = new Size(150, 240);
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(140, 190);

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            label.Dock = DockStyle.Bottom;
            label.MaximumSize = new Size(150, 0);
            label.AutoSize = true;

            label.TextAlign = ContentAlignment.MiddleCenter;

            MouseEnter += enableBorder;
            label.MouseEnter += enableBorder;
            pictureBox.MouseEnter += enableBorder;

            MouseLeave += disableBorder;
            label.MouseLeave += disableBorder;
            pictureBox.MouseLeave += disableBorder;
            this.id = id;

            this.form = form;
            MouseClick += MouseClicked;
            label.MouseClick += MouseClicked;
            pictureBox.MouseClick += MouseClicked;

            populate();
        }

        private async void populate()
        {
            Book book = await GetRequests.GetBookById(id);

            label.Text = book.title;
            if (book.imageUrl != string.Empty)
                pictureBox.LoadAsync(book.imageUrl);
            else
                pictureBox.LoadAsync(new Uri(@"Resourses\placeholder.png", UriKind.Relative).ToString());

            Controls.Add(pictureBox);
            Controls.Add(label);
        }

        public void enableBorder(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void disableBorder(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        public async void MouseClicked(object sender, EventArgs e)
        {
            await form.bookControl.openBookPanel(id);
            form.bookControl.BringToFront();
        }

        private void InitializeComponent()
        {

        }

        private void ClickableBookItem_Load(object sender, EventArgs e)
        {
        }
    }
}
