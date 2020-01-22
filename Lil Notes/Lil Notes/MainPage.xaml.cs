using System;
using System.ComponentModel;
using Xamarin.Forms;
using Lil_Notes.Cells;
using System.Collections.ObjectModel;

/*
 *  This was where you got the idea for the assignment no? https://docs.microsoft.com/en-us/xamarin/get-started/quickstarts/multi-page?pivots=windows
 * 
 * 
 * 
 * 
 * 
 * 
*/
namespace Lil_Notes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        // Property is for getting information about Notes list
        public ObservableCollection<Note> Notes
        {
            get { return DataNotes.Notes; }
            set { DataNotes.Notes = value; }
        }

        // Tracks note selected
        private Note selectedNote;

        /// <summary>
        ///     Constructor for the main page.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            // Expressing to the ListView on what kind of cell type it will be using
            NotesListView.ItemTemplate = new DataTemplate(typeof(NoteCell));
            // Setting the background property to white
            NotesListView.BackgroundColor = Color.White;
            // Attaching the source
            NotesListView.ItemsSource = Notes;
        }

        /// <summary>
        ///     Handler for the create new note button when clicked.
        ///     Launches a new page setup for note creation.
        /// </summary>
        private void OnCreateNoteClicked(object sender, EventArgs e)
        {
            // Disables the user from clicking several cells before the new page covers it the listview
            NotesListView.IsEnabled = false;

            // Must wrap CreateNotePage in NavigationPage so our toolbar will be visible
            Navigation.PushModalAsync(new NavigationPage(new CreateNotePage()));
        }
        
        /// <summary>
        ///     Handler for the Listview items when selected.
        ///     Launches the edit note page.
        /// </summary>
        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Disables the user from clicking several cells before the new page covers it the listview
            NotesListView.IsEnabled = false;

            // Select new
            selectedNote = (Note)NotesListView.SelectedItem;
            selectedNote.SetColors(true);


            // Creating the next page and passing in the data.
            Navigation.PushModalAsync(new NavigationPage(new EditNotePage(selectedNote)
            {
                BindingContext = selectedNote
            }));
        }

        /// <summary>
        ///     Overriding to provide custom implementation to set cell colors and re-enable listview when returning from a different page.
        /// </summary>
        protected override void OnAppearing()
        {            
            // If a note was selected before leaving this page; make sure to set its color back
            // Furthermore reset the note variable to null so if we leave the page without selecting a note it wont reset it to a color it already is.
            if (selectedNote != null)
            {
                selectedNote.SetColors(false);
                selectedNote = null;
            }

            // Whenever we return the list should be active
            // This runs 1 time on launch when it's already true but not a huge deal
            NotesListView.IsEnabled = true;

            base.OnAppearing();
        }

    }
}
