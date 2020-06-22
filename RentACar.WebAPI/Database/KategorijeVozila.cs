using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class KategorijeVozila
    {
        public KategorijeVozila()
        {
            Vozila = new HashSet<Vozila>();
            Pretplate = new HashSet<Pretplate>();
        }

        public int KategorijaVozilaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
        public virtual ICollection<Pretplate> Pretplate { get; set; }
    }
}
