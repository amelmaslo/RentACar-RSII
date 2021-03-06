﻿using RentACar.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifikacijePage : ContentPage
    {
        private NotifikacijeViewModel model = null;
        public NotifikacijePage()
        {
            InitializeComponent();
            BindingContext = model = new NotifikacijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}