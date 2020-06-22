using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class PretplateViewModel:BaseViewModel
    {
        Model.KategorijeVozila _preplatiSe = null;
        public Model.KategorijeVozila SelectedPretplatiSe
        {
            get { return _preplatiSe; }
            set
            {
                SetProperty(ref _preplatiSe, value);
                if (value != null)
                {
                    PretplatiSeCommand.Execute(null);
                }
            }
        }
        Model.KategorijeVozila _ukloniPretplatu = null;
        public Model.KategorijeVozila SelectedukloniPretplatu
        {
            get { return _ukloniPretplatu; }
            set
            {
                SetProperty(ref _ukloniPretplatu, value);
                if (value != null)
                {
                    UkloniPretplatuCommand.Execute(null);
                }
            }
        }


        public readonly APIService _pretplateServices = new APIService("Pretplate");
        public readonly APIService _kategorijeVozilaServices = new APIService("KategorijeVozila");
        public readonly APIService _kupciServices = new APIService("Kupci");
        public ObservableCollection<Model.KategorijeVozila> kategorijeVozilaList { get; set; } = new ObservableCollection<Model.KategorijeVozila>();
        public ObservableCollection<Model.KategorijeVozila> mojeKategorijeVozilaList { get; set; } = new ObservableCollection<Model.KategorijeVozila>();

        public ICommand InitCommand { get; set; }
        public ICommand PretplatiSeCommand{ get; set; }
        public ICommand UkloniPretplatuCommand { get; set; }
    


        public PretplateViewModel()
        {
            Title = "Pretplate";
            InitCommand = new Command(async () => await Init());
            PretplatiSeCommand = new Command(async () => await PretplatiSe());
            UkloniPretplatuCommand = new Command(async () => await UkloniPretplatu());
        }

        public async Task PretplatiSe()
        {
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count!=0)
            {
                try
                {
                    PretplateUpsertRequest request = new PretplateUpsertRequest()
                    {
                        Datum = DateTime.Now,
                        KupacId = kupac[0].KupacId,
                        KategorijaVozilaId = SelectedPretplatiSe.KategorijaVozilaId,
                        Status = true
                    };
                    var entity = await _pretplateServices.Insert<Model.Pretplate>(request);
                    if (entity != null) { 
                        await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste dodali pretplatu!", "Uredu");
                    }

                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
                }
            }
            else
            {
               await Application.Current.MainPage.DisplayAlert("Greška", "Prijavite se kao kupac!", "Uredu");
               Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
               return;
            }

            await Init();
        }
        public async Task UkloniPretplatu()
        {
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count != 0)
            {
                try
                {
                    int _id = 0;
                    var list = await _pretplateServices.Get<List<Model.Pretplate>>(new PretplateSearchRequest() { KorisnickoIme = APIService.Username, KategorijaVozilaId = SelectedukloniPretplatu.KategorijaVozilaId }) ;
                    foreach (var item in list) {
                        if (item.Status)
                            _id = item.PretplataId;
                    }

                    PretplateUpsertRequest request = new PretplateUpsertRequest()
                    {
                        Datum = DateTime.Now,
                        KupacId = kupac[0].KupacId,
                        KategorijaVozilaId = SelectedukloniPretplatu.KategorijaVozilaId,
                        Status = false
                    };
                    
                    var entity = await _pretplateServices.Update<Model.Pretplate>(_id, request);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste uklonili pretplatu!", "Uredu");
                    }

                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prijavite se kao kupac!", "Uredu");
                Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
                return;
            }
            await Init();
        }

        public async Task Init()
        {
            IsBusy = true;
            try
            {
                List<Model.Pretplate> mojePreplateList = new List<Model.Pretplate>();
                var mojaList = await _pretplateServices.Get<List<Model.Pretplate>>(new PretplateSearchRequest() { KorisnickoIme = APIService.Username});
                
                foreach (var item in mojaList)
                {
                    if (item.Status)
                        mojePreplateList.Add(item);
                }

                kategorijeVozilaList.Clear();
                mojeKategorijeVozilaList.Clear();

                var list = await _kategorijeVozilaServices.Get<List<Model.KategorijeVozila>>(null);
                bool nema; 
                foreach (var item in list) {
                    nema = true;
                    foreach (var pretplata in mojePreplateList) {
                        if (item.KategorijaVozilaId == pretplata.KategorijaVozilaId) {
                            nema = false;
                        }
                    }
                    if (nema)
                    {
                        kategorijeVozilaList.Add(item);
                    }
                    else {
                        mojeKategorijeVozilaList.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
