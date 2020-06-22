using RentACar.Mobile.ViewModels;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LokacijaPage : ContentPage
    {
        private LokacijaViewModel model = null;
        public LokacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new LokacijaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LokacijePreuzimanja();
            await model.LokacijePovrata();
            await model.Kategorija();
            await model.Init();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            if (model.SelectedKategorija != null && model.SelectedLokacijaPovrata != null && model.SelectedLokacijaPreuzimanja != null /*&& model._datumPovrata != null && model._datumPreuzimanja != null*/)
            {
                int totalDays = (int)(model._datumPovrata.Date - model._datumPreuzimanja.Date).TotalDays;
                if (totalDays <= 0) {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Datum preuzimanja veći od datuma povrata", "Uredu");
                    return;
                }
                int Days = (int)(model._datumPreuzimanja.Date - DateTime.Now.Date).TotalDays;
                if (Days < 0) {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Datum preuzimanja manji od današnjeg datuma", "Uredu");
                    return;
                }

                var item = new RezervacijeUpsertRequest()
                {
                    DatumKreiranjaRezervacij = DateTime.Now,
                    DatumPreuzimanja = model._datumPreuzimanja,
                    DatumPovrata = model._datumPovrata,
                    KategorijaVozilaId = model.SelectedKategorija.KategorijaVozilaId,
                    LokacijaPovrataId = model.SelectedLokacijaPovrata.LokacijaId,
                    LokacijaPreuzimanjaId = model.SelectedLokacijaPreuzimanja.LokacijaId
                };
                await Navigation.PushAsync(new VozilaPage(new VozilaViewModel(item)));
            }
            else { 
               await Application.Current.MainPage.DisplayAlert("Greška","Niste izabrali sva polja","Uredu");
            }
        }
    }
}