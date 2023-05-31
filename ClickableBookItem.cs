using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay
{
    internal class ClickableBookItem : UserControl
    {

        string id;
        //DbTable table;
        LibraryForm form;
        PictureBox pictureBox = new PictureBox();
        Label label = new Label();

        public ClickableBookItem(string id, DbTable table, LibraryForm form) : base()
        {
            Cursor = Cursors.Hand;
            this.Margin = new Padding(10);
            this.Padding = new Padding(0);
            pictureBox.Margin = new Padding(10);
            pictureBox.Padding = new Padding(0);
            label.Margin = new Padding(0);
            label.Padding = new Padding(0);
            this.Size = new Size(150, 240);
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(140,190);
            
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            label.Dock = DockStyle.Bottom;
            label.MaximumSize = new Size(150, 0);
            label.AutoSize = true;

            label.TextAlign = ContentAlignment.MiddleCenter;
            
            this.MouseEnter += enableBorder;
            this.label.MouseEnter += enableBorder;
            this.pictureBox.MouseEnter += enableBorder;
           
            this.MouseLeave += disableBorder;
            this.label.MouseLeave += disableBorder;
            this.pictureBox.MouseLeave += disableBorder;
            this.id = id;
            
            this.form = form;
            this.MouseClick += MouseClicked;
            this.label.MouseClick += MouseClicked;
            this.pictureBox.MouseClick += MouseClicked;

            this.populate();

        }

        private async void populate()
        {
            JObject data = await GetRequests.GetBookById(this.id);
            
            label.Text = data["title"]!.ToString();
            pictureBox.LoadAsync(data["imageUrl"]!.ToString());
            
            this.Controls.Add(pictureBox);
            this.Controls.Add(label);
        }

        public void enableBorder(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void disableBorder(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        public async void MouseClicked(object sender, EventArgs e)
        {
             await form.openBookPanel(id);
        }

    }
}
