using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Oprema
    {
        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public string Ispis { get { return $"{Naziv} {Cijena}"; } }
        public override string ToString()
        {
            return $"{Naziv} {Cijena}€";
        }
    }
}
