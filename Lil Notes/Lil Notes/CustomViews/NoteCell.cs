using Xamarin.Forms;

namespace Lil_Notes.CustomViews
{
	/// <summary>
	///		Custom cell implementation for Notes.
	/// </summary>
	public class NoteCell : ViewCell
	{
        #region Binding Identifiers

        /// <summary>
        ///		The binding identifier to update the background color of the cell.
        /// </summary>
        public const string BIND_BACKGROUND_COLOR = "BackgroundColor";
		/// <summary>
		///		The binding to update the border color of the main frame.
		/// </summary>
		public const string BIND_BORDER_COLOR = "BorderColor";
		/// <summary>
		///		The binding identifier to update the name label's text property.
		/// </summary>
		public const string BIND_NOTE_NAME = "Name";
		/// <summary>
		///		The binding identifier for creation date.
		/// </summary>
		private const string BIND_CREATION_DATE = "CreationDate";
		/// <summary>
		///		The binding identifier for the last modified text field.
		/// </summary>
		public const string BIND_LAST_MODIFIED = "LastModifiedDate";
		/// <summary>
		///		The binding identifier for the icon.
		/// </summary>
		public const string BIND_ICON_PATH = "IconPath";

        #endregion
		
        public NoteCell()
		{
			// Creating our views and layouts.
			//var icon			  = new Image() { Margin = 2 };
			//var nameLabel		  = new Label() { FontSize = 20 };
			//var creationDateLabel = new Label();
			//var lastModifiedLabel = new Label();
			//var verticaLayout     = new StackLayout() { HorizontalOptions = LayoutOptions.EndAndExpand };
			//var horizontalLayout  = new StackLayout() { Orientation = StackOrientation.Horizontal };					
			
			//horizontalLayout.Children.Add(icon);
			//horizontalLayout.Children.Add(nameLabel);
			//verticaLayout   .Children.Add(creationDateLabel);
			//verticaLayout   .Children.Add(lastModifiedLabel);
			//horizontalLayout.Children.Add(verticaLayout);		

			//// Frame allows us to have a border
			//var internalFrame = new Frame()
			//{
			//	Content = horizontalLayout,
			//	BorderColor = Color.FromHex("1E90EE"),
			//	HasShadow = true,
			//	HeightRequest = 70,
			//	Padding = 5
			//};

			//var mainFrame = new Frame()
			//{
			//	Content = internalFrame,
			//	Padding = 5,
			//	BorderColor = Color.White,
			//	CornerRadius = 0
			//};

			//// Creating a binding for the cell.
			//// The property we will be targeting is the BackgroundColor
			//// The instance of the binding is called BackgroundColor, this will be used by the binding engine
			//mainFrame		 .SetBinding(VisualElement.BackgroundColorProperty, new Binding(BIND_BACKGROUND_COLOR));
			//mainFrame		 .SetBinding(Frame.BorderColorProperty, new Binding(BIND_BORDER_COLOR));
			//nameLabel		 .SetBinding(Label.TextProperty, new Binding(BIND_NOTE_NAME));
			//creationDateLabel.SetBinding(Label.TextProperty, new Binding(BIND_CREATION_DATE, BindingMode.Default, new CreationDateConverter()));
			//lastModifiedLabel.SetBinding(Label.TextProperty, new Binding(BIND_LAST_MODIFIED, BindingMode.Default, new LastModifiedConverter()));
			//icon			 .SetBinding(Image.SourceProperty, new Binding(BIND_ICON_PATH));			

			//// Adding the frame to the parent view.
			//// This will display this entire view structure as a single view
			//View = mainFrame;			
		}		
	}
}
