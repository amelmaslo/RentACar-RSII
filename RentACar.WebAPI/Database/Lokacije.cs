using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Lokacije
    {
        public Lokacije()
        {
            RezervacijeLokacijaPovrata = new HashSet<Rezervacije>();
            RezervacijeLokacijaPreuzimanja = new HashSet<Rezervacije>();
            Vozila = new HashSet<Vozila>();
        }

        public int LokacijaId { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual ICollection<Rezervacije> RezervacijeLokacijaPovrata { get; set; }
        public virtual ICollection<Rezervacije> RezervacijeLokacijaPreuzimanja { get; set; }
        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
