using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class NotifikacijeUpsertRequest
    {
        [Required]
        public DateTime DatumSlanja { get; set; }
        [Required]
        public bool Status { get; set; }
        public int? NovostId { get; set; }
        [Required]
        public int KupacId { get; set; }
        [Required]
        public string Naziv { get; set; }
    }
}
