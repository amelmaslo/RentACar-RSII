using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RegistracijeVozilaSearchRequest
    {
        public int? VoziloId { get; set; }
        public int? UposlenikId { get; set; }
        public string RegistarskeOznake { get; set; }

    }
}
