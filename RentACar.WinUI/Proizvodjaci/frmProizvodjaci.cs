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

namespace RentACar.WinUI.Proizvodjaci
{
    public partial class frmProizvodjaci : Form
    {
        private readonly APIService _proizvodjaciService = new APIService("Proizvodjaci");
        private int? _id;
        public frmProizvodjaci(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmProizvodjaci_Load(object sender, EventArgs e)
        {
            var result = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>(null);
            dgvProizvodjaci.AutoGenerateColumns = false;
            dgvProizvodjaci.DataSource = result;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new ProizvodjaciUpsertRequest()
                {
                    Naziv = txtNaziv.Text
                };

                Model.Proizvodjaci entity = null;
                if (_id.HasValue)
                    entity = await _proizvodjaciService.Update<Model.Proizvodjaci>(_id.Value, request);
                else
                    entity = await _proizvodjaciService.Insert<Model.Proizvodjaci>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");

                await ProizvodjaciLoad();
            }
        }

        private async Task ProizvodjaciLoad()
        {
            _id = null;
            btnDodaj.Text = "Dodaj";
            txtNaziv.Text = string.Empty;
            var list = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>(null);
            dgvProizvodjaci.AutoGenerateColumns = false;
            dgvProizvodjaci.DataSource = list;
        }

        private void dgvProizvodjaci_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvProizvodjaci.SelectedRows[0].DataBoundItem as Model.Proizvodjaci;
            _id = result.ProizvodjacId;
            txtNaziv.Text = result.Naziv;
            btnDodaj.Text = "Uredi";
        }

        private async void pbRefesh_Click(object sender, EventArgs e)
        {
            await ProizvodjaciLoad();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
