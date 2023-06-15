using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.Utils.Models;
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
                    dr = MessageBox.Show("This action will delete only the selected book.\nAny associated authors, publishers or genres will not be affected.\nAre you sure?", "Delete Book", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await DeleteRequests.DeleteEntity<Book>(referencedBook!);
                        parentForm.homeControl.BringToFront();
                    }
                        break;
                case DbTable.Author:
                    dr = MessageBox.Show("This author will not be deleted if they are associated with any books. \nAre you sure?", "Delete Author", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await DeleteRequests.DeleteEntity<Author>(referencedAuthor!);
                        parentForm.homeControl.BringToFront();
                    }
                        break;
                case DbTable.Publisher:
                    dr = MessageBox.Show("This publisher will not be deleted if they are associated with any books. \nAre you sure?", "Delete Publisher", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await DeleteRequests.DeleteEntity<Publisher>(referencedPublisher!);
                        parentForm.homeControl.BringToFront();
                    }
                        break;
                case DbTable.Genre:
                    dr = MessageBox.Show("This genre will not be deleted if it is associated with any books. \nAre you sure?", "Delete Genre", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await DeleteRequests.DeleteEntity<Genre>(referencedGenre!);
                        parentForm.homeControl.genreTreeViewPopulate();/// only this implemented
                        parentForm.homeControl.BringToFront();
                    }
                        break;
            }
            // refresh not implementet yet
            
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
                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditBook) { book = tempBook });
                                break;
                            case DbTable.Author:
                                await PutRequests.UpdateEntity<Author>(tempAuthor);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                await parentForm.authorControl.openAuthorPanel(tempAuthor.id.ToString());
                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditAuthor) { author = tempAuthor });
                                break;
                            case DbTable.Publisher:
                                await PutRequests.UpdateEntity<Publisher>(tempPublisher);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                await parentForm.publisherControl.openPublisherPanel(tempPublisher.id.ToString());
                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditPublisher) { publisher = tempPublisher });
                                break;
                            case DbTable.Genre:
                                await PutRequests.UpdateEntity<Genre>(tempGenre);
                                parentForm.createControl.populateEditBookPanel(new Book(), true); //regenerate panels
                                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.None, true);
                                parentForm.homeControl.genreTreeViewPopulate();
                                await parentForm.genreControl.openGenrePanel(tempGenre.id.ToString());
                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditGenre) { genre = tempGenre });
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

        protected override void homeButtonEditPanel_Click(object sender, EventArgs e)
        {
            if (checkStatus().HasChanges)
            {
                DialogResult dr = MessageBox.Show("Discard Changes?", "Unsaved Changes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        navigationHomePush();
                        parentForm.homeControl.BringToFront();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                navigationHomePush();
                parentForm.homeControl.BringToFront();
            }
        }

        private void navigationHomePush()
        {
            if (editTabs.SelectedTab == bookEditTab)
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditBook) { book = referencedBook });
            else if (editTabs.SelectedTab == authorEditTab)
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditAuthor) { author = referencedAuthor });
            else if (editTabs.SelectedTab == publisherEditTab)
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditPublisher) { publisher = referencedPublisher });
            else
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditGenre) { genre = referencedGenre });
        }
    }
}
