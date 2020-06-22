using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Notifikacije
    {
        public int NotifikacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Status { get; set; }
        public int? NovostId { get; set; }
        public int KupacId { get; set; }
        public string Naziv { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual Novosti Novost { get; set; }
    }
}
