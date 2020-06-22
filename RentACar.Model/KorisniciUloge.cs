﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public Uloge Uloga { get; set; }
    }
}