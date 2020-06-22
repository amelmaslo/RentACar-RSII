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
    public partial class NovostiPage : ContentPage
    {
        private NovostiViewModel model = null;
        public NovostiPage()
        {
            InitializeComponent();
            BindingContext = model = new NovostiViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (model.novostiList.Count == 0)
                model.IsBusy = true;
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Novosti;
            if (item == null)
                return;
            await Navigation.PushAsync(new NovostiDetaljiPage(new NovostiDetaljiViewModel(item)));
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
    }
}