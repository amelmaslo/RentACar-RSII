using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RacuniUpsertRequest
    {
        [Required]
        public int RezervacijaId { get; set; }
        [Required]
        public string BrojRacuna { get; set; }
        [Required]
        public decimal IznajmljivanjeVozila { get; set; }
        [Required]
        public decimal OpremaUkupno { get; set; }
        [Required]
        public decimal OsiguranjeUkupno { get; set; }
        public decimal? Popust { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public decimal Pdv { get; set; }
        [Required]
        public decimal IznosBezPdv { get; set; }
        [Required]
        public decimal IznosSaPdv { get; set; }
        [Required]
        public int BrojDana { get; set; }
        [Required]
        public byte[] QRCode { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}
