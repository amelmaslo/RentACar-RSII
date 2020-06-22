using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class DodatnaOprema
    {
        public int DodatnaOpremaId { get; set; }
        public DateTime Datum { get; set; }
        public int OpremaId { get; set; }
        public int RezervacijaId { get; set; }

        public virtual Oprema Oprema { get; set; }
        public virtual Rezervacije Rezervacija { get; set; }
    }
}
