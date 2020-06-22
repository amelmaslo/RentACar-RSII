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

namespace RentACar.WinUI.Novosti
{
    public partial class frmNovosti : Form
    {
        private readonly APIService _novostiService = new APIService("Novosti");
        private readonly APIService _korisniciService = new APIService("Korisnici");
        public frmNovosti()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NovostiSearchRequest request = new NovostiSearchRequest()
            {
                Naziv = txtNaziv.Text
            };
            var objKorisnici = cmbKorisnici.SelectedValue;
            request.KorisnikId = int.Parse(objKorisnici?.ToString() ?? "0");

            var result = await _novostiService.Get<List<Model.Novosti>>(request);

            dgvNovosti.AutoGenerateColumns = false;
            dgvNovosti.DataSource = result;
        }

        private async void frmNovosti_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
        }
        private async Task LoadKorisnici()
        {
            var result = await _korisniciService.Get<List<Model.Korisnici>>(null);
            result.Insert(0, new Model.Korisnici());

            cmbKorisnici.DataSource = result;
            cmbKorisnici.DisplayMember = "KorisnickoIme";
            cmbKorisnici.ValueMember = "KorisnikId";
        }

        private void dgvNovosti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvNovosti.SelectedRows[0].Cells[0].Value.ToString());
            frmNovostiDetalji frm = new frmNovostiDetalji(id);
            frm.ShowDialog();
        }
    }
}
