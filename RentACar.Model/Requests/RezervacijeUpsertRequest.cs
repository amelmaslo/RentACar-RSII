using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        [Required]
        public int KupacId { get; set; }
        [Required]
        public int VoziloId { get; set; }
        [Required]
        public int OsiguranjeId { get; set; }
        [Required]
        public int LokacijaPreuzimanjaId { get; set; }
        [Required]
        public int LokacijaPovrataId { get; set; }
        [Required]
        public DateTime DatumPreuzimanja { get; set; }
        [Required]
        public DateTime DatumPovrata { get; set; }
        [Required]
        public DateTime DatumKreiranjaRezervacij { get; set; }
        public string Napomena { get; set; }
        public decimal? Popust { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual List<int> Oprema { get; set; } = new List<int>();
        public int? KategorijaVozilaId { get; set; } = null;
    }
}
