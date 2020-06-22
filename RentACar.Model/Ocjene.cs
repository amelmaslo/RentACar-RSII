using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int VoziloId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual Vozila Vozilo { get; set; }
    }
}
