using RentACar.Mobile.Models;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class RezervacijeDetaljiViewModel : BaseViewModel
    {
        string _vozilo= string.Empty;
        public string Vozilo
        {
            get { return _vozilo; }
            set { SetProperty(ref _vozilo, value); }
        }

        string _osiguranje = string.Empty;
        public string Osiguranje
        {
            get { return _osiguranje; }
            set { SetProperty(ref _osiguranje, value); }
        }

        string _lokacijaPreuzimanja = string.Empty;
        public string LokacijaPreuzimanja
        {
            get { return _lokacijaPreuzimanja; }
            set { SetProperty(ref _lokacijaPreuzimanja, value); }
        }

        string _lokacijaPovrata = string.Empty;
        public string LokacijaPovrata
        {
            get { return _lokacijaPovrata; }
            set { SetProperty(ref _lokacijaPovrata, value); }
        }

        string _datumPreuzimanja = string.Empty;
        public string DatumPreuzimanja
        {
            get { return _datumPreuzimanja; }
            set { SetProperty(ref _datumPreuzimanja, value); }
        }

        string _datumPovrata = string.Empty;
        public string DatumPovrata
        {
            get { return _datumPovrata; }
            set { SetProperty(ref _datumPovrata, value); }
        }

        string _oprema = string.Empty;
        public string Oprema
        {
            get { return _oprema; }
            set { SetProperty(ref _oprema, value); }
        }
        string _napomena = string.Empty;
        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }
        Model.Rezervacije _rezervacija = null;
        public Model.Rezervacije Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }

        int _ocjena = 10;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        public Model.Rezervacije Item { get; set; }

        public ICommand InitCommand { get; set; }

        public RezervacijeDetaljiViewModel(Model.Rezervacije item = null)
        {
            Title = "Pregled rezervacije";
            Item = item;
            InitCommand = new Command(async() => await Init());
        }
        public RezervacijeDetaljiViewModel()
        {
            Title = "Pregled rezervacije";
            Item = null;
            InitCommand = new Command(async() => await Init());
        }
        public async Task Init() {
            var bezveze = await _rezervacijeServices.Get<List<Model.Rezervacije>>(null);//cisto da usporim app da bi se ucitali podaci
            var list = await _rezervacijeServices.Get<List<Model.Rezervacije>>(null);
            if (Item != null)
            {
                Rezervacija = Item;
                Vozilo = Item.Vozilo.Model.Naziv;
                Osiguranje = Item.Osiguranje.Naziv;
                Item.Oprema = string.Empty;
                foreach (var oprama in Item.DodatnaOprema)
                {
                    Item.Oprema += oprama.Oprema.Naziv + " ";
                }
                Oprema = Item.Oprema;

                LokacijaPreuzimanja = Item.LokacijaPreuzimanja.ToString();
                LokacijaPovrata = Item.LokacijaPovrata.ToString();
                DatumPreuzimanja = Item.DatumPreuzimanja.ToString("dd.MM.yyyy");
                DatumPovrata = Item.DatumPovrata.ToString("dd.MM.yyyy");

                Napomena = Item.Napomena;

                var listOcjena = await _ocjeneService.Get<List<Model.Ocjene>>(null);
                foreach (var ocjena in listOcjena)
                {
                    if (ocjena.KupacId == Item.KupacId && ocjena.VoziloId == Item.VoziloId)
                    {
                        Ocjena = ocjena.Ocjena;
                    }
                }
            }
            else { 
                await Application.Current.MainPage.DisplayAlert("Greška", "Rezervaciju nemoguće učitati!", "Uredu");
            }
        }
        private readonly APIService _rezervacijeServices = new APIService("Rezervacije");
        private readonly APIService _ocjeneService = new APIService("Ocjene");

        public async Task OcjeniRezervaciju()
        {
            if (Item != null)
            {
                if (Item.Status)
                {
                    var totalDay = (int)(DateTime.Now.Date - Item.DatumPovrata.Date).TotalDays;
                    if (totalDay < 0)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", $"Rezervaciju nemoguće ocjeniti prije povrata vozila!", "Uredu");
                    }
                    else
                    {
                        int? OcjenaId = null;
                        var list = await _ocjeneService.Get<List<Model.Ocjene>>(null);
                        foreach (var item in list)
                        {
                            if (item.KupacId == Item.KupacId && item.VoziloId == Item.VoziloId)
                            {
                                OcjenaId = item.OcjenaId;
                            }
                        }


                        OcjeneUpsertRequest request = new OcjeneUpsertRequest()
                        {
                            KupacId = Item.KupacId,
                            VoziloId = Item.VoziloId,
                            Datum = DateTime.Now,
                            Ocjena = Ocjena
                        };
                        try
                        {
                            Model.Ocjene entity = null;

                            if (OcjenaId == null)
                                entity = await _ocjeneService.Insert<Model.Ocjene>(request);
                            else
                                entity = await _ocjeneService.Update<Model.Ocjene>(OcjenaId.Value, request);

                            if (entity != null)
                            {
                                await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste ocjenili vozilo!", "Uredu");
                                await Init();
                            }
                        }
                        catch
                        {
                            await Application.Current.MainPage.DisplayAlert("Greška", "Greška na serveru!", "Uredu");
                        }
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Rezervacija nije aktivna!", "Uredu");
                }

            }
        }
        public async Task OtkaziRezervaciju()
        {
         
            if (Item != null)
            {
                if (Item.Status) {
                    var totalDay = (int)(Item.DatumPreuzimanja.Date - DateTime.Now.Date).TotalDays;
                    if (totalDay <= 1)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", $"Rezervaciju nemoguće otkazati dan prije datuma preuzimanja!", "Uredu");
                    }
                    else {
                        
                            Item.Status = false;

                            RezervacijeUpsertRequest request = new RezervacijeUpsertRequest()
                            {
                                KupacId = Item.KupacId,
                                VoziloId = Item.VoziloId,
                                OsiguranjeId = Item.OsiguranjeId,
                                LokacijaPreuzimanjaId = Item.LokacijaPreuzimanjaId,
                                LokacijaPovrataId = Item.LokacijaPovrataId,
                                DatumPreuzimanja = Item.DatumPreuzimanja,
                                DatumPovrata = Item.DatumPovrata,
                                DatumKreiranjaRezervacij = Item.DatumKreiranjaRezervacij,
                                Napomena = Item.Napomena,
                                Status = Item.Status,
                            };
                            foreach (var operma in Item.DodatnaOprema)
                            {
                                request.Oprema.Add(operma.OpremaId);
                            }

                        try
                        {
                            Model.Rezervacije entity = null;
                            entity = await _rezervacijeServices.Update<Model.Rezervacije>(Item.RezervacijaId, request);
                            if (entity != null)
                            {
                                await Application.Current.MainPage.DisplayAlert("Obavjest", "Rezervacija otkazana!", "Uredu");
                                await Init();
                            }
                        }
                        catch { 
                            await Application.Current.MainPage.DisplayAlert("Greška", "Greška na serveru!", "Uredu");
                        }
                    }
                }
                else {
                   await Application.Current.MainPage.DisplayAlert("Greška", "Rezervacija nije aktivna!", "Uredu");
                }
            }
        }

    }
}
