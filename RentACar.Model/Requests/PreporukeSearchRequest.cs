using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class PreporukeSearchRequest
    {
        public string KorisnickoIme { get; set; }
        public int KategorijaVozilaId { get; set; }
        public int LokacijaPreuzimanjaId { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public DateTime DatumPovrata { get; set; }
    }
}
