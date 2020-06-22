using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Vozila
    {
        public int VoziloId { get; set; }
        public int ModelId { get; set; }
        public int KategorijaVozilaId { get; set; }
        public int LokacijaId { get; set; }
        public decimal Cijena { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Gorivo { get; set; }
        public string Snaga { get; set; }
        public string Transmisija { get; set; }
        public int BrojVrata { get; set; }
        public int BrojSjedista { get; set; }
        public string BrojSasije { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public virtual KategorijeVozila KategorijaVozila { get; set; }
        public virtual Lokacije Lokacija { get; set; }
        public virtual Modeli Model { get; set; }

        public string Ispis { get { return $"{Model?.Naziv ?? BrojSasije} {Cijena}€";}}
        public string Opis { get { return $"{GodinaProizvodnje} {Gorivo} {Snaga} {BrojVrata} vrata {Transmisija}"; } }
        public override string ToString() 
        {
            return $"{Model?.Naziv??BrojSasije} {Cijena}€";
        }

    }
}
