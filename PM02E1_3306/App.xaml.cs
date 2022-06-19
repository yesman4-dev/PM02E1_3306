using System;
using Xamarin.Forms;
using PM02E1_3306.Views;
using Xamarin.Forms.Xaml;

namespace PM02E1_3306
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
