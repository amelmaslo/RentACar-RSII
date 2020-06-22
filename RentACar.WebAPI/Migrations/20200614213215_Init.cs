using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "KategorijeVozila",
                columns: table => new
                {
                    KategorijaVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijeVozila", x => x.KategorijaVozilaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacID);
                });

            migrationBuilder.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    OpremaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.OpremaID);
                });

            migrationBuilder.CreateTable(
                name: "Osiguranja",
                columns: table => new
                {
                    OsiguranjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osiguranja", x => x.OsiguranjeID);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    ProizvodjacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.ProizvodjacID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostID);
                    table.ForeignKey(
                        name: "FK_Novosti_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pretplate",
                columns: table => new
                {
                    PretplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    KategorijaVozilaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplate", x => x.PretplataID);
                    table.ForeignKey(
                        name: "FK_Preplate_KategorijeVozila",
                        column: x => x.KategorijaVozilaID,
                        principalTable: "KategorijeVozila",
                        principalColumn: "KategorijaVozilaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Preplate_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modeli",
                columns: table => new
                {
                    ModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    ProizvodjacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeli", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Modeli_Proizvodjaci",
                        column: x => x.ProizvodjacID,
                        principalTable: "Proizvodjaci",
                        principalColumn: "ProizvodjacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lokacije",
                columns: table => new
                {
                    LokacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(maxLength: 50, nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacije", x => x.LokacijaID);
                    table.ForeignKey(
                        name: "FK_Lokacije_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    NotifikacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumSlanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    NovostID = table.Column<int>(nullable: true),
                    KupacID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => x.NotifikacijaID);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Novosti",
                        column: x => x.NovostID,
                        principalTable: "Novosti",
                        principalColumn: "NovostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelID = table.Column<int>(nullable: false),
                    KategorijaVozilaID = table.Column<int>(nullable: false),
                    LokacijaID = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GodinaProizvodnje = table.Column<int>(nullable: false),
                    Gorivo = table.Column<string>(maxLength: 20, nullable: false),
                    Snaga = table.Column<string>(maxLength: 20, nullable: false),
                    Transmisija = table.Column<string>(maxLength: 20, nullable: false),
                    BrojVrata = table.Column<int>(nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    BrojSasije = table.Column<string>(maxLength: 20, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.VoziloID);
                    table.ForeignKey(
                        name: "FK_Vozila_KategorijeVozila",
                        column: x => x.KategorijaVozilaID,
                        principalTable: "KategorijeVozila",
                        principalColumn: "KategorijaVozilaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozila_Lokacije",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozila_Modeli",
                        column: x => x.ModelID,
                        principalTable: "Modeli",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoziloID = table.Column<int>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ocjene_Vozila",
                        column: x => x.VoziloID,
                        principalTable: "Vozila",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistracijeVozila",
                columns: table => new
                {
                    RegistracijaVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikID = table.Column<int>(nullable: false),
                    VoziloID = table.Column<int>(nullable: false),
                    RegistarskeOznake = table.Column<string>(maxLength: 20, nullable: false),
                    PocetakRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    KrajRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistracijeVozila", x => x.RegistracijaVozilaID);
                    table.ForeignKey(
                        name: "FK_RegistracijeVozila_Korisnici",
                        column: x => x.UposlenikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistracijeVozila_Vozila",
                        column: x => x.VoziloID,
                        principalTable: "Vozila",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacID = table.Column<int>(nullable: false),
                    VoziloID = table.Column<int>(nullable: false),
                    OsiguranjeID = table.Column<int>(nullable: false),
                    LokacijaPreuzimanjaID = table.Column<int>(nullable: false),
                    LokacijaPovrataID = table.Column<int>(nullable: false),
                    DatumPreuzimanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumPovrata = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumKreiranjaRezervacij = table.Column<DateTime>(type: "datetime", nullable: false),
                    Napomena = table.Column<string>(maxLength: 200, nullable: true),
                    Popust = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_LokacijePovrata",
                        column: x => x.LokacijaPovrataID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_LokacijePreuzimanja",
                        column: x => x.LokacijaPreuzimanjaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Osiguranja",
                        column: x => x.OsiguranjeID,
                        principalTable: "Osiguranja",
                        principalColumn: "OsiguranjeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Vozila",
                        column: x => x.VoziloID,
                        principalTable: "Vozila",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DodatnaOprema",
                columns: table => new
                {
                    DodatnaOpremaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    OpremaID = table.Column<int>(nullable: false),
                    RezervacijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatnaOprema", x => x.DodatnaOpremaID);
                    table.ForeignKey(
                        name: "FK_DodatnaOprema_Oprema",
                        column: x => x.OpremaID,
                        principalTable: "Oprema",
                        principalColumn: "OpremaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DodatnaOprema_Rezervacije",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racuni",
                columns: table => new
                {
                    RacunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaID = table.Column<int>(nullable: false),
                    IznajmljivanjeVozila = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BrojRacuna = table.Column<string>(maxLength: 100, nullable: false),
                    OpremaUkupno = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OsiguranjeUkupno = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Popust = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    PDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IznosBezPDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IznosSaPDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BrojDana = table.Column<int>(nullable: false),
                    QRCode = table.Column<byte[]>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racuni", x => x.RacunID);
                    table.ForeignKey(
                        name: "FK_Racuni_Rezervacije",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DodatnaOprema_OpremaID",
                table: "DodatnaOprema",
                column: "OpremaID");

            migrationBuilder.CreateIndex(
                name: "IX_DodatnaOprema_RezervacijaID",
                table: "DodatnaOprema",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "Korisnici_Email",
                table: "Korisnici",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "Korisnici_KorisnickoIme",
                table: "Korisnici",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "Kupci_Email",
                table: "Kupci",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Kupci_KorisnickoIme",
                table: "Kupci",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lokacije_GradID",
                table: "Lokacije",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Modeli_ProizvodjacID",
                table: "Modeli",
                column: "ProizvodjacID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_KupacID",
                table: "Notifikacije",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_NovostID",
                table: "Notifikacije",
                column: "NovostID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_KorisnikID",
                table: "Novosti",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacID",
                table: "Ocjene",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_VoziloID",
                table: "Ocjene",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_KategorijaVozilaID",
                table: "Pretplate",
                column: "KategorijaVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_KupacID",
                table: "Pretplate",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "Racuni_BrojRacuna",
                table: "Racuni",
                column: "BrojRacuna",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_RezervacijaID",
                table: "Racuni",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistracijeVozila_UposlenikID",
                table: "RegistracijeVozila",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistracijeVozila_VoziloID",
                table: "RegistracijeVozila",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KupacID",
                table: "Rezervacije",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_LokacijaPovrataID",
                table: "Rezervacije",
                column: "LokacijaPovrataID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_LokacijaPreuzimanjaID",
                table: "Rezervacije",
                column: "LokacijaPreuzimanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_OsiguranjeID",
                table: "Rezervacije",
                column: "OsiguranjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_VoziloID",
                table: "Rezervacije",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_KategorijaVozilaID",
                table: "Vozila",
                column: "KategorijaVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_LokacijaID",
                table: "Vozila",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_ModelID",
                table: "Vozila",
                column: "ModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DodatnaOprema");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Pretplate");

            migrationBuilder.DropTable(
                name: "Racuni");

            migrationBuilder.DropTable(
                name: "RegistracijeVozila");

            migrationBuilder.DropTable(
                name: "Oprema");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Osiguranja");

            migrationBuilder.DropTable(
                name: "Vozila");

            migrationBuilder.DropTable(
                name: "KategorijeVozila");

            migrationBuilder.DropTable(
                name: "Lokacije");

            migrationBuilder.DropTable(
                name: "Modeli");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
