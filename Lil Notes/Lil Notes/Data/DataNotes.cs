using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lil_Notes
{
    /// <summary>
    ///     Holds the data for our program to use
    /// </summary>
    public static class DataNotes
    {
        // List of notes, was obserable collection but wasn't getting the functionality desired
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

    /// <summary>
    ///     Class only ment to maniplute Note list currently.
    /// </summary>
    //public class NoteObservableCollection : ObservableCollection<Note>
    //{        
    //    public NoteObservableCollection()
    //    {
    //        CollectionChanged += NoteObservableCollectionCollectionChanged;
    //    }

    //    /// <summary>
    //    ///     Handles NoteObservableCollection changes.
    //    /// </summary>
    //    private void NoteObservableCollectionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    //    {
    //        // If items were added, we need to update
    //        var test = e.Action;
    //        var test2 = sender;
    //        if ((int)e.Action > 36)
    //        {
    //            var newI = e.NewStartingIndex;
    //            var oldI = e.OldStartingIndex;
    //            this.InsertItem(2, (Note)e.NewItems[0]);
    //        }
    //    }

    //    protected override void InsertItem(int index, Note item)
    //    {
    //        base.InsertItem(index, item);
    //    }
    //}
}
