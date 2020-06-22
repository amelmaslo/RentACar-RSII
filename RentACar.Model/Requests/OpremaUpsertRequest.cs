using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class OpremaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        [Required]
        public decimal Cijena { get; set; }
    }
}
