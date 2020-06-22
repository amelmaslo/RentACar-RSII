using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Pretplate
    {
        public int PretplataId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public int KupacId { get; set; }
        public int KategorijaVozilaId { get; set; }

        public virtual KategorijeVozila KategorijaVozila { get; set; }
        public virtual Kupci Kupac { get; set; }
    }
}
