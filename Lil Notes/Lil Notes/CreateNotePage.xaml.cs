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
    ///     This page is used to create notes.
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateNotePage : ContentPage
    {
        public CreateNotePage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handler for the finished btn in toolbar being clicked.
        ///     Saves changes.
        /// </summary>
        private async void OnFinishedBtnClicked(object sender, EventArgs e)
        {
            // If the name entry isn't null or just spaces:
            if (!string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                // Creating the new note instance and adding it to our list of notes
                DataNotes.Notes.Add(new Note(NameEntry.Text, ContentEntry.Text));

                // Removing this page from the stack navigation
                await Navigation.PopModalAsync();
            }
            // Informs user that they done goofed:
            else
            {
                // https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/pop-ups
                await DisplayAlert("Error", "The note's name cannot be empty or just spaces.", "OK");
            }
        }
    }
}