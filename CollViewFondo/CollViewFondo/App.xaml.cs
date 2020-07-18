using CollViewFondo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollViewFondo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SquaresPage();
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
