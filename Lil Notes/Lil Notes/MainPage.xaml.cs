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
        private Note selected;

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
            Navigation.PushModalAsync(new NavigationPage(new CreateNotePage
            {
                BindingContext = new Note("Note1", "")
            }));
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
            selected = (Note)NotesListView.SelectedItem;
            selected.SetColors(true);


            // Creating the next page and passing in the data.
            Navigation.PushModalAsync(new NavigationPage(new EditNotePage
            {
                BindingContext = selected
            }));
        }

        /// <summary>
        ///     Overriding to provide custom implementation to set cell colors and re-enable listview when returning from a different page.
        /// </summary>
        protected override void OnAppearing()
        {            
            if (selected != null)
            {
                selected.SetColors(false);
                NotesListView.IsEnabled = !NotesListView.IsEnabled;               
            }

            base.OnAppearing();
        }
    }
}
