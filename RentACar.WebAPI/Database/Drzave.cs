using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Drzave
    {
        public Drzave()
        {
            Gradovi = new HashSet<Gradovi>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Gradovi> Gradovi { get; set; }
    }
}
