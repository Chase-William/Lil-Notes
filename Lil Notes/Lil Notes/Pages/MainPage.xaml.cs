using System;
using System.ComponentModel;
using Xamarin.Forms;
using Lil_Notes.CustomViews;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;

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
    public partial class MainPage : ContentPage, IThemeableDisplay
    {
        // Property is for getting information about Notes list
        public ObservableCollection<Note> Notes
        {
            get { return DataNotes.Notes; }
            set { DataNotes.Notes = value; }
        }

        public static MainPage Mainpage { get; private set; }
        public CustomSearchBar MainSearchBar { get; set; }

        private string queryString;

        // Tracks note selected
        private Note selectedNote;

        /// <summary>
        ///     Constructor for the main page.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            // Expressing to the ListView on what kind of cell type it will be using
            // NotesListView.ItemTemplate = new DataTemplate(typeof(NoteCell));
            // Attaching the source
            Mainpage = this;
            MainSearchBar = CustomSearchBar;                
        }



        /// <summary>
        ///     Handler for the create new note button when clicked.
        ///     Launches a new page setup for note creation.
        /// </summary>
        private async void OnCreateNoteClicked(object sender, EventArgs e)
        {
            // Disables the user from clicking several cells before the new page covers it the listview
            NotesListView.IsEnabled = false;

            var blankNote = new Note("", "");

            // Must wrap CreateNotePage in NavigationPage so our toolbar will be visible
            await Navigation.PushAsync(new CreateNotePage(blankNote)
            {
                BindingContext = blankNote
            });
        }

        private async void NotesItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            // Disables the user from clicking several cells before the new page covers it the listview
            NotesListView.IsEnabled = false;

            // Select new
            selectedNote = (Note)e.Item;
            selectedNote.SetColors(true);

            // Creating the next page and passing in the data.
            await Navigation.PushAsync(new EditNotePage(selectedNote)
            {
                // So for some reason this uses the properties setters... -----------------------------------------------------------------------------------
                BindingContext = selectedNote
            });
        }

        /// <summary>
        ///     Handles the setting btn being clicked.
        /// </summary>
        public void OnSettingsBtnClicked(object sender, EventArgs e)
        {
            // Will display the display setting options.
            Settings.ShowDisplaySettings(this);                             
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
                selectedNote.IsBindingContextOccuring = false;
                selectedNote = null;
            }

            InvalidateList();
            if (!string.IsNullOrWhiteSpace(MainSearchBar.Text))
            {
                CustomSearchBarTextChanged(null, new TextChangedEventArgs(null, queryString));
            }

            // Whenever we return the list should be active
            // This runs 1 time on launch when it's already true but not a huge deal
            NotesListView.IsEnabled = true;

            base.OnAppearing();            
        }

        /// <summary>
        ///     Sets the rendering properties of the various components of the page to render dark mode styles.
        /// </summary>
        public void SetRenderDarkTheme()
        {
            Resources["NotesListViewStyle"] = Resources["DarkNotesListViewStyle"];
            Resources["MainFrameStyle"] = Resources["DarkMainFrameStyle"];
            Resources["InternalFrameStyle"] = Resources["DarkInternalFrameStyle"];
            Resources["StackLayoutStyle"] = Resources["DarkStackLayoutStyle"];
            Resources["LabelStyle"] = Resources["DarkLabelStyle"];
            //Resources["CustomSearchBarStyle"] = Resources["DarkCustomSearchBarStyle"];
        }

        /// <summary>
        ///     Sets the rendering properties of the various components of the page to render light mode styles.
        /// </summary>
        public void SetRenderLightTheme()
        {
            Resources["NotesListViewStyle"] = Resources["LightNotesListViewStyle"];
            Resources["MainFrameStyle"] = Resources["LightMainFrameStyle"];
            Resources["InternalFrameStyle"] = Resources["LightInternalFrameStyle"];
            Resources["StackLayoutStyle"] = Resources["LightStackLayoutStyle"];
            Resources["LabelStyle"] = Resources["LightLabelStyle"];
            //Resources["CustomSearchBarStyle"] = Resources["LightCustomSearchBarStyle"];
        }

        /// <summary>
        ///     Handles the text being changed within our custom search bar AND initiates querying.
        /// </summary>
        private void CustomSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != null && !e.NewTextValue.All(x => x == ' '))
            {
                queryString = e.NewTextValue;
                NotesListView.ItemsSource = Data.DataProvider.QueryNotesByString(queryString);
            }
            if (e.NewTextValue == "")
            {
                InvalidateList();
            }            
        }

        /// <summary>
        ///     Invalidates the list so an update is forced.
        /// </summary>
        public void InvalidateList()
        {
            NotesListView.ItemsSource = Notes;
        }
    }
}
