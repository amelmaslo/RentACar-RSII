using Flurl.Util;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.RegistracijeVozila
{
    public partial class frmRegistracijeVozila : Form
    {
        private readonly APIService _registracijeVozilaService = new APIService("RegistracijeVozila");
        private readonly APIService _uposleniciService = new APIService("Korisnici");
        private readonly APIService _vozilaService = new APIService("Vozila");

        public frmRegistracijeVozila()
        {
            InitializeComponent();
        }

        private async void frmRegistracijeVozila_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            await LoadVozila();
        }

        private void dgvRegistracijeVozila_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvRegistracijeVozila.SelectedRows[0].Cells[0].Value.ToString());
            frmRegistracijeVozilaDetalji frm = new frmRegistracijeVozilaDetalji(id);
            frm.ShowDialog();
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RegistracijeVozilaSearchRequest request = new RegistracijeVozilaSearchRequest()
            {
                RegistarskeOznake = txtRegistarskeOznake.Text
            };

            var objUposlenci = cbUposlenik.SelectedValue;
            request.UposlenikId = int.Parse(objUposlenci?.ToString() ?? "0");
            var objVozila = cbVozilo.SelectedValue;
            request.VoziloId = int.Parse(objVozila?.ToString() ?? "0");

            var result = await _registracijeVozilaService.Get<List<Model.RegistracijeVozila>>(request);
            dgvRegistracijeVozila.AutoGenerateColumns = false;
            dgvRegistracijeVozila.DataSource = result;
        }

        private async Task LoadKorisnici()
        {
            var result = await _uposleniciService.Get<List<Model.Korisnici>>(null);
            result.Insert(0, new Model.Korisnici());

            cbUposlenik.DataSource = result;
            cbUposlenik.DisplayMember = "KorisnickoIme";
            cbUposlenik.ValueMember = "KorisnikId";
        }
        private async Task LoadVozila()
        {
            var result = await _vozilaService.Get<List<Model.Vozila>>(null);
            result.Insert(0, new Model.Vozila());

            cbVozilo.DataSource = result;
            cbVozilo.DisplayMember = "Ispis";
            cbVozilo.ValueMember = "VoziloId";
        }

    }
}
   
