using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class OcjeneUpsertRequest
    {
        public int VoziloId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}
