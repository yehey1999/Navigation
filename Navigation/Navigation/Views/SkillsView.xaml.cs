﻿using Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsView : ContentPage
    {
        public SkillsView()
        {
            InitializeComponent();
            BindingContext = new SkillsViewModel();
        }
    }
}