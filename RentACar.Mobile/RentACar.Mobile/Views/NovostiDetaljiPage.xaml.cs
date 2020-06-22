using RentACar.Mobile.ViewModels;
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
    public partial class NovostiDetaljiPage : ContentPage
    {
        NovostiDetaljiViewModel viewModel;
        public NovostiDetaljiPage(NovostiDetaljiViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.Init();
        }

        public NovostiDetaljiPage()
        {
            InitializeComponent();

            var item = new Model.Novosti
            {
                Naziv = "Item 1",
                Opis = "This is an item description.",
                Datum = DateTime.Now,
                Slika = null
            };

            viewModel = new NovostiDetaljiViewModel(item);
            BindingContext = viewModel;
        }
    }
}