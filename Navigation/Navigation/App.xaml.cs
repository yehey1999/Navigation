using Navigation.Services;
using Navigation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<DataStore>();
            MainPage = new NavigationPage(new PersonalInfoView());
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
