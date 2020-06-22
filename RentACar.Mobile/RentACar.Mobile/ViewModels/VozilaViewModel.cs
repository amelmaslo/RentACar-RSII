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
    public class VozilaViewModel:BaseViewModel
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        private readonly APIService _preporukeService = new APIService("Preporuke");
        public ObservableCollection<Model.Vozila> vozilaList { get; set; } = new ObservableCollection<Model.Vozila>();
        public ObservableCollection<Model.Vozila> preporucenaVozilaList { get; set; } = new ObservableCollection<Model.Vozila>();
        public ObservableCollection<string> ocjeneList { get; set; } = new ObservableCollection<string>() {"Sva vozila","1","2","3","4","5","6","7","8","9","10"};
        private string _selectedOcjena = "Sva vozila";
        public string SelectedOcjena
        {
            get { return _selectedOcjena; }
            set
            {
                SetProperty(ref _selectedOcjena, value);
            }
        }

        public ICommand InitCommand { get; set; }
        public RezervacijeUpsertRequest _request;
        
        public VozilaViewModel(RezervacijeUpsertRequest request = null) {
            Title = "Odaberi vozilo";
            _request = request;
            InitCommand = new Command(async () => await Init());
        }
        public VozilaViewModel()
        {
            Title = "Odaberi vozilo";
            _request = null;
        }
        public async Task Init()
        {
            var list = await _vozilaService.Get<List<Model.Vozila>>(new VozilaSearchRequest() { KategorijaVozilaId = _request.KategorijaVozilaId, LokacijaId = _request.LokacijaPreuzimanjaId });
            var rezervacijeList = await _rezervacijeService.Get<List<Model.Rezervacije>>(null);
            var listOcjene = await _ocjeneService.Get<List<Model.Ocjene>>(null);
            vozilaList.Clear();

            foreach (var item in list)
            {
                bool nema = true;
                foreach (var rezervacija in rezervacijeList)
                {
                    if (rezervacija.Status && rezervacija.VoziloId == item.VoziloId)
                    {
                        if (!(_request.DatumPovrata.Date <= rezervacija.DatumPreuzimanja.Date || _request.DatumPreuzimanja.Date >= rezervacija.DatumPovrata.Date))
                        {
                            nema = false;
                        }
                    }
                }
                if (nema && item.Status)
                { //ako nije rezervisani i auto aktivno - dostupno za rezervisat
                    if (SelectedOcjena == "Sva vozila")
                    {
                        vozilaList.Add(item);
                    }
                    else
                    {
                        int brojac = 0;
                        double suma = 0;
                        foreach (var ocjena in listOcjene)
                        {
                            if (ocjena.VoziloId == item.VoziloId)
                            {
                                brojac++;
                                suma += ocjena.Ocjena;
                            }
                        }
                        suma = suma / brojac;
                        if (suma >= int.Parse(SelectedOcjena) || brojac == 0)
                        {
                            vozilaList.Add(item);
                        }
                    }
                }
            }
            preporucenaVozilaList.Clear();
            var vozila = await _preporukeService.Get<List<Model.Vozila>>(new PreporukeSearchRequest() { KorisnickoIme = APIService.Username, KategorijaVozilaId = _request.KategorijaVozilaId.Value, LokacijaPreuzimanjaId = _request.LokacijaPreuzimanjaId, DatumPreuzimanja = _request.DatumPreuzimanja, DatumPovrata = _request.DatumPovrata });
            foreach (var item in vozila)
            {
                preporucenaVozilaList.Add(item);
            }
        }
    } 
}
