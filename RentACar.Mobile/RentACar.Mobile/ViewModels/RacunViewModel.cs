using RentACar.Mobile.Models;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RentACar.Mobile.ViewModels
{
    public class RacunViewModel : BaseViewModel
    {
        string _brojRacuna = string.Empty;
        public string BrojRacuna
        {
            get { return _brojRacuna; }
            set { SetProperty(ref _brojRacuna, value); }
        }

        string _iznajmljivanjeVozila = string.Empty;
        public string IznajmljivanjeVozila
        {
            get { return _iznajmljivanjeVozila; }
            set { SetProperty(ref _iznajmljivanjeVozila, value); }
        }

        string _opremaUkupno = string.Empty;
        public string OpremaUkupno
        {
            get { return _opremaUkupno; }
            set { SetProperty(ref _opremaUkupno, value); }
        }

        string _osiguranjeUkupno = string.Empty;
        public string OsiguranjeUkupno
        {
            get { return _osiguranjeUkupno; }
            set { SetProperty(ref _osiguranjeUkupno, value); }
        }

        string _datum = string.Empty;
        public string Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        string _popust = string.Empty;
        public string Popust
        {
            get { return _popust; }
            set { SetProperty(ref _popust, value); }
        }

        string _pdv = string.Empty;
        public string Pdv
        {
            get { return _pdv; }
            set { SetProperty(ref _pdv, value); }
        }

        string _iznosBezPdv = string.Empty;
        public string IznosBezPdv
        {
            get { return _iznosBezPdv; }
            set { SetProperty(ref _iznosBezPdv, value); }
        }
        string _iznosSaPdv = string.Empty;
        public string IznosSaPdv
        {
            get { return _iznosSaPdv; }
            set { SetProperty(ref _iznosSaPdv, value); }
        }
        byte[] _qrCode = null;
        public byte[] QRCode
        {
            get { return _qrCode; }
            set { SetProperty(ref _qrCode, value); }
        }

        public int? _rezervacijaId { get; set; }
        public RacunViewModel(int? rezervacijaId = null)
        {
            Title = "Račun";
            _rezervacijaId = rezervacijaId;
        }
        public RacunViewModel()
        {
            Title = "Račun";
            _rezervacijaId = null;
        }

        public ICommand InitCommand { get; set; }
        private readonly APIService _racuniService = new APIService("Racuni");
        private readonly APIService _rezervacijeServices = new APIService("Rezervacije");
        public async Task Init() {
            var bezveze = await _rezervacijeServices.Get<List<Model.Rezervacije>>(null);//cisto da usporim app da bi se ucitali podaci

            var list = await _racuniService.Get<List<Model.Racuni>>(new RacuniSearchRequest(){ RezervacijaId = _rezervacijaId });
            Model.Racuni racun = null;
            foreach (var item in list) {
                if (item.Status)
                {
                    racun = item;
                    break;
                }
            }
            if (racun!=null) {
                BrojRacuna = "No. " + racun.BrojRacuna;
                IznajmljivanjeVozila = $"{Decimal.Round(racun.IznajmljivanjeVozila, 2)}€";
                OpremaUkupno = $"{Decimal.Round(racun.OpremaUkupno, 2)}€";
                OsiguranjeUkupno = $"{Decimal.Round(racun.OsiguranjeUkupno, 2)}€";
                Popust = $"{Decimal.Round(racun.Popust ?? 0)}%";
                Datum = racun.Datum.ToString("dd.MM.yyyy HH:mm");
                Pdv = $"{Decimal.Round(racun.Pdv, 2)}€ (17%)";
                IznosBezPdv = $"{Decimal.Round(racun.IznosBezPdv, 2)}€";
                IznosSaPdv = $"{Decimal.Round(racun.IznosSaPdv, 2)}€";
                QRCode = racun.QRCode;
            }
        }
    }
}
