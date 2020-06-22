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

namespace RentACar.WinUI.Modeli
{
    public partial class frmModeli : Form
    {
        private readonly APIService _modeliService = new APIService("Modeli");
        private readonly APIService _proizvodjaciService = new APIService("Proizvodjaci");
        private int? _id = null;
        public frmModeli(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmModeli_Load(object sender, EventArgs e)
        {
            await LoadProizvodjaci();

            var result = await _modeliService.Get<List<Model.Modeli>>(null);
            dgvModeli.AutoGenerateColumns = false;
            dgvModeli.DataSource = result;
        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>(null);
            result.Insert(0, new Model.Proizvodjaci());

            cbProizvodjac.DisplayMember = "Naziv";
            cbProizvodjac.ValueMember = "ProizvodjacId";
            cbProizvodjac.DataSource = result;
        }

        private async Task LoadProizvodjaci(int id)
        {
            var result = await _modeliService.Get<List<Model.Modeli>>(new ModeliSearchRequest() { ProizvodjacId = id });
            dgvModeli.AutoGenerateColumns = false;
            dgvModeli.DataSource = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            _id = null;
            btnDodaj.Text = "Dodaj";
            txtNaziv.Text = string.Empty;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && cbProizvodjac_Validating())
            {
                var request = new ModeliUpsertRequest()
                {
                    ProizvodjacId = int.Parse(cbProizvodjac.SelectedValue.ToString()),
                    Naziv = txtNaziv.Text
                };

                Model.Modeli entity = null;

                if (_id.HasValue)
                    entity = await _modeliService.Update<Model.Modeli>(_id.Value, request);
                else
                    entity = await _modeliService.Insert<Model.Modeli>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");
                await LoadProizvodjaci(request.ProizvodjacId);

                Reload();
            }
        }

        private async void cbProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(cbProizvodjac.SelectedValue.ToString());
            await LoadProizvodjaci(id);
        }

        private void dgvModeli_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvModeli.SelectedRows[0].DataBoundItem as Model.Modeli;
            txtNaziv.Text = result.Naziv;
            _id = result.ModelId;
            btnDodaj.Text = "Uredi";
            cbProizvodjac.SelectedValue = result.ProizvodjacId;
        }

        private bool cbProizvodjac_Validating()
        {
            if (cbProizvodjac.SelectedIndex == 0)
            {
                errorProvider.SetError(cbProizvodjac, Properties.Resources.ObaveznoPolje);
                return false;
            }
            else
            {
                errorProvider.SetError(cbProizvodjac, null);
            }
            return true;
        }


        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);

        }
    }
}
