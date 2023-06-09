using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
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
        //DbTable table;
        LibraryForm form;
        FlowLayoutPanel parentFlow;
        public ClickableBookItem(string id, DbTable table, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
            this.parentFlow = parentFlow;
            Size = new Size(170, 340);
            //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MouseEnter += enableBorder;
            textBox.MouseEnter += enableBorder;
            pictureBox.MouseEnter += enableBorder;

            MouseLeave += disableBorder;
            textBox.MouseLeave += disableBorder;
            pictureBox.MouseLeave += disableBorder;
            this.id = id;

            this.form = form;
            MouseClick += MouseClicked;
            textBox.MouseClick += MouseClicked;
            pictureBox.MouseClick += MouseClicked;

            populate();
        }

        private async void populate()
        {
            Book book = await GetRequests.GetBookById(id);

            textBox.Text = book.title;
            if (book.imageUrl != string.Empty)
                pictureBox.LoadAsync(book.imageUrl);
            else
                pictureBox.LoadAsync(new Uri(@"Resourses\placeholder.png", UriKind.Relative).ToString());

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
    }
}
