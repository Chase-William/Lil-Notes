using System;
using Xamarin.Forms;

namespace Lil_Notes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Initializing example data
            DataNotes.InitializeExampleNotesData();

            // MainPage has to be wrapped in a navigationPage for the toolbar to show up.
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
