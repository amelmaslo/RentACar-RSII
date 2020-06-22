using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class RegistracijeVozila
    {
        public int RegistracijaVozilaId { get; set; }
        public int UposlenikId { get; set; }
        public int VoziloId { get; set; }
        public string RegistarskeOznake { get; set; }
        public DateTime PocetakRegistracije { get; set; }
        public DateTime KrajRegistracije { get; set; }
        public decimal Cijena { get; set; }
        public bool Status { get; set; }
        public virtual Korisnici Uposlenik { get; set; }
        public virtual Vozila Vozilo { get; set; }
    }
}
