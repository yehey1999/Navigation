using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class SummaryViewModel
    {
        public Command OnResetCommand { get; private set; }

        public SummaryViewModel()
        {
            OnResetCommand = new Command(ResetApplication);
        }

        private async void ResetApplication()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PersonalInfoView());
        }
    }
}
