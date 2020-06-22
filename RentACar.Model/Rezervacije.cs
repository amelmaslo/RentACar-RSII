using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model
{
    public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public int KupacId { get; set; }
        public int VoziloId { get; set; }
        public int OsiguranjeId { get; set; }
        public int LokacijaPreuzimanjaId { get; set; }
        public int LokacijaPovrataId { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public DateTime DatumPovrata { get; set; }
        public DateTime DatumKreiranjaRezervacij { get; set; }
        public string Napomena { get; set; }
        public decimal? Popust { get; set; }
        public bool Status { get; set; }
        public virtual Kupci Kupac { get; set; }
        public virtual Lokacije LokacijaPovrata { get; set; }
        public virtual Lokacije LokacijaPreuzimanja { get; set; }
        public virtual Osiguranja Osiguranje { get; set; }
        public virtual Vozila Vozilo { get; set; }

        public virtual ICollection<DodatnaOprema> DodatnaOprema { get; set; }
        public string Oprema { get; set; }

        public string Naslov { get{ return $"{Vozilo?.ToString()??"Vozilo"}  -  {DatumKreiranjaRezervacij.ToString("dd.MM.yyyy HH:mm")}"; } }
        public string Opis { get { return $"Preuzimanje: {LokacijaPreuzimanja?.Adresa??""} ({DatumPreuzimanja.ToString("dd.MM.yyyy")})\nPovrat: {LokacijaPovrata?.Adresa??""} ({DatumPovrata.ToString("dd.MM.yyyy")})\nStatus: {(Status?"Aktivna":"Neaktivna")}"; } }
        public byte[] Slika { get { return Vozilo?.Slika??null; } }
    }
}
