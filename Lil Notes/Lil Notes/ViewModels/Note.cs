using System;
using System.ComponentModel;
using Xamarin.Forms;
using Lil_Notes.CustomViews;

namespace Lil_Notes
{
	/// <summary>
	///		Represents a note a user can create.
	/// </summary>
    public class Note : INotifyPropertyChanged
    {
		#region Fields & Properties 

		private readonly string[] Icons = new string[] { "blue", "green", "yellow", "red", "purple" };
		private const string NOTE_FILE_EXTENSION = "_note_icon";

        private string name;
		private string iconPath;
		public string Content { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime LastModifiedDate { get; set; }
	

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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NoteCell.BIND_NOTE_NAME));
			}
		}
		
		/// <summary>
		///		Property for setting the background which invokes PropertyChanged event for the binding engine.
		/// </summary>
		public Color BackgroundColor
		{
			get => backgroundColor;
			set
			{
				// Assign value
				backgroundColor = value;
				// Invoke the propertychanged event so the binding engine can make the appropriate changes to the pasted property
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NoteCell.BIND_BACKGROUND_COLOR));
			}
		}

		public string IconPath
		{
			get => iconPath;
			set
			{
				iconPath = value;				
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NoteCell.BIND_ICON_PATH));
			}
		}

		/// <summary>
		///		Readonly property for getting the note icon's filename.
		/// </summary>
		// public string ICON { get => "note_icon.png"; }

		#endregion

		/// <summary>
		///		Constructor which takes the note's name and its contents (text).
		/// </summary>
		public Note(string _name, string _content)
		{
			Name = _name;
			Content = _content;
			CreationDate = DateTime.Now;

			// Choosing random icon
			var rnd = new Random();
			IconPath = Icons[rnd.Next(0, Icons.Length)] + NOTE_FILE_EXTENSION;
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