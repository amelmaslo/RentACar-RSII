using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Lokacije
    {
        public int LokacijaId { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }
        public virtual Gradovi Grad { get; set; }

        public string Ispis { get{ return$"{Grad?.Drzava.Naziv??"Država"}, {Grad?.Naziv??"Grad"} - {Adresa??"Adresa"}"; } }
        public override string ToString()
        {
            return Adresa;
        }
    }
}
