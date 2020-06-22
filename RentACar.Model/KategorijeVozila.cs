using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class KategorijeVozila
    {
        public int KategorijaVozilaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
