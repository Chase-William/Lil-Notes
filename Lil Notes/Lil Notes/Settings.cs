using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lil_Notes
{
    /// <summary>
    ///     Determines how pages will be displayed.
    /// </summary>
    public enum DisplayMode { Light, Dark }

    /// <summary>
    ///     Contains all generic functionalities for settings.
    /// </summary>
    public static class Settings
    {
        private static DisplayMode mode;

        /// <summary>
        ///     Will call the UpdateDisplayToMode method within the caller which is REQUIRED to implement the IDynamicDisplayMode interface.
        ///     Reference : C# In Depth Fourth Edition by Jon Skeet, page number 33
        /// </summary>
        public static void SetDisplayMode<T>(T _page, DisplayMode _mode) where T : IDynamicDisplay
        {
            mode = _mode;
            _page.RenderDarkMode();
        }

        /// <summary>
        ///     Prompts the user to choose a display type. Method is under several constraints to ensure proper use.
        /// </summary>
        public async static void ShowDisplaySettings<T>(T _contentPage) where T : ContentPage, IDynamicDisplay
        {
            switch (await _contentPage.DisplayActionSheet("Set your app's mode.", "Cancel", null, "Light Mode", "Dark Mode"))
            {
                case "Light Mode":
                    SetDisplayMode(_contentPage, DisplayMode.Light);                    
                    break;
                case "Dark Mode":
                    SetDisplayMode(_contentPage, DisplayMode.Dark);
                    break;
                default:
                    // Cancel was clicked
                    break;
            }
        }
    }
}
