using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class KupacViewModel:BaseViewModel
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
        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }

        string _novaLozinka = string.Empty;
        public string NovaLozinka
        {
            get { return _novaLozinka; }
            set { SetProperty(ref _novaLozinka, value); }
        }


        string _potrdaLozinke = string.Empty;
        public string PotvrdaLozinke
        {
            get { return _potrdaLozinke; }
            set { SetProperty(ref _potrdaLozinke, value); }
        }

        public readonly APIService _kupciServices = new APIService("Kupci");
        public ICommand InitCommand { get; set; }
        public ICommand UrediCommand { get; set; }
        
        public KupacViewModel()
        {
            Title = "Lični podaci";
            UrediCommand = new Command(async () => await Uredi());
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var zastoj = await _kupciServices.Get<List<Model.Kupci>>(null);//da uspori
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prijavite se kao kupac!", "Uredu");
                Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
                return;
            }
            try
            {
                Ime = kupac[0].Ime;
                Prezime = kupac[0].Prezime;
                Telefon = kupac[0].Telefon;
                Email = kupac[0].Email;
                KorisnickoIme = kupac[0].KorisnickoIme;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }

        public async Task Uredi()
        {
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count != 0)
            {
                if (Lozinka.Equals(APIService.Password))
                {
                    try
                    {
                        KupciUpsertRequest request = new KupciUpsertRequest()
                        {
                            Ime = Ime,
                            Prezime = Prezime,
                            Status = true,
                            DatumRegistracije = DateTime.Now,
                            Email = Email,
                            KorisnickoIme = KorisnickoIme,
                            Telefon = Telefon,
                            Password = NovaLozinka,
                            PasswordPotvrda = PotvrdaLozinke
                        };

                        var entity = await _kupciServices.Update<Model.Kupci>(kupac[0].KupacId,request);
                        if (entity != null) { 
                            await Application.Current.MainPage.DisplayAlert("Obavjest","Uspješno ste izmijenili lične podatke!", "Uredu");
                            if(!string.IsNullOrWhiteSpace(request.Password))
                                APIService.Password = request.Password;
                        }

                    }
                    catch (Exception ex)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
                    }
                }
                else { 
                        await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešna lozinka!", "Uredu");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prijavite se kao kupac!", "Uredu");
                Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
                return;
            }
        }

        public async Task<bool> txtEmail_Validating()
        {
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count == 1)
            {
                var result = await _kupciServices.Get<List<Model.Kupci>>(null);
                foreach (var item in result)
                    if (item.Email == Email && item.KupacId != kupac[0].KupacId)
                    {
                        return false;
                    }
                return true;
            }
            return false;
        }
    }
}
