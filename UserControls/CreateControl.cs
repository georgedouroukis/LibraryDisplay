using LibraryDisplay.Models;
using LibraryDisplay.Network;
using LibraryDisplay.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            populateEditBookPanel(new Book());
        }

        protected override void editTabs_Selecting(object sender, TabControlCancelEventArgs e) 
        {
            //if (editTabs.SelectedTab == bookEditTab)
            //    populateEditBookPanel(new Book());
            //else if (editTabs.SelectedTab == authorEditTab)
            //    populateEditAuthorPanel(new Author() , CallFrom.None);
            //else if (editTabs.SelectedTab == publisherEditTab)
            //    populateEditPublisherPanel(new Publisher(), CallFrom.None);
            //else
            //    populateEditGenrePanel(new Genre(), CallFrom.None);
        }

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
                                

                                if (calledFrom == CallFrom.None)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book());
                                    await parentForm.authorControl.openAuthorPanel(id);
                                }
                                else if (calledFrom == CallFrom.CreateBook)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book(parentForm.createControl.tempBook));
                                    calledFrom = CallFrom.None;
                                }
                                else if (calledFrom == CallFrom.EditBook)
                                {
                                    parentForm.editControl.populateEditBookPanel(new Book(parentForm.editControl.tempBook));
                                    calledFrom = CallFrom.None;
                                }

                                break;

                            case DbTable.Genre:
                                id = await PostRequests.CreateEntity<Genre>(tempGenre);
                                parentForm.homeControl.genreTreeViewPopulate(); //refresh

                                if (calledFrom == CallFrom.None)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book());
                                    await parentForm.genreControl.openGenrePanel(id);
                                }

                                else if (calledFrom == CallFrom.CreateBook)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book(parentForm.createControl.tempBook));
                                    calledFrom = CallFrom.None;
                                    
                                }
                                else if (calledFrom == CallFrom.EditBook)
                                {
                                    parentForm.editControl.populateEditBookPanel(new Book(parentForm.editControl.tempBook));
                                    calledFrom = CallFrom.None;
                                }
                                else if (calledFrom == CallFrom.CreateGenre)
                                {
                                    parentForm.createControl.populateEditGenrePanel(parentForm.createControl.tempGenre, CallFrom.None);
                                    calledFrom = CallFrom.None;

                                }
                                else if (calledFrom == CallFrom.EditGenre)
                                {
                                    parentForm.editControl.populateEditGenrePanel(parentForm.editControl.tempGenre, CallFrom.None);
                                    calledFrom = CallFrom.None;
                                }

                                parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.None); //refresh

                                break;


                            case DbTable.Publisher:
                                id = await PostRequests.CreateEntity<Publisher>(tempPublisher);

                                if (calledFrom == CallFrom.None)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book());
                                    await parentForm.publisherControl.openPublisherPanel(id);
                                }

                                else if (calledFrom == CallFrom.CreateBook)
                                {
                                    parentForm.createControl.populateEditBookPanel(parentForm.createControl.tempBook);
                                    calledFrom = CallFrom.None;
                                }
                                else if (calledFrom == CallFrom.EditBook)
                                {
                                    parentForm.editControl.populateEditBookPanel(parentForm.editControl.tempBook);
                                    calledFrom = CallFrom.None;
                                }
                                
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
