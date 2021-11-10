using Navigation.Models;
using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class EducationBackgroundViewModel : BaseViewModel
    {
        private string elementary = "";
        private string yearElementary = "";
        private string highSchool = "";
        private string yearHighSchool = "";
        private string college = "";

        public Command OnNextCommand { get; private set; }

        public Command OnBackCommand { get; private set; }

        public string Elementary
        {
            get => elementary;
            set => SetProperty(ref elementary, value);
        }

        public string YearElementary
        {
            get => yearElementary;
            set => SetProperty(ref yearElementary, value);
        }

        public string HighSchool
        {
            get => highSchool;
            set => SetProperty(ref highSchool, value);
        }

        public string YearHighSchool
        {
            get => yearHighSchool;
            set => SetProperty(ref yearHighSchool, value);
        }

        public string College
        {
            get => college;
            set => SetProperty(ref college, value);
        }

        public EducationBackgroundViewModel()
        {
            OnNextCommand = new Command(GoToNextPage);
            OnBackCommand = new Command(GoToBackPage);
        }

        private async void GoToNextPage()
        {
            DataStore.UpdateEducationBackground(Elementary, YearElementary, HighSchool, YearHighSchool, College);
            await Application.Current.MainPage.Navigation.PushAsync(new SkillsView());
        }

        private async void GoToBackPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
