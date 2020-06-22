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

namespace RentACar.WinUI.Racuni
{
    public partial class frmRacuni : Form
    {
        private readonly APIService _racuniService = new APIService("Racuni");
        public frmRacuni()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RacuniSearchRequest request = new RacuniSearchRequest() {
                Vozilo = txtVozilo.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                BrojRacuna = txtBrojRacuna.Text
            };
            var result = await _racuniService.Get<List<Model.Racuni>>(request);

            dgvRacuni.AutoGenerateColumns = false;
            dgvRacuni.DataSource = result;
        }

        private void dgvRacuni_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvRacuni.SelectedRows[0].Cells[0].Value.ToString());
            frmRacuniDetalji frm = new frmRacuniDetalji(id);
            frm.ShowDialog();
        }
    }
}
