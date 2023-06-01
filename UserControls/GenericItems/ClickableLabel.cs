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

        public ClickableLabel(string id, DbTable table, LibraryForm form) : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            MouseEnter += changeColor;
            MouseLeave += changeColorback;
            this.id = id;
            this.table = table;
            this.form = form;
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
                await form.openGenrePanel(id);
            }
            else if (table == DbTable.Author)
            {
                await form.openAuthorPanel(id);
            }
            else if (table == DbTable.Publisher)
            {
                await form.openPublisherPanel(id);
            }
        }
    }
}
