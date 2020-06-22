using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Osiguranja
    {
        public Osiguranja()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int OsiguranjeId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
