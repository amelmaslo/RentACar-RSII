using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Modeli
    {
        public int ModelId { get; set; }
        public string Naziv { get; set; }
        public int ProizvodjacId { get; set; }
        public virtual Proizvodjaci Proizvodjac { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
