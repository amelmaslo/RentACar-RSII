using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Racuni
    {
        public int RacunId { get; set; }
        public int RezervacijaId { get; set; }
        public decimal IznajmljivanjeVozila { get; set; }
        public string BrojRacuna { get; set; }
        public decimal OpremaUkupno { get; set; }
        public decimal OsiguranjeUkupno { get; set; }
        public decimal? Popust { get; set; }
        public DateTime Datum { get; set; }
        public decimal Pdv { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int BrojDana { get; set; }
        public byte[] QRCode { get; set; }
        public bool Status { get; set; }
        public virtual Rezervacije Rezervacija { get; set; }
    }
}
