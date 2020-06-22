using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class NovostiDetaljiViewModel:BaseViewModel
    {
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        string _autor = string.Empty;
        public string Autor
        {
            get { return _autor; }
            set { SetProperty(ref _autor, value); }
        }

        string _datum = DateTime.Now.ToString();
        public string Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public Model.Novosti Item { get; set; }
        public ICommand InitCommand { get; set; }
        public NovostiDetaljiViewModel(Model.Novosti item = null)
        {
            Title = "Pregled novosti";
            Item = item;
            InitCommand = new Command(() => Init());
        }
        public NovostiDetaljiViewModel()
        {
            Title = "Pregled novosti";
        }
        public void Init() {
            Naziv = Item.Naziv;
            Opis = Item.Opis;
            Datum = Item.Datum.ToString("dd.MM.yyyy HH:mm");
            Autor = Item.Korisnik.Ime + " " + Item.Korisnik.Prezime + " ";
            Slika = Item.Slika;
        }
    }
}
