using RentACar.Mobile.ViewModels;
using RentACar.Model.Requests;
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
    public partial class VozilaPage : ContentPage
    {
        private VozilaViewModel model = null;
        public VozilaPage(VozilaViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = model = viewModel;
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await model.Init();
        //}

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Vozila;
            if (item == null || model._request == null)
                return;

            model._request.VoziloId = item.VoziloId;

            await Navigation.PushAsync(new VozilaDetaljiPage(new VozilaDetaljiViewModel(model._request)));
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        private async void OcjeneListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(model?._request == null)
                return;
            await model.Init();
        }
    }
}