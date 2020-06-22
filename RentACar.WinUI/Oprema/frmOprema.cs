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

namespace RentACar.WinUI.Oprema
{
    public partial class frmOprema : Form
    {
        private readonly APIService _opremaService = new APIService("Oprema");
        private int? _id;
        public frmOprema(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void dgvOprema_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvOprema.SelectedRows[0].DataBoundItem as Model.Oprema;
            _id = result.OpremaId;
            txtNaziv.Text = result.Naziv;
            txtOpis.Text = result.Opis;
            numCijena.Text = result.Cijena.ToString();
            btnDodaj.Text = "Uredi";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new OpremaUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Cijena = numCijena.Value
                };

                Model.Oprema entity = null;
                if (_id.HasValue)
                    entity = await _opremaService.Update<Model.Oprema>(_id.Value, request);
                else
                    entity = await _opremaService.Insert<Model.Oprema>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");

                await LoadOprema();
            }
        }

        private async void pbRefesh_Click(object sender, EventArgs e)
        {
            await LoadOprema();
        }

        private async void frmOprema_Load(object sender, EventArgs e)
        {
            var result = await _opremaService.Get<List<Model.Oprema>>(null);
            dgvOprema.AutoGenerateColumns = false;
            dgvOprema.DataSource = result;
        }
        private async Task LoadOprema()
        {
            _id = null;
            txtNaziv.Text = string.Empty;
            txtOpis.Text = string.Empty;
            numCijena.Text = "0".ToString();
            btnDodaj.Text = "Dodaj";
            var list = await _opremaService.Get<List<Model.Oprema>>(null);
            dgvOprema.AutoGenerateColumns = false;
            dgvOprema.DataSource = list;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
