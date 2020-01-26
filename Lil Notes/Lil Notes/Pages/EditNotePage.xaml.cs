using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lil_Notes
{
    /// <summary>
    ///     This page is used to edit already created notes.
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditNotePage : ContentPage, IThemeableDisplay
    {
        // reference to selected note
        private Note selectedNote;
        
        public EditNotePage(Note _selectedNote)
        {
            selectedNote = _selectedNote;
            InitializeComponent();
            Settings.CheckForThemeUpdates(this);
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            selectedNote.IsBindingContextOccuring = true;
        }

        /// <summary>
        ///     Handles check mark for finishing and saving edits being clicked.
        /// </summary>
        public async void OnFinishedBtnClicked(object sender, EventArgs e)
        {
            // The name was changed and is valid.
            if (!string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                // Don't save changes if none were made.
                if (selectedNote.Name != NameEntry.Text || selectedNote.Content != ContentEntry.Text)
                {
                    // Saving possible changes                
                    selectedNote.Name = NameEntry.Text;
                    selectedNote.Content = ContentEntry.Text;
                }

                // pop page off nav stack
                await Navigation.PopAsync();
            }
            else
            {
                // Inform user of error
                await DisplayAlert(NameErrorAlert.TITLE, NameErrorAlert.MSG, NameErrorAlert.CANCEL);
            }
        }

        public void SetRenderDarkTheme()
        {
            Resources["StackLayoutStyle"] = Resources["DarkStackLayoutStyle"];
            Resources["LabelStyle"] = Resources["DarkLabelStyle"];
            //Resources["EntryStyle"] = Resources["DarkEntryStyle"];
            
        }

        public void SetRenderLightTheme()
        {
            Resources["StackLayoutStyle"] = Resources["LightStackLayoutStyle"];
            Resources["LabelStyle"] = Resources["LightLabelStyle"];
            //Resources["EntryStyle"] = Resources["LightEntryStyle"];
        }
    }
}