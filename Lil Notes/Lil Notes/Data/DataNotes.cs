using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lil_Notes
{
    /// <summary>
    ///     Holds the data for our program to use
    /// </summary>
    public static class DataNotes
    {
        // ObservableCollection because when we start dynamically adding notes this will automatically handle updating the listview for us
        public static ObservableCollection<Note> Notes = new ObservableCollection<Note>();       

        /// <summary>
        ///     Initializes example data for testing purposes
        /// </summary>
        public static void InitializeExampleNotesData()
        {
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
            Notes.Add(new Note("Note One", "Some Content"));
            Notes.Add(new Note("Note Two", "Some Content"));
            Notes.Add(new Note("Note Three", "Some Content"));
            Notes.Add(new Note("Note Four", "Some Content"));
            Notes.Add(new Note("Note Five", "Some Content"));
            Notes.Add(new Note("Note Six", "Some Content"));
        }
    }
}
