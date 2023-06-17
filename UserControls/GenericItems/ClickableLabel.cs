using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Utils.Models;

namespace LibraryDisplay.UserControls.GenericItems
{
    internal class ClickableLabel : Label
    {

        string id;
        string callerId;
        DbTable fromTable;
        DbTable toTable;
        LibraryForm form;
        FlowLayoutPanel parentFlow;


        public ClickableLabel(string id, string callerId, DbTable fromTable, DbTable toTable, LibraryForm form, FlowLayoutPanel parentFlow) : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            MouseEnter += changeColor;
            MouseLeave += changeColorback;
            this.id = id;
            this.callerId = callerId;
            this.fromTable = fromTable;
            this.toTable = toTable;
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

        public async void MouseClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (fromTable==DbTable.Genre)
                    form.navigationBackStack.Push(new NavigationItem(PanelState.GenreControl) { referencedId = callerId });
                else
                    form.navigationBackStack.Push(new NavigationItem(PanelState.BookControl) { referencedId = callerId });

                if (toTable == DbTable.Genre)
                {
                    await form.genreControl.openGenrePanel(id);
                    form.genreControl.BringToFront();
                }
                else if (toTable == DbTable.Author)
                {
                    await form.authorControl.openAuthorPanel(id);
                    form.authorControl.BringToFront();
                }
                else if (toTable == DbTable.Publisher)
                {
                    await form.publisherControl.openPublisherPanel(id);
                    form.publisherControl.BringToFront();
                }
            }
        }
    }
}
