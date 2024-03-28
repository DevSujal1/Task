using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flipkart_page
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Flipkart_homepage();
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
