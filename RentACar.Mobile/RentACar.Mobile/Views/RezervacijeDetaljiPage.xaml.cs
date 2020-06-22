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
    public partial class RezervacijeDetaljiPage : ContentPage
    {
        RezervacijeDetaljiViewModel viewModel; 

        public RezervacijeDetaljiPage(RezervacijeDetaljiViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
        }

        public RezervacijeDetaljiPage()
        {
            InitializeComponent();

            var item = new Model.Rezervacije();
            viewModel = new RezervacijeDetaljiViewModel(item);
            BindingContext = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = ((Button)sender).BindingContext as Model.Rezervacije;
            if (item == null)
                return;
            if (item.Status)
            {
                int? _rezervacijaId = item.RezervacijaId;
                Navigation.PushAsync(new RacunPage(_rezervacijaId));
            }
            else {
                Application.Current.MainPage.DisplayAlert("Error", "Rezervacija nije aktivna!", "Uredu");
            }
        }

        async void Button_Clicked_Otkazi(object sender, EventArgs e)
        {
           await viewModel.OtkaziRezervaciju();
        }

        async void Button_Clicked_Ocjeni(object sender, EventArgs e)
        {
            await viewModel.OcjeniRezervaciju();
        }

    }
}