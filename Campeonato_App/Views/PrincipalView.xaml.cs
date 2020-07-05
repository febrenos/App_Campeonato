﻿using Campeonato_App.Models;
using Campeonato_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        PrincipalViewModel pv = new PrincipalViewModel();
        public PrincipalView()
        {
            InitializeComponent();
            this.BindingContext = pv;
        }
    }
}
