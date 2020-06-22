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

namespace RentACar.WinUI.Osiguranja
{
    public partial class frmOsiguranja : Form
    {
        private readonly APIService _osiguranjaService = new APIService("Osiguranja");
        private int? _id;
        public frmOsiguranja(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmOsiguranja_Load(object sender, EventArgs e)
        {
            var result = await _osiguranjaService.Get<List<Model.Osiguranja>>(null);
            dgvOsiguranja.AutoGenerateColumns = false;
            dgvOsiguranja.DataSource = result;
        }

        private void dgvOsiguranja_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvOsiguranja.SelectedRows[0].DataBoundItem as Model.Osiguranja;
            _id = result.OsiguranjeId;
            txtNaziv.Text = result.Naziv;
            txtOpis.Text = result.Opis;
            numCijena.Text = result.Cijena.ToString();
            btnDodaj.Text = "Uredi";
        }


        private async Task LoadOsiguranja()
        {
            _id = null;
            txtNaziv.Text = string.Empty;
            txtOpis.Text = string.Empty;
            numCijena.Text = "0".ToString();
            btnDodaj.Text = "Dodaj";
            var list = await _osiguranjaService.Get<List<Model.Osiguranja>>(null);
            dgvOsiguranja.AutoGenerateColumns = false;
            dgvOsiguranja.DataSource = list;
        }

        private async void pbRefesh_Click(object sender, EventArgs e)
        {
            await LoadOsiguranja();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new OsiguranjaUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Cijena = numCijena.Value
                };

                Model.Osiguranja entity = null;
                if (_id.HasValue)
                    entity = await _osiguranjaService.Update<Model.Osiguranja>(_id.Value, request);
                else
                    entity = await _osiguranjaService.Insert<Model.Osiguranja>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");

                await LoadOsiguranja();
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
