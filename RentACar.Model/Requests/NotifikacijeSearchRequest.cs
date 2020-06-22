using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Requests
{
    public class NotifikacijeSearchRequest
    {
        public bool? Status { get; set; }
        public int? NovostId { get; set; }
        public int? KupacId { get; set; }
    }
}