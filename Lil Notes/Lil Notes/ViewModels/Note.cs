using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lil_Notes
{
	/// <summary>
	///		Represents a note a user can create.
	/// </summary>
    public class Note : INotifyPropertyChanged
    {		
		private string name;
		private string content;
		private DateTime creationDate;
		private DateTime lastModifiedDate;

		public string Name { get => name; set => name = value; }
		public string Content { get => content; set => content = value; }
		public DateTime CreationDate { get => creationDate; set => creationDate = value; }		
		public DateTime LastModifiedDate { get => lastModifiedDate; set => lastModifiedDate = value; }

		// This can't be const because the image will then no longer appear.
		// If we had different images this would allows us to easily implement that functionality.
		public string ICON { get => "note_icon.png"; }

		public Note(string _name, string _content)
		{
			Name = _name;
			Content = _content;
			CreationDate = DateTime.Now;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private Color backgroundColor;

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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BackgroundColor)));
			}
		}

		/// <summary>
		///		Based on the cells selection state; Its color will be set appropriately.
		/// </summary>
		public void SetColors(bool isSelected)
		{
			// Is selected
			if (isSelected)
			{
				BackgroundColor = Color.Blue;
			}
			// Unselected
			else
			{
				BackgroundColor = Color.White;
			}
		}
	}
}
