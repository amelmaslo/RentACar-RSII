using RentACar.Mobile.Views;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class LokacijaViewModel : BaseViewModel
    {
        Model.Lokacije _selectedLokacijaPreuzimanja = null;
        public Model.Lokacije SelectedLokacijaPreuzimanja
        {
            get { return _selectedLokacijaPreuzimanja; }
            set
            {
                SetProperty(ref _selectedLokacijaPreuzimanja, value);
                if (value != null)
                {
                    LokacijePreuzimanjaCommand.Execute(null);
                }
            }
        }
        Model.Lokacije _selectedLokacijaPovrata = null;
        public Model.Lokacije SelectedLokacijaPovrata
        {
            get { return _selectedLokacijaPovrata; }
            set
            {
                SetProperty(ref _selectedLokacijaPovrata, value);
                if (value != null)
                {
                    LokacijePovrataCommand.Execute(null);
                }
            }
        }
        Model.KategorijeVozila _selectedKategorija = null;
        public Model.KategorijeVozila SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            {
                SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    KategorijaCommand.Execute(null);
                }
            }
        }

        public ICommand LokacijePreuzimanjaCommand { get; set; }
        public ICommand LokacijePovrataCommand { get; set; }
        public ICommand KategorijaCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public ObservableCollection<Model.Lokacije> lokacijePreuzimanjaList { get; set; } = new ObservableCollection<Model.Lokacije>();
        public ObservableCollection<Model.Lokacije> lokacijePovrataList { get; set; } = new ObservableCollection<Model.Lokacije>();
        public ObservableCollection<Model.KategorijeVozila> kategorijeVozilaList { get; set; } = new ObservableCollection<Model.KategorijeVozila>();

        public LokacijaViewModel()
        {
            Title = "Nova rezervacija";
            LokacijePreuzimanjaCommand = new Command(async () => await LokacijePreuzimanja());
            LokacijePovrataCommand = new Command(async () => await LokacijePovrata());
            KategorijaCommand = new Command(async () => await Kategorija());
            InitCommand = new Command(async () => await Init());
        }
        private readonly APIService _kategorijeVozilaServices = new APIService("KategorijeVozila");
        private readonly APIService _lokacijeServices = new APIService("Lokacije");
        private readonly APIService _rezervacijeServices = new APIService("Rezervacije");
        public async Task Init()//preporucit cemo lokacije i kategorije prema onome sto je korisnik do sada izabirao
        {
            var listRezervacija = await _rezervacijeServices.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest() { KorisnickoIme = APIService.Username });
            if (listRezervacija.Count != 0)
            {

                List<Model.KategorijeVozila> listaKategorija = new List<Model.KategorijeVozila>();
                List<Model.Lokacije> listaPreuzimanja = new List<Model.Lokacije>();
                List<Model.Lokacije> listaPovrata = new List<Model.Lokacije>();
                var add = true;
                foreach (var item in listRezervacija)
                {
                    add = true;
                    foreach (var kategorija in listaKategorija)
                        if (item.Vozilo.KategorijaVozilaId == kategorija.KategorijaVozilaId)
                            add = false;
                    if (add)
                        listaKategorija.Add(item.Vozilo.KategorijaVozila);

                    add = true;
                    foreach (var lokacija in listaPreuzimanja)
                        if (item.LokacijaPreuzimanjaId == lokacija.LokacijaId)
                            add = false;
                    if (add)
                        listaPreuzimanja.Add(item.LokacijaPreuzimanja);

                    add = true;
                    foreach (var lokacija in listaPovrata)
                        if (item.LokacijaPreuzimanjaId == lokacija.LokacijaId)
                            add = false;
                    if (add)
                        listaPovrata.Add(item.LokacijaPovrata);
                }

                int najveci = 0;
                Model.KategorijeVozila kategorijaVozila = null;
                foreach (var kategorija in listaKategorija)
                {
                    int brojac = 0;
                    foreach (var item in listRezervacija)
                        if (item.Vozilo.KategorijaVozilaId == kategorija.KategorijaVozilaId)
                            brojac++;
                    if (brojac >= najveci)
                    {
                        najveci = brojac;
                        kategorijaVozila = kategorija;
                    }
                }

                najveci = 0;
                Model.Lokacije lokacijaPreuzimanja = null;
                foreach (var lokacija in listaPreuzimanja)
                {
                    int brojac = 0;
                    foreach (var item in listRezervacija)
                        if (item.LokacijaPreuzimanjaId == lokacija.LokacijaId)
                            brojac++;
                    if (brojac >= najveci)
                    {
                        najveci = brojac;
                        lokacijaPreuzimanja = lokacija;
                    }
                }

                najveci = 0;
                Model.Lokacije lokacijaPovrata = null;
                foreach (var lokacija in listaPovrata)
                {
                    int brojac = 0;
                    foreach (var item in listRezervacija)
                        if (item.LokacijaPovrataId == lokacija.LokacijaId)
                            brojac++;
                    if (brojac >= najveci)
                    {
                        najveci = brojac;
                        lokacijaPovrata = lokacija;
                    }
                }

                if (kategorijaVozila != null)
                    SelectedKategorija = kategorijeVozilaList.Where(x=>x.KategorijaVozilaId == kategorijaVozila.KategorijaVozilaId).FirstOrDefault();
                if (lokacijaPreuzimanja != null)
                    SelectedLokacijaPreuzimanja = lokacijePreuzimanjaList.Where(x=>x.LokacijaId == lokacijaPreuzimanja.LokacijaId).FirstOrDefault();
                if (lokacijaPovrata != null)
                    SelectedLokacijaPovrata = lokacijePovrataList.Where(x=>x.LokacijaId == lokacijaPovrata.LokacijaId).FirstOrDefault();
            }
        }
        public async Task LokacijePreuzimanja()
        {
            try
            {
                if (lokacijePreuzimanjaList.Count == 0)
                {
                    var list = await _lokacijeServices.Get<List<Model.Lokacije>>(null);
                    foreach (var item in list)
                        lokacijePreuzimanjaList.Add(item);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }
        public async Task LokacijePovrata()
        {
            try
            {
                if (lokacijePovrataList.Count == 0)
                {
                    var list = await _lokacijeServices.Get<IEnumerable<Model.Lokacije>>(null);
                    foreach (var item in list)
                        lokacijePovrataList.Add(item);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }

        public async Task Kategorija()
        {
            try
            {
                if (kategorijeVozilaList.Count == 0)
                {
                    var list = await _kategorijeVozilaServices.Get<List<Model.KategorijeVozila>>(null);
                    foreach (var item in list)
                        kategorijeVozilaList.Add(item);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }
        }

        DateTime datumPreuzimanja = DateTime.Now;
        public DateTime _datumPreuzimanja
        {
            get { return datumPreuzimanja; }
            set
            {
                SetProperty(ref datumPreuzimanja, value);
            }
        }
        DateTime datumPovrata = DateTime.Now.AddDays(1);

        public DateTime _datumPovrata
        {
            get { return datumPovrata; }
            set
            {
                SetProperty(ref datumPovrata, value);
            }
        }
    }
}
