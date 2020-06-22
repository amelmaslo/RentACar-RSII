using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class PretplateSearchRequest
    {
        public string KorisnickoIme { get; set; }
        public int? KategorijaVozilaId { get; set; }
        public int? KupacId { get; set; }
    }
}
