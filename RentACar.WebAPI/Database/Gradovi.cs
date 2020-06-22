using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Lokacije = new HashSet<Lokacije>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzave Drzava { get; set; }
        public virtual ICollection<Lokacije> Lokacije { get; set; }
    }
}
