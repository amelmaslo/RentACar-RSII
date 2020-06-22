using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            DodatnaOprema = new HashSet<DodatnaOprema>();
            Racuni = new HashSet<Racuni>();
        }

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
        public virtual ICollection<Racuni> Racuni { get; set; }
    }
}
