using Android.Content;
using Lil_Notes.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// Marking this render to be exported
[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(Lil_Notes.Droid.CustomRenderers.CustomSearchBar))]

namespace Lil_Notes.Droid.CustomRenderers
{    
    /// <summary>
    ///     Customer render for Searchbars. 
    ///         Objectives:
    ///             - Change color of underline on searchbar 
    ///             - Change color of searchbar search icon
    /// </summary>
    public class CustomSearchBar : SearchBarRenderer
    {
        public CustomSearchBar(Context _context) : base(_context) { }

        /// <summary>
        ///     Sets UI properties to render in a dark theme manner provided by the implementation.
        /// </summary>
        public void SetRenderDarkTheme()
        {

        }

        /// <summary>
        ///     Sets UI properties to render in a light theme manner provided by the implementation.
        /// </summary>
        public void SetRenderLightTheme()
        {

        }
    }
}