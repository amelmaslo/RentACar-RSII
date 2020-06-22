using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Novosti
    {
        public int NovostId { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
        public virtual Korisnici Korisnik { get; set; }
    }
}
