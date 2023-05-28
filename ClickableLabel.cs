using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay
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
            this.MouseEnter += changeColor;
            this.MouseLeave += changeColorback;
            this.id = id;
            this.table = table;
            this.form = form;
            this.MouseClick += MouseClicked;
            
        }

        public void changeColor(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ForeColor = Color.White;
        }

        public void changeColorback(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.Control;
            ForeColor = Color.Black;

        }

        public async void MouseClicked(object sender, EventArgs e)
        {
            if (this.table == DbTable.Genre) 
            {
                await form.openGenrePanel(id);
            }
            else if (this.table == DbTable.Author)
            {
                await form.openAuthorPanel(id);
            }
            else if (this.table == DbTable.Publisher)
            {
                await form.openPublisherPanel(id);
            }
        }
    }
}
