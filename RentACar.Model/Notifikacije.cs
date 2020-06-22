using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Notifikacije
    {
        public int NotifikacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Status { get; set; }
        public int? NovostId { get; set; }
        public int KupacId { get; set; }
        public string Naziv { get; set; }
    }
}
