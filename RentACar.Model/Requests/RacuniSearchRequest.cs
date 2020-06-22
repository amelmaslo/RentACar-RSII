using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RacuniSearchRequest
    {
        public string Vozilo { get; set; }
        public string KorisnickoIme { get; set; }
        public string BrojRacuna { get; set; }
        public bool? Status { get; set; }
        public int? RezervacijaId { get; set; }

    }
}
