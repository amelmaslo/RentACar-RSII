using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Model.Requests
{
    public class VozilaUpsertRequest
    {
        [Required]
        public int ModelId { get; set; }
        [Required]
        public int KategorijaVozilaId { get; set; }
        [Required]
        public int LokacijaId { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public int GodinaProizvodnje { get; set; }
        [Required]
        public string Gorivo { get; set; }
        [Required]
        public string Snaga { get; set; }
        [Required]
        public string Transmisija { get; set; }
        [Required]
        public int BrojVrata { get; set; }
        [Required]
        public int BrojSjedista { get; set; }
        [Required]
        public string BrojSasije { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public byte[] SlikaThumb { get; set; }

    }
}
