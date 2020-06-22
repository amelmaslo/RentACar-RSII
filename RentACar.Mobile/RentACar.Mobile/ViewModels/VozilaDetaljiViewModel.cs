using RentACar.Mobile.Views;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class VozilaDetaljiViewModel : BaseViewModel
    {
        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
        string _model = string.Empty;
        public string Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }

        string _cijena = string.Empty;
        public string Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        string _gorivo = string.Empty;
        public string Gorivo
        {
            get { return _gorivo; }
            set { SetProperty(ref _gorivo, value); }
        }

        string _snaga = string.Empty;
        public string Snaga
        {
            get { return _snaga; }
            set { SetProperty(ref _snaga, value); }
        }

        string _brojVrata = string.Empty;
        public string BrojVrata
        {
            get { return _brojVrata; }
            set { SetProperty(ref _brojVrata, value); }
        }

        string _brojSjedista = string.Empty;
        public string BrojSjedista
        {
            get { return _brojSjedista; }
            set { SetProperty(ref _brojSjedista, value); }
        }

        string _godinaProizvodnje = string.Empty;
        public string GodinaProizvodnje
        {
            get { return _godinaProizvodnje; }
            set { SetProperty(ref _godinaProizvodnje, value); }
        }
        string _transmisija = string.Empty;
        public string Transmisija
        {
            get { return _transmisija; }
            set { SetProperty(ref _transmisija, value); }
        }

        string _napomena = string.Empty;
        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }

        RezervacijeUpsertRequest _request;
        public VozilaDetaljiViewModel(RezervacijeUpsertRequest request = null)
        {
            Title = "Rezerviši vozilo";
            _request = request;
            InitCommand = new Command(async () => await Init());
            RezervisiCommand = new Command(async () => await Rezervisi());
            OpremaCommand = new Command(async () => await Oprema());
            OsiguranjeCommand = new Command(async () => await Osiguranje());
        }
        public ICommand InitCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }
        public ICommand OpremaCommand { get; set; }
        public ICommand OsiguranjeCommand { get; set; }

        public VozilaDetaljiViewModel()
        {
            Title = "Rezerviši vozilo";
            _request = null;
        }
        public ObservableCollection<Model.Oprema> opremaList { get; set; } = new ObservableCollection<Model.Oprema>();
        public ObservableCollection<Model.Osiguranja> osiguranjeList { get; set; } = new ObservableCollection<Model.Osiguranja>();
        public List<int> ListOpremaId { get; set; } = new List<int>();

        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _opremaService = new APIService("Oprema");
        private readonly APIService _osiguranjaService = new APIService("Osiguranja");
        private readonly APIService _rezervacijeServices = new APIService("Rezervacije");

        public async Task Init()
        {
            var bezveze = await _rezervacijeServices.Get<List<Model.Rezervacije>>(null);//cisto da usporim app da bi se ucitali podaci

            if (_request != null)
            {
                var item = await _vozilaService.GetById<Model.Vozila>(_request.VoziloId);
                if (item != null)
                {
                    Slika = item.Slika;
                    Model = item.Model.Naziv;
                    Cijena = item.Cijena.ToString() + "€";
                    Gorivo = item.Gorivo;
                    Snaga = item.Snaga;
                    BrojSjedista = item.BrojSjedista.ToString();
                    BrojVrata = item.BrojVrata.ToString();
                    GodinaProizvodnje = item.GodinaProizvodnje.ToString();
                    Transmisija = item.Transmisija;
                }
            }
        }
        private readonly APIService _kupciService = new APIService("Kupci");
        public async Task Rezervisi()
        {
            try
            {
                var kupac = await _kupciService.Get<List<Model.Kupci>>(new KupciSearchRequest(){ KorisnickoIme = APIService.Username});
                if (kupac.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Loguj te se kao kupac!", "Uredu");
                    Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
                    return;
                }
                if (SelectedOsiguranje != null)
                {
                    _request.OsiguranjeId = SelectedOsiguranje.OsiguranjeId;
                    _request.DatumKreiranjaRezervacij = DateTime.Now;
                    _request.Oprema = ListOpremaId;
                    _request.KupacId = kupac[0].KupacId;
                    _request.Status = true;
                    _request.Popust = 0;
                    _request.Napomena = Napomena;

                    var entity = await _rezervacijeServices.Insert<Model.Rezervacije>(_request);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste kreirali rezervaciju!", "Uredu");
                    }
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite vrstu osiguranja!", "Uredu");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            } 
        }

        Model.Osiguranja _selectedOsiguranje = null;
        public Model.Osiguranja SelectedOsiguranje
        {
            get { return _selectedOsiguranje; }
            set { SetProperty(ref _selectedOsiguranje, value); }
        }

        public async Task Osiguranje()
        {
            try
            {
                if (osiguranjeList.Count == 0)
                {
                    var list = await _osiguranjaService.Get<List<Model.Osiguranja>>(null);
                    foreach (var item in list)
                        osiguranjeList.Add(item);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }
        public async Task Oprema()
        {
            try
            {
                opremaList.Clear();
                var list = await _opremaService.Get<List<Model.Oprema>>(null);
                foreach (var item in list)
                    opremaList.Add(item);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }
    }
}
   