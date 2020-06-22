using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            RegistracijeVozila = new HashSet<RegistracijeVozila>();
            Novosti = new HashSet<Novosti>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual ICollection<RegistracijeVozila> RegistracijeVozila { get; set; }
        public virtual ICollection<Novosti> Novosti { get; set; }

    }
}
