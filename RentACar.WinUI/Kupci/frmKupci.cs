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

namespace RentACar.WinUI.Kupci
{
    public partial class frmKupci : Form
    {
        private readonly APIService _kupciService = new APIService("Kupci");
        public frmKupci()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KupciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text
            };

            var result = await _kupciService.Get<List<Model.Kupci>>(search);
            dgvKupci.AutoGenerateColumns = false;
            dgvKupci.DataSource = result;
        }

        private void dgvKupci_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var kupc = dgvKupci.SelectedRows[0].DataBoundItem as Model.Kupci;
            frmKupciDetalji frm = new frmKupciDetalji(kupc.KupacId);
            frm.ShowDialog();
        }
    }
}
