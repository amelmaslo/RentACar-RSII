using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class NovostiSearchRequest
    {
        public string Naziv { get; set; }
        public int? KorisnikId { get; set; }
    }
}
