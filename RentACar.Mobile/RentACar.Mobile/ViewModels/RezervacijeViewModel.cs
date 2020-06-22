using RentACar.Model;
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
    public class RezervacijeViewModel:BaseViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _vozilaService = new APIService("Vozila");
        public ObservableCollection<Model.Rezervacije> rezervacijeList { get; set; } = new ObservableCollection<Model.Rezervacije>();
        public ObservableCollection<Model.Vozila> vozilaList { get; set; } = new ObservableCollection<Model.Vozila>();
        public ICommand InitCommand { get; set; }

        Vozila _selectedVozilo = null;
        public Vozila SelectedVozilo {
            get { return _selectedVozilo; }
            set
            {
                SetProperty(ref _selectedVozilo, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public RezervacijeViewModel() {
            Title = "Moje rezervacije";
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            if (vozilaList.Count == 0)
            {
                var listVozila = await _vozilaService.Get<List<Model.Vozila>>(null);
                foreach (var vozilaItem in listVozila)
                    vozilaList.Add(vozilaItem);
            }
            RezervacijeSearchRequest search = new RezervacijeSearchRequest() {KorisnickoIme = APIService.Username };
            if (SelectedVozilo != null)
            {
                search.Vozilo = SelectedVozilo.Model.Naziv;
                var list = await _rezervacijeService.Get<IEnumerable<Model.Rezervacije>>(search);
                rezervacijeList.Clear();
                foreach (var item in list)
                    rezervacijeList.Add(item);
            }
            else
            {
                var list = await _rezervacijeService.Get<IEnumerable<Model.Rezervacije>>(search);
                rezervacijeList.Clear();
                foreach (var item in list)
                    rezervacijeList.Add(item);
            }
        }
    }
}
