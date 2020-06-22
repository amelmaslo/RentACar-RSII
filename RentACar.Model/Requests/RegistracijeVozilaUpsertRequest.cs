using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class RegistracijeVozilaUpsertRequest
    {
        [Required]
        public int UposlenikId { get; set; }
        [Required]
        public int VoziloId { get; set; }
        [Required]
        public string RegistarskeOznake { get; set; }
        [Required]
        public DateTime PocetakRegistracije { get; set; }
        [Required]
        public DateTime KrajRegistracije { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
