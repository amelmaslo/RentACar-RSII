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
    public partial class VozilaDetaljiPage : ContentPage
    {
        private VozilaDetaljiViewModel model = null;

        public VozilaDetaljiPage(VozilaDetaljiViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = model = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.Oprema();
            await model.Osiguranje();
        }
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var item = ((CheckBox)sender).BindingContext as int?;
            if (item == null)
                return;

            if (model.ListOpremaId.Contains(item.Value))
            {
                model.ListOpremaId.Remove(item.Value);
            }
            else
            {
                model.ListOpremaId.Add(item.Value);
            }
            
        }

    }
}