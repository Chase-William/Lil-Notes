using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lil_Notes
{
    /// <summary>
    ///     This page is used to edit already created notes.
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditNotePage : ContentPage
    {
        public EditNotePage()
        {
            InitializeComponent();
        }
    }
}