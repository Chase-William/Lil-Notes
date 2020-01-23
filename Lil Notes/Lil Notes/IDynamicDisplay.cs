using System;
using System.Collections.Generic;
using System.Text;

namespace Lil_Notes
{
    /// <summary>
    ///     Interface that is used when updating displays based off the display mode.
    /// </summary>
    public interface IDynamicDisplay
    {
        /// <summary>
        ///     Will update the UI to dark mode based off provided implementation
        /// </summary>
        void RenderDarkMode();
        /// <summary>
        ///     Will update the UI to light mode based off provided implementation
        /// </summary>
        void RenderLightMode();
    }
}
