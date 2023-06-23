using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiselectListViewXF
{
    public partial class App : Application
    {

        public static NavigationPage NavPage = new NavigationPage(new MainPage());

        public App()
        {
            InitializeComponent();

            MainPage = NavPage;
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
