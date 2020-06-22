using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class KupciUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public DateTime DatumRegistracije { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
