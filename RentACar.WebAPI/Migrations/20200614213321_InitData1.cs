using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.WebAPI.Migrations
{
    public partial class InitData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Srbija" },
                    { 3, "Hrvatska" },
                    { 4, "Slovenija" }
                });

            migrationBuilder.InsertData(
                table: "KategorijeVozila",
                columns: new[] { "KategorijaVozilaID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "A", "Motocikl sa ili bez bočne prikolice čija zapremina prelazi 125 cm3, a snaga 11 kw" },
                    { 2, "B", "Motorna vozila, osim vozila kategorije A, čija najveća dozvoljena masa nije veća od 3,5 t i koji nemaju više od 8 sjedišta ne računajući sjedište vozača." },
                    { 3, "C", "Motorna vozila čija je najveća dozvoljena masa veća od 7,5 t." },
                    { 4, "D", "Motorna vozila za prijevoz osoba, koja, osim sjedišta za vozača, imaju više od 8 sjedišta. (Uslov 2 godine posjedovanje vozačke dozvole)" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status", "Telefon" },
                values: new object[,]
                {
                    { 1, "admin@edu.fit.ba", "Admin", "desktop", "HzoOkNHGE27Bfhd/8f1uxeQRCOM=", "rHh+zm55r5AYhYbSovWIwA==", "Admin", true, "+387 61 000 000" },
                    { 2, "radnik@edu.fit.ba", "Radnik", "radnik", "HzoOkNHGE27Bfhd/8f1uxeQRCOM=", "rHh+zm55r5AYhYbSovWIwA==", "Radnik", true, "+387 61 111 1111" }
                });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "KupacID", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status", "Telefon" },
                values: new object[] { 1, new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local), "kupac@edu.fit.ba", "Kupac", "mobile", "HzoOkNHGE27Bfhd/8f1uxeQRCOM=", "rHh+zm55r5AYhYbSovWIwA==", "Kupac", true, "+387 61 222 222" });

            migrationBuilder.InsertData(
                table: "Oprema",
                columns: new[] { "OpremaID", "Cijena", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 3, 50m, "Dodatni vozač", null },
                    { 1, 10m, "Dječija sjedalica", "Za djecu od 0 - 3 god." },
                    { 2, 10m, "GPS-navigacija", null }
                });

            migrationBuilder.InsertData(
                table: "Osiguranja",
                columns: new[] { "OsiguranjeID", "Cijena", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, 0m, "Basic", "Zaštita od krađe i osnovna zaštita od oštećenja od sudara." },
                    { 2, 11m, "Medium", "Srednja vrsta osiguranja." },
                    { 3, 19m, "Premium", "Puni kasko paket u potpunosti vas oslobađa financijske odgovornosti u slučaju financijske odgovornosti." }
                });

            migrationBuilder.InsertData(
                table: "Proizvodjaci",
                columns: new[] { "ProizvodjacID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Volkswagen" },
                    { 2, "Audi" },
                    { 3, "Mercedes-Benz" },
                    { 4, "BMW" },
                    { 5, "Opel" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Administrator", null },
                    { 2, "Radnik", null }
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, 1, "Mostar" },
                    { 2, 1, "Sarajevo" },
                    { 3, 2, "Beograd" },
                    { 4, 3, "Zagreb" },
                    { 5, 4, "Ljubljana" }
                });

            migrationBuilder.InsertData(
                table: "Lokacije",
                columns: new[] { "LokacijaID", "Adresa", "GradID" },
                values: new object[,]
                {
                    { 1, "Maršala Tita 169", 1 },
                    { 2, "Bulevar Meše Selimovića bb", 2 },
                    { 3, "Milentija Popovića 9", 3 },
                    { 4, "Ul.Radoslava Cimermana 64A", 4 },
                    { 5, "Trg Osvobodilne fronte 6", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KategorijeVozila",
                keyColumn: "KategorijaVozilaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KategorijeVozila",
                keyColumn: "KategorijaVozilaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KategorijeVozila",
                keyColumn: "KategorijaVozilaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KategorijeVozila",
                keyColumn: "KategorijaVozilaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lokacije",
                keyColumn: "LokacijaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lokacije",
                keyColumn: "LokacijaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lokacije",
                keyColumn: "LokacijaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lokacije",
                keyColumn: "LokacijaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lokacije",
                keyColumn: "LokacijaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Oprema",
                keyColumn: "OpremaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oprema",
                keyColumn: "OpremaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oprema",
                keyColumn: "OpremaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Osiguranja",
                keyColumn: "OsiguranjeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Osiguranja",
                keyColumn: "OsiguranjeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Osiguranja",
                keyColumn: "OsiguranjeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "DrzavaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "DrzavaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "DrzavaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "DrzavaID",
                keyValue: 4);
        }
    }
}
