using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class DodatnaOprema
    {
        public int DodatnaOpremaId { get; set; }
        public DateTime Datum { get; set; }
        public int OpremaId { get; set; }
        public int RezervacijaId { get; set; }
        public virtual Oprema Oprema { get; set; }
    }
}
