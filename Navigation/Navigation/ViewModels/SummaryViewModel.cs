using Navigation.Models;
using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class SummaryViewModel : BaseViewModel
    {
        private string fullName = "";
        private string gender = "";
        private string birthday = "";
        private string elementaryDetails = "";
        private string highSchoolDetails = "";
        private string collegeDetails = "";
        private string skill1 = "";
        private string skill2 = "";
        private string skill3 = "";
        private string skill4 = "";
        private string skill5 = "";

        public Command OnResetCommand { get; private set; }


        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
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

        public string ElementaryDetails
        {
            get => elementaryDetails;
            set => SetProperty(ref elementaryDetails, value);
        }

        public string HighSchoolDetails
        {
            get => highSchoolDetails;
            set => SetProperty(ref highSchoolDetails, value);
        }

        public string CollegeDetails
        {
            get => collegeDetails;
            set => SetProperty(ref collegeDetails, value);
        }

        public string Skill1
        {
            get => skill1;
            set => SetProperty(ref skill1, value);
        }

        public string Skill2
        {
            get => skill2;
            set => SetProperty(ref skill2, value);
        }

        public string Skill3
        {
            get => skill3;
            set => SetProperty(ref skill3, value);
        }

        public string Skill4
        {
            get => skill4;
            set => SetProperty(ref skill4, value);
        }

        public string Skill5
        {
            get => skill5;
            set => SetProperty(ref skill5, value);
        }

        public SummaryViewModel()
        {
            ShowSummary();
            OnResetCommand = new Command(ResetApplication);
        }

        private void ShowSummary()
        {
            Person person = DataStore.GetPerson();
            FullName = person.FirstName + " " + person.MiddleName + " " + person.LastName;
            Birthday = person.Birthday;
            Gender = person.Gender;
            ElementaryDetails = person.Elementary + ", " + person.YearElementary;
            HighSchoolDetails = person.HighSchool + ", " + person.YearHighSchool;
            CollegeDetails = person.College + ", present";
            Skill1 = person.Skills[0];
            Skill2 = person.Skills[1];
            Skill3 = person.Skills[2];
            Skill4 = person.Skills[3];
            Skill5 = person.Skills[4];
        }

        private async void ResetApplication()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PersonalInfoView());
        }
    }
}
