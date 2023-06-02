using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDisplay.Models;

namespace LibraryDisplay.UserControls.GenericItems
{
    internal class RemovableLabel : Label
    {

        public string id;
        DbTable table;
        LibraryForm form;
        FlowLayoutPanel parentFlow;

        public RemovableLabel(string id, DbTable table, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            BackColor = SystemColors.ControlDarkDark;
            ForeColor = Color.White;
            MouseEnter += changeColor;
            MouseLeave += changeColorback;
            this.id = id;
            this.table = table;
            this.form = form;
            MouseClick += MouseClicked;
            this.parentFlow = parentFlow;
        }

        public void changeColor(object sender, EventArgs e)
        {
            BackColor = Color.LightSalmon;
            ForeColor = Color.White;
            Font = new Font(this.Font, FontStyle.Strikeout);
        }

        public void changeColorback(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDarkDark;
            ForeColor = Color.White;
            Font = new Font(this.Font, FontStyle.Regular);

        }

        public  void MouseClicked(object sender, EventArgs e)
        {
            parentFlow.Controls.Remove(this);
        }
    }
}
