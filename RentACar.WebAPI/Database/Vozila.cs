using System;
using System.Collections.Generic;

namespace RentACar.WebAPI.Database
{
    public partial class Vozila
    {
        public Vozila()
        {
            Ocjene = new HashSet<Ocjene>();
            RegistracijeVozila = new HashSet<RegistracijeVozila>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int VoziloId { get; set; }
        public int ModelId { get; set; }
        public int KategorijaVozilaId { get; set; }
        public int LokacijaId { get; set; }
        public decimal Cijena { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Gorivo { get; set; }
        public string Snaga {get; set; }
        public string Transmisija { get; set; }
        public int BrojVrata { get; set; }
        public int BrojSjedista { get; set; }
        public string BrojSasije { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public virtual KategorijeVozila KategorijaVozila { get; set; }
        public virtual Lokacije Lokacija { get; set; }
        public virtual Modeli Model { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        public virtual ICollection<RegistracijeVozila> RegistracijeVozila { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
