using Xamarin.Forms;

namespace Lil_Notes.Cells
{
	/// <summary>
	///		Custom cell implementation for Notes.
	/// </summary>
	public class NoteCell : ViewCell
	{
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
			nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
			creationDateLabel.SetBinding(Label.TextProperty, new Binding("CreationDate"));
			lastModifiedLabel.SetBinding(Label.TextProperty, new Binding("LastModifiedDate"));
			icon.SetBinding(Image.SourceProperty, new Binding("ICON"));

			horizontalLayout.Children.Add(icon);
			horizontalLayout.Children.Add(nameLabel);
			verticaLayout.Children.Add(creationDateLabel);
			verticaLayout.Children.Add(lastModifiedLabel);
			horizontalLayout.Children.Add(verticaLayout);

			// Creating a binding for the cell.
			// The property we will be targeting is the BackgroundColor
			// The instance of the binding is called BackgroundColor, this will be used by the binding engine
			horizontalLayout.SetBinding(VisualElement.BackgroundColorProperty, new Binding("BackgroundColor"));

			// Adding the super layout to the parent view.
			// This will display this entire view structure as a single view
			View = horizontalLayout;
		}
	}
}
