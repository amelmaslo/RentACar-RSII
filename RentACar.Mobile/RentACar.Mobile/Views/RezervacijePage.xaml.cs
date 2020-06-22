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
    public partial class RezervacijePage : ContentPage
    {
        private RezervacijeViewModel model = null; //dobra praksa da si napravimo property
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Rezervacije;
            if (item == null)
                return;
            await Navigation.PushAsync(new RezervacijeDetaljiPage(new RezervacijeDetaljiViewModel(item)));
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
    }
}