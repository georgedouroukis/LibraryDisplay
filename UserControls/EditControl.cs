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
            deleteButtonEditPanel.Visible = true;
        }

        protected override async void deleteButtonEditPanel_Click(object sender, EventArgs e)
        {
            EditStatus status = checkStatus();
            DialogResult dr;
            switch (status.Table)
            {
                case DbTable.Book:
                    dr = MessageBox.Show("This book will not be deleted if it is associated with another entry. \nAre you sure?", "Delete Book", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        await DeleteRequests.DeleteEntity<Book>(referencedBook!);
                    break;
                case DbTable.Author:
                    dr = MessageBox.Show("This author will not be deleted if it is associated with another entry. \nAre you sure?", "Delete Author", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        await DeleteRequests.DeleteEntity<Author>(referencedAuthor!);
                    break;
                case DbTable.Publisher:
                    dr = MessageBox.Show("This publisher will not be deleted if it is associated with another entry. \nAre you sure?", "Delete Publisher", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        await DeleteRequests.DeleteEntity<Publisher>(referencedPublisher!);
                    break;
                case DbTable.Genre:
                    dr = MessageBox.Show("This genre will not be deleted if it is associated with another entry. \nAre you sure?", "Delete Genre", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        await DeleteRequests.DeleteEntity<Genre>(referencedGenre!);
                    break;
            }
            // refresh not implementet yet
            parentForm.homeControl.BringToFront();
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
