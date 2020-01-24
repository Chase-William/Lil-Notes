using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Lil_Notes.CustomViews;
using Color = Android.Graphics.Color;
using Android.Content;
using Android.Widget;

// Marking this render to be exported
[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(Lil_Notes.Droid.CustomRenderers.CustomSearchBarRenderer))]

namespace Lil_Notes.Droid.CustomRenderers
{    
    /// <summary>
    ///     Customer render for Searchbars. 
    ///         Objectives:
    ///             - Change color of underline on searchbar 
    ///             - Change color of searchbar search icon
    /// </summary>
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context _context) : base(_context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            if (Control == null)
            {
                SetNativeControl(new SearchView(Context));
                // Create the native control and use SetNativeControl
                // Do not assign directly to the Control property unless you know what you are doing
            }

            if (e.OldElement != null)
            {
                // Cleanup resources and remove event handlers for this element.
            }

            if (e.NewElement != null)
            {
                //this.SetBackgroundColor(Color.Transparent);

                //LinearLayout linearLayout = this.Control.GetChildAt(0) as LinearLayout;
                //linearLayout = linearLayout.GetChildAt(2) as LinearLayout;
                //linearLayout = linearLayout.GetChildAt(1) as LinearLayout;

                // Changes the background layout that is responceable for the underline
                //linearLayout.SetBackgroundColor(Color.Violet);
            }          
            
            base.OnElementChanged(e);
        }


        /// <summary>
        ///     Sets UI properties to render in a dark theme manner provided by the implementation.
        /// </summary>
        public void SetRenderDarkTheme()
        {
            this.SetBackgroundColor(Color.White);
        }

        /// <summary>
        ///     Sets UI properties to render in a light theme manner provided by the implementation.
        /// </summary>
        public void SetRenderLightTheme()
        {
            
        }
    }
}