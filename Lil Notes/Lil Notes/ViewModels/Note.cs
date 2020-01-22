using System;
using System.ComponentModel;
using Xamarin.Forms;
using Lil_Notes.Cells;

namespace Lil_Notes
{
	/// <summary>
	///		Represents a note a user can create.
	/// </summary>
    public class Note : INotifyPropertyChanged
    {
        #region Fields & Properties 

        private string name;
		private string content;
		private DateTime creationDate;
		private DateTime lastModifiedDate;

		// Event for binding engine updates
		public event PropertyChangedEventHandler PropertyChanged;
		// Stores background color states of notes
		private Color backgroundColor;

		/// <summary>
		///		Property for note name that has support for updating NoteCells name when changed.
		/// </summary>
		public string Name { get => name;
			set 
			{				
				name = value;
				// Will trigger binding engine with this event
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NoteCell.NAME_TEXT_BINDING_ID));
			}
		}

		public string Content { get => content; set => content = value; }
		public DateTime CreationDate { get => creationDate; set => creationDate = value; }		
		public DateTime LastModifiedDate { get => lastModifiedDate; set => lastModifiedDate = value; }

		/// <summary>
		///		Property for setting the background which invokes PropertyChanged event for the binding engine.
		/// </summary>
		public Color BackgroundColor
		{
			get { return backgroundColor; }
			set
			{
				// Assign value
				backgroundColor = value;
				// Invoke the propertychanged event so the binding engine can make the appropriate changes to the pasted property
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NoteCell.BACKGROUND_COLOR_BINDING_ID));
			}
		}

		/// <summary>
		///		Readonly property for getting the note icon's filename.
		/// </summary>
		public string ICON { get => "note_icon.png"; }

        #endregion

		/// <summary>
		///		Constructor which takes the note's name and its contents (text).
		/// </summary>
        public Note(string _name, string _content)
		{
			Name = _name;
			Content = _content;
			CreationDate = DateTime.Now;
		}		

		/// <summary>
		///		Based on the cells selection state; Its color will be set appropriately.
		/// </summary>
		public void SetColors(bool isSelected)
		{
			// Is selected
			if (isSelected)
			{
				BackgroundColor = Color.LightGray;
			}
			// Unselected
			else
			{
				BackgroundColor = Color.White;
			}
		}
	}
}