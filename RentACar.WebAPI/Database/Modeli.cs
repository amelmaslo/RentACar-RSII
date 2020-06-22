using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Modeli
    {
        public Modeli()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int ModelId { get; set; }
        public string Naziv { get; set; }
        public int ProizvodjacId { get; set; }

        public virtual Proizvodjaci Proizvodjac { get; set; }
        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
