using Xamarin.Forms;

namespace Lil_Notes.SharedCustomRenderers
{
    /// <summary>
    ///     A very small custom renderer for the Editor class that makes the height responsive to input text line numbers.
    ///     Article: https://xamarinsharp.com/2018/02/24/xamarin-forms-editor-control-how-to-change-the-height-dynamically/
    /// </summary>
    public class CustomEditor : Editor
    {
        public CustomEditor()
        {
            // When the user types text we will check to make sure there is proper line height
            this.TextChanged += delegate
            {
                this.InvalidateMeasure();
            };
        }
    }
}
