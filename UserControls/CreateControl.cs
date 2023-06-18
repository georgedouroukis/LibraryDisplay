using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using LibraryDisplay.Network;
using LibraryDisplay.Utils.Models;
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
            deleteButtonEditPanel.Visible = false;
            populateEditBookPanel(new Book(), true);
        }

        protected override void deleteButtonEditPanel_Click(object sender, EventArgs e){}

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
            {
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreateBook) { book = new Book() });
                parentForm.navigationForwardStack.Clear();
            }
            else if (editTabs.SelectedTab == authorEditTab)
            {
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreateAuthor) { author = new Author() });
                parentForm.navigationForwardStack.Clear();
            }
            else if (editTabs.SelectedTab == publisherEditTab)
            {
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreatePublisher) { publisher = new Publisher() });
                parentForm.navigationForwardStack.Clear();
            }
            else
            {
                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreateGenre) { genre = new Genre() });
                parentForm.navigationForwardStack.Clear();
            }
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
                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditBook) { referencedId = id });
                                parentForm.navigationForwardStack.Clear();
                                await parentForm.bookControl.openBookPanel(id);
                                break;


                            case DbTable.Author:

                                id = await PostRequests.CreateEntity<Author>(tempAuthor);


                                if (calledFrom == CallFrom.None)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book(), true);
                                    await parentForm.authorControl.openAuthorPanel(id);
                                }
                                else if (calledFrom == CallFrom.CreateBook)
                                {
                                    if (!string.IsNullOrEmpty(id))
                                        parentForm.createControl.tempBook.authors.Add(Int32.Parse(id));
                                    parentForm.createControl.populateEditBookPanel(new Book(parentForm.createControl.tempBook), false);
                                    calledFrom = CallFrom.None;
                                }
                                else if (calledFrom == CallFrom.EditBook)
                                {
                                    if (!string.IsNullOrEmpty(id))
                                        parentForm.editControl.tempBook.authors.Add(Int32.Parse(id));
                                    parentForm.editControl.populateEditBookPanel(new Book(parentForm.editControl.tempBook), false);
                                    calledFrom = CallFrom.None;
                                    parentForm.editControl.BringToFront();
                                }

                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditAuthor) { referencedId = id }); //because its already saved in all cases
                                parentForm.navigationForwardStack.Clear();

                                parentForm.createControl.populateEditAuthorPanel(new Author(), CallFrom.None, true); //refresh
                                break;

                            case DbTable.Genre:

                                id = await PostRequests.CreateEntity<Genre>(tempGenre);
                                if (genreStack.Count != 0)
                                    tempGenre = genreStack.Peek().genre;

                                parentForm.homeControl.genreTreeViewPopulate(); //refresh

                                switch (calledFrom) 
                                {
                                    case CallFrom.None:

                                        parentForm.createControl.populateEditBookPanel(new Book(), true);
                                        parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditGenre) { referencedId = id });
                                        parentForm.navigationForwardStack.Clear();
                                        await parentForm.genreControl.openGenrePanel(id);
                                        break;

                                    case CallFrom.CreateBook:

                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.createControl.tempBook.genres.Add(Int32.Parse(id));
                                        parentForm.createControl.populateEditBookPanel(new Book(parentForm.createControl.tempBook), false);
                                        calledFrom = CallFrom.None;
                                        parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditGenre) { referencedId = id });
                                        parentForm.navigationForwardStack.Clear();
                                        break;

                                    case CallFrom.EditBook:
                                
                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.editControl.tempBook.genres.Add(Int32.Parse(id));
                                        parentForm.editControl.populateEditBookPanel(new Book(parentForm.editControl.tempBook), false);
                                        calledFrom = CallFrom.None;
                                        parentForm.editControl.BringToFront();
                                        parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditGenre) { referencedId = id });
                                        parentForm.navigationForwardStack.Clear();
                                        break;

                                        
                                    case CallFrom.CreateGenreSub:
                                
                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.createControl.tempGenre.subGenres.Add(Int32.Parse(id));
                                        parentForm.createControl.populateEditGenrePanel(parentForm.createControl.tempGenre, calledFrom, false);
                                        break;
                                
                                    case CallFrom.EditGenreSub:
                                
                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.editControl.tempGenre.subGenres.Add(Int32.Parse(id));
                                        parentForm.editControl.populateEditGenrePanel(parentForm.editControl.tempGenre, CallFrom.None, false);
                                        calledFrom = CallFrom.None;
                                        parentForm.editControl.BringToFront();
                                        break;
                                
                                    case CallFrom.CreateGenreParent:
                                
                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.createControl.tempGenre.parentGenre = Int32.Parse(id);
                                        parentForm.createControl.populateEditGenrePanel(parentForm.createControl.tempGenre, calledFrom, false);
                                        break;
                                
                                    case CallFrom.EditGenreParent:
                                
                                        if (!string.IsNullOrEmpty(id))
                                            parentForm.editControl.tempGenre.parentGenre = Int32.Parse(id);
                                        parentForm.editControl.populateEditGenrePanel(parentForm.editControl.tempGenre, CallFrom.None, false);
                                        calledFrom = CallFrom.None;
                                        parentForm.editControl.BringToFront();
                                        break;
                                } 

                                if (genreStack.Count != 0)
                                {
                                    calledFrom = genreStack.Peek().source;
                                    genreStack.Pop();
                                }

                                //parentForm.createControl.populateEditGenrePanel(new Genre(), CallFrom.None, true); //refresh

                                break;


                            case DbTable.Publisher:
                                id = await PostRequests.CreateEntity<Publisher>(tempPublisher);

                                if (calledFrom == CallFrom.None)
                                {
                                    parentForm.createControl.populateEditBookPanel(new Book(), true);
                                    parentForm.navigationBackStack.Push(new NavigationItem(PanelState.CreatePublisher) { publisher = new Publisher() });
                                    parentForm.navigationForwardStack.Clear();
                                    await parentForm.publisherControl.openPublisherPanel(id);
                                }

                                else if (calledFrom == CallFrom.CreateBook)
                                {
                                    if (!string.IsNullOrEmpty(id))
                                        parentForm.createControl.tempBook.publisher = Int32.Parse(id);
                                    parentForm.createControl.populateEditBookPanel(parentForm.createControl.tempBook, false);
                                    calledFrom = CallFrom.None;
                                }
                                else if (calledFrom == CallFrom.EditBook)
                                {
                                    if (!string.IsNullOrEmpty(id))
                                        parentForm.editControl.tempBook.publisher = Int32.Parse(id);
                                    parentForm.editControl.populateEditBookPanel(parentForm.editControl.tempBook, false);
                                    calledFrom = CallFrom.None;
                                    parentForm.editControl.BringToFront();
                                }

                                parentForm.navigationBackStack.Push(new NavigationItem(PanelState.EditPublisher) { referencedId = id }); //because its already saved in all cases
                                parentForm.navigationForwardStack.Clear();

                                parentForm.createControl.populateEditPublisherPanel(new Publisher(), CallFrom.None, true); //refresh

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
