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

namespace RentACar.WinUI.Pretplate
{
    public partial class frmPretplate : Form
    {
        private readonly APIService _pretplateService = new APIService("Pretplate");
        private readonly APIService _kategorijeVozilaService = new APIService("KategorijeVozila");
        public frmPretplate()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            PretplateSearchRequest request = new PretplateSearchRequest()
            {
                KorisnickoIme = txtKupac.Text
            };
            var objKategorijeVozila = cmbKategorijeVozila.SelectedValue;
            request.KategorijaVozilaId = int.Parse(objKategorijeVozila?.ToString() ?? "0");

            var result = await _pretplateService.Get<List<Model.Pretplate>>(request);

            dgvPretplate.AutoGenerateColumns = false;
            dgvPretplate.DataSource = result;
        }

        private async void frmPretplate_Load(object sender, EventArgs e)
        {
            await LoadKategorijeVozila();
        }
        private async Task LoadKategorijeVozila()
        {
            var result = await _kategorijeVozilaService.Get<List<Model.KategorijeVozila>>(null);
            result.Insert(0, new Model.KategorijeVozila());

            cmbKategorijeVozila.DataSource = result;
            cmbKategorijeVozila.DisplayMember = "Naziv";
            cmbKategorijeVozila.ValueMember = "KategorijaVozilaId";
        }

        private void dgvPretplate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvPretplate.SelectedRows[0].Cells[0].Value.ToString());
            frmPretplateDetalji frm = new frmPretplateDetalji(id);
            frm.ShowDialog();
        }
    }
}