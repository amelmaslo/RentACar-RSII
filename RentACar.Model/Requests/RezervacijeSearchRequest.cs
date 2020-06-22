using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public string Vozilo { get; set; }
        public string KorisnickoIme { get; set; }
        public int? LokacijaPreuzimanjaId { get; set; }
        public int? LokacijaPovrataId { get; set; }
        public bool? Status { get; set; }
    }
}
