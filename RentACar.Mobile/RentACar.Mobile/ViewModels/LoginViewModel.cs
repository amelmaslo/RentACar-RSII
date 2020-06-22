using RentACar.Mobile.Views;
using RentACar.Model;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegistrujSeCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => { await Login(); });
            RegistrujSeCommand = new Command(() => { RegistrujSe(); });
        }

        private readonly APIService _service = new APIService("Uloge");
        private readonly APIService _kupciServices = new APIService("Kupci");
        public async Task Login()
        {
            APIService.Username = _username;
            APIService.Password = _password;
            try
            {
                await _service.Get<dynamic>(null);

                List<Kupci> kupciList = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username});
                if (kupciList.Count == 1)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else {
                    await Application.Current.MainPage.DisplayAlert("Greška","Pogrešno korisničko ime ili lozinka!", "Uredu");
                }
            }
           catch //(Exception ex)
            {
                //await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }

        public void RegistrujSe()
        {
            Application.Current.MainPage = new RegistrujSePage();
        }
    }
}
