using Navigation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation.ViewModels
{
    class SkillsViewModel : BaseViewModel
    {
        private string skill1 = "";
        private string skill2 = "";
        private string skill3 = "";
        private string skill4 = "";
        private string skill5 = "";

        public Command OnNextCommand { get; private set; }
        public Command OnBackCommand { get; private set; }

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

        public SkillsViewModel()
        {
            OnNextCommand = new Command(GoToNextPage);
            OnBackCommand = new Command(GoToBackPage);
        }

        private async void GoToNextPage()
        {
            DataStore.AddSkill(Skill1);
            DataStore.AddSkill(Skill2);
            DataStore.AddSkill(Skill3);
            DataStore.AddSkill(Skill4);
            DataStore.AddSkill(Skill5);
            await Application.Current.MainPage.Navigation.PushAsync(new SummaryView());
        }

        private async void GoToBackPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
