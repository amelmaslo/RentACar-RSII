using RentACar.Mobile.Views;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class RegistrujSeViewModel : BaseViewModel
    {
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }

        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _passwordPotvrda = string.Empty;
        public string PasswordPotvrda
        {
            get { return _passwordPotvrda; }
            set { SetProperty(ref _passwordPotvrda, value); }
        }

        public ICommand RegistracijaCommand { get; set; }
        public ICommand PrijaviSeCommand { get; set; }


        public RegistrujSeViewModel()
        {
            RegistracijaCommand = new Command(async () => await Registracija());
            PrijaviSeCommand = new Command(() => PrijaviSe());
        }

        private readonly APIService _kupciService = new APIService("Kupci");
        public void PrijaviSe()
        {
            Application.Current.MainPage = new LoginPage();
        }
        public async Task Registracija()
        {

            var request = new KupciUpsertRequest()
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                Telefon = Telefon,
                KorisnickoIme = KorisnickoIme,
                Password = Password,
                PasswordPotvrda = PasswordPotvrda,
                DatumRegistracije = DateTime.Now,
                Status = true
            };

            try
            {
                var item = await _kupciService.Insert<Model.Kupci>(request);

                await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste se registrovali!", "Uredu");
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Obavjest", ex.Message, "Uredu");
            }
        }
       

        public async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _kupciService.Get<List<Model.Kupci>>(null);
            foreach (var item in result)
                if (item.KorisnickoIme == KorisnickoIme)
                {
                    return false;
                }
            return true;
        }

        public async Task<bool> txtEmail_Validating()
        {
            var result = await _kupciService.Get<List<Model.Kupci>>(null);
            foreach (var item in result)
                if (item.Email == Email)
                {
                    return false;
                }
            return true;
        }
    }
}
