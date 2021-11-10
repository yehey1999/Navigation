using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class EducationBackgroundViewModel
    {
        public Command OnNextCommand { get; private set; }
        public Command OnBackCommand { get; private set; }

        public EducationBackgroundViewModel()
        {
            OnNextCommand = new Command(GoToNextPage);
            OnBackCommand = new Command(GoToBackPage);
        }

        private async void GoToNextPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SkillsView());
        }

        private async void GoToBackPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
