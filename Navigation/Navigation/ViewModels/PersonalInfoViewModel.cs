using Navigation.Models;
using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class PersonalInfoViewModel : BaseViewModel
    {

        private string firstName = "";
        private string lastName = "";
        private string middleName = "";
        private string gender = "";
        private string birthday = "";

        public Command OnNextCommand { get; private set; }

        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public string MiddleName
        {
            get => middleName;
            set => SetProperty(ref middleName, value);
        }

        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }

        public string Birthday
        {
            get => birthday;
            set => SetProperty(ref birthday, value);
        }

        public PersonalInfoViewModel()
        {
            OnNextCommand = new Command(GoToNextPage); 
        }

        private async void GoToNextPage()
        {
            DataStore.UpdatePersonInfo(FirstName, LastName, MiddleName, Gender, Birthday);
            await Application.Current.MainPage.Navigation.PushAsync(new EducationBackgroundView());
        }
    }
}
