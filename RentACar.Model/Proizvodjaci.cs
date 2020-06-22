using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Proizvodjaci
    {
        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
