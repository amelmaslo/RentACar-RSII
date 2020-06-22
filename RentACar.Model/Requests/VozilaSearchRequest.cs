using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class VozilaSearchRequest
    {
        public int? ModelId { get; set; }
        public int? KategorijaVozilaId { get; set; }
        public int? LokacijaId { get; set; }
        public string BrojSasije { get; set; }
    }
}
