using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class LokacijeUpsertRequest
    {
        [Required]
        public string Adresa { get; set; }
        [Required]
        public int GradId { get; set; }
    }
}
