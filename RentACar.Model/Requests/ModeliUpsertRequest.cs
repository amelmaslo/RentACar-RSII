using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class ModeliUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int ProizvodjacId { get; set; }
    }
}
