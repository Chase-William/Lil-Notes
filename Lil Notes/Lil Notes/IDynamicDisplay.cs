using System;
using System.Collections.Generic;
using System.Text;

namespace Lil_Notes
{
    /// <summary>
    ///     Interface that is used when updating displays based off the display mode.
    /// </summary>
    public interface IThemeableDisplay
    {
        /// <summary>
        ///     Will update the UI to dark theme based off provided implementation
        /// </summary>
        void SetRenderDarkTheme();
        /// <summary>
        ///     Will update the UI to light theme based off provided implementation
        /// </summary>
        void SetRenderLightTheme();
    }
}
