using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Novosti
    {
        public Novosti()
        {
            Notifikacije = new HashSet<Notifikacije>();
        }

        public int NovostId { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual ICollection<Notifikacije> Notifikacije { get; set; }
    }
}
