using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentACar.WebAPI.Database
{
    public partial class RentACarContext : DbContext
    {
        public RentACarContext()
        {
        }

        public RentACarContext(DbContextOptions<RentACarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DodatnaOprema> DodatnaOprema { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<KategorijeVozila> KategorijeVozila { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<Lokacije> Lokacije { get; set; }
        public virtual DbSet<Modeli> Modeli { get; set; }
        public virtual DbSet<Notifikacije> Notifikacije { get; set; }
        public virtual DbSet<Novosti> Novosti { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Oprema> Oprema { get; set; }
        public virtual DbSet<Osiguranja> Osiguranja { get; set; }
        public virtual DbSet<Pretplate> Pretplate { get; set; }
        public virtual DbSet<Proizvodjaci> Proizvodjaci { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<RegistracijeVozila> RegistracijeVozila { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Vozila> Vozila { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=RentACar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DodatnaOprema>(entity =>
            {
                entity.Property(e => e.DodatnaOpremaId).HasColumnName("DodatnaOpremaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Oprema)
                    .WithMany(p => p.DodatnaOprema)
                    .HasForeignKey(d => d.OpremaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DodatnaOprema_Oprema");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.DodatnaOprema)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DodatnaOprema_Rezervacije");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gradovi_Drzave");
            });

            modelBuilder.Entity<KategorijeVozila>(entity =>
            {
                entity.HasKey(e => e.KategorijaVozilaId);

                entity.Property(e => e.KategorijaVozilaId).HasColumnName("KategorijaVozilaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.HasIndex(e => e.Email)
                    .HasName("Korisnici_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("Korisnici_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(500);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Uloge");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.HasIndex(e => e.Email)
                    .HasName("Kupci_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("Kupci_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Lokacije>(entity =>
            {
                entity.HasKey(e => e.LokacijaId);

                entity.Property(e => e.LokacijaId).HasColumnName("LokacijaID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Lokacije)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lokacije_Gradovi");
            });

            modelBuilder.Entity<Modeli>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProizvodjacId).HasColumnName("ProizvodjacID");

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Modeli)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modeli_Proizvodjaci");
            });

            modelBuilder.Entity<Notifikacije>(entity =>
            {
                entity.HasKey(e => e.NotifikacijaId);

                entity.Property(e => e.NotifikacijaId).HasColumnName("NotifikacijaID");

                entity.Property(e => e.DatumSlanja).HasColumnType("datetime");
               
                entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(250);

                entity.Property(e => e.NovostId).HasColumnName("NovostID");

                entity.HasOne(d => d.Novost)
                   .WithMany(p => p.Notifikacije)
                   .HasForeignKey(d => d.NovostId)
                   .HasConstraintName("FK_Notifikacije_Novosti");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Notifikacije)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifikacije_Kupci");
            });

            modelBuilder.Entity<Novosti>(entity =>
            {
                entity.HasKey(e => e.NovostId);

                entity.Property(e => e.NovostId).HasColumnName("NovostID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).IsRequired();

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Novosti)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novosti_Korisnici");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Kupci");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Vozila");
            });

            modelBuilder.Entity<Oprema>(entity =>
            {
                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Osiguranja>(entity =>
            {
                entity.HasKey(e => e.OsiguranjeId);

                entity.Property(e => e.OsiguranjeId).HasColumnName("OsiguranjeID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Pretplate>(entity =>
            {
                entity.HasKey(e => e.PretplataId);

                entity.Property(e => e.PretplataId).HasColumnName("PretplataID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KategorijaVozilaId).HasColumnName("KategorijaVozilaID");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.HasOne(d => d.KategorijaVozila)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.KategorijaVozilaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preplate_KategorijeVozila");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preplate_Kupci");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.HasKey(e => e.ProizvodjacId);

                entity.Property(e => e.ProizvodjacId).HasColumnName("ProizvodjacID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Racuni>(entity =>
            {
                entity.HasKey(e => e.RacunId);

                entity.HasIndex(e => e.BrojRacuna)
                    .HasName("Racuni_BrojRacuna")
                    .IsUnique();

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.IznajmljivanjeVozila).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosBezPdv)
                    .HasColumnName("IznosBezPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosSaPdv)
                    .HasColumnName("IznosSaPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpremaUkupno).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OsiguranjeUkupno).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pdv)
                    .HasColumnName("PDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Popust).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.QRCode)
                    .IsRequired()
                    .HasColumnName("QRCode");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Racuni)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racuni_Rezervacije");
            });

            modelBuilder.Entity<RegistracijeVozila>(entity =>
            {
                entity.HasKey(e => e.RegistracijaVozilaId);

                entity.Property(e => e.RegistracijaVozilaId).HasColumnName("RegistracijaVozilaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajRegistracije).HasColumnType("datetime");

                entity.Property(e => e.PocetakRegistracije).HasColumnType("datetime");

                entity.Property(e => e.RegistarskeOznake)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UposlenikId).HasColumnName("UposlenikID");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.RegistracijeVozila)
                    .HasForeignKey(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistracijeVozila_Korisnici");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.RegistracijeVozila)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistracijeVozila_Vozila");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumKreiranjaRezervacij).HasColumnType("datetime");

                entity.Property(e => e.DatumPovrata).HasColumnType("datetime");

                entity.Property(e => e.DatumPreuzimanja).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.LokacijaPovrataId).HasColumnName("LokacijaPovrataID");

                entity.Property(e => e.LokacijaPreuzimanjaId).HasColumnName("LokacijaPreuzimanjaID");

                entity.Property(e => e.Napomena).HasMaxLength(200);

                entity.Property(e => e.OsiguranjeId).HasColumnName("OsiguranjeID");

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Kupci");

                entity.HasOne(d => d.LokacijaPovrata)
                    .WithMany(p => p.RezervacijeLokacijaPovrata)
                    .HasForeignKey(d => d.LokacijaPovrataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_LokacijePovrata");

                entity.HasOne(d => d.LokacijaPreuzimanja)
                    .WithMany(p => p.RezervacijeLokacijaPreuzimanja)
                    .HasForeignKey(d => d.LokacijaPreuzimanjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_LokacijePreuzimanja");

                entity.HasOne(d => d.Osiguranje)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.OsiguranjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Osiguranja");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Vozila");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Vozila>(entity =>
            {
                entity.HasKey(e => e.VoziloId);

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.Property(e => e.BrojSasije)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gorivo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KategorijaVozilaId).HasColumnName("KategorijaVozilaID");

                entity.Property(e => e.LokacijaId).HasColumnName("LokacijaID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Snaga)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Transmisija)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.KategorijaVozila)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.KategorijaVozilaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_KategorijeVozila");

                entity.HasOne(d => d.Lokacija)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.LokacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Lokacije");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Modeli");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
