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
    public class DummyToPreventDesignerOpening2 { }

    internal class CreateControl : AbstractEditCreate
    {
        public CreateControl(LibraryForm parentForm) : base(parentForm)
        {
            pageTitle.Text = "Create...";
            bookEditTab.Enabled = true;
            authorEditTab.Enabled = true;
            publisherEditTab.Enabled = true;
            genreEditTab.Enabled = true;
            referencedBook = new Book();
            referencedAuthor = new Author();
            referencedPublisher = new Publisher();
            referencedGenre = new Genre();
            openEditBookPanel(null);
        }

        protected override void editTabs_Selecting(object sender, TabControlCancelEventArgs e) { }

        protected override async void saveButtonEditPanel_Click(object sender, EventArgs e)
        {
            EditStatus status = checkStatus();
            string id = string.Empty;
            if (status.HasChanges)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Save Changes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        switch (status.Table)
                        {
                            case DbTable.Book:
                                id = await PostRequests.CreateEntity<Book>(tempBook);
                                await parentForm.bookControl.openBookPanel(id);
                                break;
                            case DbTable.Author:
                                id = await PostRequests.CreateEntity<Author>(tempAuthor);
                                openEditBookPanel(null);
                                await parentForm.authorControl.openAuthorPanel(id);
                                break;
                            case DbTable.Publisher:
                                id = await PostRequests.CreateEntity<Publisher>(tempPublisher);
                                openEditBookPanel(null);
                                await parentForm.publisherControl.openPublisherPanel(id);
                                break;
                            case DbTable.Genre:
                                id = await PostRequests.CreateEntity<Genre>(tempGenre);
                                openEditBookPanel(null);
                                openEditGenrePanel(null);
                                parentForm.homeControl.genreTreeViewPopulate();
                                await parentForm.genreControl.openGenrePanel(id);
                                break;
                        }
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
    }
}
