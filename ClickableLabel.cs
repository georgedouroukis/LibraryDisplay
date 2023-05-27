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
        
        public ClickableLabel(string id, DbTable table) : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            this.MouseEnter += changeColor;
            this.MouseLeave += changeColorback;
            this.id = id;
            this.table = table;
            
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

    }
}
