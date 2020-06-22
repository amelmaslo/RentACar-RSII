using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class PretplateUpsertRequest
    {
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int KupacId { get; set; }
        [Required]
        public int KategorijaVozilaId { get; set; }
    }
}
