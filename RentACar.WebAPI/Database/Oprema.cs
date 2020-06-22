using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Oprema
    {
        public Oprema()
        {
            DodatnaOprema = new HashSet<DodatnaOprema>();
        }

        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<DodatnaOprema> DodatnaOprema { get; set; }
    }
}
