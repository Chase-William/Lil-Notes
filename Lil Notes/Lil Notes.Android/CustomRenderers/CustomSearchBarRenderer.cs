using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Lil_Notes.CustomViews;
using Color = Android.Graphics.Color;
using Android.Content;
using Android.Widget;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms.Xaml;
using System;

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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context _context) : base(_context) { }

        MainPage MainPage => MainPage.Mainpage;

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
                this.SetBackgroundColor(Color.Transparent);

                // The ridiculous way to remove the layout responceable for the underline when searching
                var linearLayout = (LinearLayout)Control.GetChildAt(0);
                linearLayout = (LinearLayout)linearLayout.GetChildAt(2);
                linearLayout = (LinearLayout)linearLayout.GetChildAt(1);
                linearLayout.Background = null;

                // Getting a reference to the clear button inside the searchview
                int searchCloseButtonId = this.Context.Resources.GetIdentifier("android:id/search_close_btn", null, null);
                var clearBtn = FindViewById<ImageView>(searchCloseButtonId);

                clearBtn.Click += delegate
                {
                    MainPage.MainSearchBar.Text = "";
                    MainPage.InvalidateList();
                };
            }                        
           
            base.OnElementChanged(e);
        }        
    }
}