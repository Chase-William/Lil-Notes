using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lil_Notes
{
    /// <summary>
    ///     Determines how pages will be displayed.
    /// </summary>
    public enum DisplayTheme { Light, Dark }

    /// <summary>
    ///     Contains all generic functionalities for settings.
    /// </summary>
    public static class Settings
    {
        private static DisplayTheme theme;

        /// <summary>
        ///     Will call the UpdateDisplayToTheme method within the caller which is REQUIRED to implement the IDynamicDisplayMode interface.
        ///     Reference : C# In Depth Fourth Edition by Jon Skeet, page number 33
        /// </summary>
        public static void SetDisplayTheme<T>(T _page, DisplayTheme _theme) where T : ContentPage, IThemeableDisplay
        {
            theme = _theme;
            if (theme == DisplayTheme.Dark)
            {
                _page.SetRenderDarkTheme();
            }
            else
            {
                _page.SetRenderLightTheme();
            }
        }

        /// <summary>
        ///     Prompts the user to choose a display theme. Method is under several constraints to ensure proper use.
        /// </summary>
        public async static void ShowDisplaySettings<T>(T _contentPage) where T : ContentPage, IThemeableDisplay
        {
            switch (await _contentPage.DisplayActionSheet("Set your app's theme.", "Cancel", null, "Light Mode", "Dark Mode"))
            {
                case "Light Mode":
                    SetDisplayTheme(_contentPage, DisplayTheme.Light);                    
                    break;
                case "Dark Mode":
                    SetDisplayTheme(_contentPage, DisplayTheme.Dark);
                    break;
                default:
                    // Cancel was clicked
                    break;
            }
        }
    }
}
