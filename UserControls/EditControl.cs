using LibraryDisplay.Models;
using LibraryDisplay.Network;
using LibraryDisplay.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.UserControls
{
    public class DummyToPreventDesignerOpening1 { }
    internal class EditControl : AbstractEditCreate
    {
        public EditControl(LibraryForm parentForm) : base(parentForm)
        {
            pageTitle.Text = "Edit...";
            bookEditTab.Enabled = false;
            authorEditTab.Enabled = false;
            publisherEditTab.Enabled = false;
            genreEditTab.Enabled = false;
        }

        protected override async void saveButtonEditPanel_Click(object sender, EventArgs e)
        {
            EditStatus status = checkStatus();
            if (status.HasChanges)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Save Changes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        switch (status.Table)
                        {
                            case DbTable.Book:
                                await PutRequests.UpdateEntity<Book>(tempBook);
                                await parentForm.bookControl.openBookPanel(tempBook.id.ToString());
                                break;
                            case DbTable.Author:
                                await PutRequests.UpdateEntity<Author>(tempAuthor);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                await parentForm.authorControl.openAuthorPanel(tempAuthor.id.ToString());
                                break;
                            case DbTable.Publisher:
                                await PutRequests.UpdateEntity<Publisher>(tempPublisher);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                await parentForm.publisherControl.openPublisherPanel(tempPublisher.id.ToString());
                                break;
                            case DbTable.Genre:
                                await PutRequests.UpdateEntity<Genre>(tempGenre);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.None, true);
                                parentForm.homeControl.genreTreeViewPopulate();
                                await parentForm.genreControl.openGenrePanel(tempGenre.id.ToString());
                                break;
                        }
                        bookEditTab.Enabled = false;
                        authorEditTab.Enabled = false;
                        publisherEditTab.Enabled = false;
                        genreEditTab.Enabled = false;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                Console.WriteLine("no changes found");
            }
        }

        protected override void editTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //to not navigate to disabled tabs
            if (e.TabPage.Enabled == false)
                e.Cancel = true;
        }
    }
}
