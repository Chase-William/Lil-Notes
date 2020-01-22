using Xamarin.Forms;

namespace Lil_Notes.Cells
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
        public const string BACKGROUND_COLOR_BINDING_ID = "BackgroundColor";
		/// <summary>
		///		The binding identifier to update the name label's text property.
		/// </summary>
		public const string NAME_TEXT_BINDING_ID = "Name";
		/// <summary>
		///		The binding identifier for creation date.
		/// </summary>
		private const string CREATION_DATE_TEXT_BINDING_ID = "CreationDate";
		/// <summary>
		///		The binding identifier for the last modified text field.
		/// </summary>
		public const string LAST_MODIFIED_TEXT_BINDING_ID = "LastModifiedDate";
		/// <summary>
		///		The binding identifier for the icon.
		/// </summary>
		private const string ICON_BINDING_ID = "ICON";

        #endregion

        public NoteCell()
		{
			// Creating our views and layouts.
			var icon = new Image() { Margin = 2 };
			var nameLabel = new Label() { FontSize = 20 };
			var creationDateLabel = new Label();
			var lastModifiedLabel = new Label();
			var verticaLayout = new StackLayout() { HorizontalOptions = LayoutOptions.EndAndExpand };
			var horizontalLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };

			// Setting bindings for listview.
			nameLabel.SetBinding		(Label.TextProperty,   new Binding(NAME_TEXT_BINDING_ID));
			creationDateLabel.SetBinding(Label.TextProperty,   new Binding(CREATION_DATE_TEXT_BINDING_ID));
			lastModifiedLabel.SetBinding(Label.TextProperty,   new Binding(LAST_MODIFIED_TEXT_BINDING_ID));
			icon.SetBinding				(Image.SourceProperty, new Binding(ICON_BINDING_ID));

			horizontalLayout.Children.Add(icon);
			horizontalLayout.Children.Add(nameLabel);
			verticaLayout.Children.Add(creationDateLabel);
			verticaLayout.Children.Add(lastModifiedLabel);
			horizontalLayout.Children.Add(verticaLayout);

			// Creating a binding for the cell.
			// The property we will be targeting is the BackgroundColor
			// The instance of the binding is called BackgroundColor, this will be used by the binding engine
			horizontalLayout.SetBinding(VisualElement.BackgroundColorProperty, new Binding(BACKGROUND_COLOR_BINDING_ID));

			// Adding the super layout to the parent view.
			// This will display this entire view structure as a single view
			View = horizontalLayout;
		}		
	}
}
