using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class NovostiUpsertRequest
    {
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
