using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class PersonalInfoViewModel
    {

        public Command OnNextCommand { get; private set; }

        public PersonalInfoViewModel()
        {
            OnNextCommand = new Command(GoToNextPage);
        }

        private async void GoToNextPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EducationBackgroundView());
        }
    }
}
