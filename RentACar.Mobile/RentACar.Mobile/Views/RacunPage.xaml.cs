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
    public partial class RacunPage : ContentPage
    {
        RacunViewModel viewModel = null;
        public RacunPage(int? _rezervacijaId)
        {
            InitializeComponent();
            BindingContext = viewModel = new RacunViewModel(_rezervacijaId);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
        }

        public RacunPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RacunViewModel(null);
        }
    }
}