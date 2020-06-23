using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using RentACar.Model.Requests;

namespace RentACar.WinUI.Izvjestaji
{
    public partial class frmIzvjestajiDetalji : Form
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _racuniService = new APIService("Racuni");


        int id;
        public frmIzvjestajiDetalji(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmIzvjestajiDetalji_Load(object sender, EventArgs e)
        {
            var vozilo = await _vozilaService.GetById<Model.Vozila>(id);
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("nazivVozila", vozilo.Model.Naziv + " (" + vozilo.BrojSasije +")"));
            rpc.Add(new ReportParameter("datumIzdavanja", DateTime.Now.ToString("dd.MM.yyyy HH:mm")));

            var rezervacijeList = await _rezervacijeService.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest() { Vozilo = vozilo.Model.Naziv });

            int brojRezervacija = 0;
            double ukupanIznos = 0;
            dsVozila.tblVozilaDataTable tbl = new dsVozila.tblVozilaDataTable();
            foreach (var rezevacija in rezervacijeList)
            {
                if (rezevacija.Status == true)
                {
                    brojRezervacija++;
                    dsVozila.tblVozilaRow row = tbl.NewtblVozilaRow();
                    row.Kupac = rezevacija.Kupac.Ime + " " + rezevacija.Kupac.Prezime;
                    row.LokacijaPreuzimanja = rezevacija.LokacijaPreuzimanja.Adresa;
                    row.DatumPreuzimanja = rezevacija.DatumPreuzimanja.ToString("dd.MM.yyyy");
                    row.DatumPovrata = rezevacija.DatumPovrata.ToString("dd.MM.yyyy");
                    row.Iznos = " ";
                    
                    var racuniList = await _racuniService.Get<List<Model.Racuni>>(new RacuniSearchRequest() { RezervacijaId = rezevacija.RezervacijaId });
                    foreach (var racun in racuniList)
                    {
                        if (racun.Status)
                        {
                            row.Iznos = racun.IznosSaPdv + " €";
                            ukupanIznos += (double)racun.IznosSaPdv;
                        }
                    }
                    tbl.Rows.Add(row);
                }
            }
            rpc.Add(new ReportParameter("brojRezervacija", brojRezervacija.ToString()));
            rpc.Add(new ReportParameter("ukupanIznos", ukupanIznos.ToString() + "€"));


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Vozila";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
