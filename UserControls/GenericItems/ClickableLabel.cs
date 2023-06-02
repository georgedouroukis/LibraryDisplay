using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDisplay.Models;

namespace LibraryDisplay.UserControls.GenericItems
{
    internal class ClickableLabel : Label
    {

        string id;
        DbTable table;
        LibraryForm form;
        FlowLayoutPanel parentFlow;


        public ClickableLabel(string id, DbTable table, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            MouseEnter += changeColor;
            MouseLeave += changeColorback;
            this.id = id;
            this.table = table;
            this.form = form;
            this.parentFlow = parentFlow;
            MouseClick += MouseClicked;
        }

        public void changeColor(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDarkDark;
            ForeColor = Color.White;
        }

        public void changeColorback(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            ForeColor = Color.Black;

        }

        public async void MouseClicked(object sender, EventArgs e)
        {
            if (table == DbTable.Genre)
            {
                await form.genreControl.openGenrePanel(id);
                form.genreControl.BringToFront();
            }
            else if (table == DbTable.Author)
            {
                await form.authorControl.openAuthorPanel(id);
                form.authorControl.BringToFront();
            }
            else if (table == DbTable.Publisher)
            {
                await form.publisherControl.openPublisherPanel(id);
                form.publisherControl.BringToFront();
            }
        }
    }
}
