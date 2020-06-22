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

namespace RentACar.WinUI.Lokacije
{
    public partial class frmLokacije : Form
    {
        private readonly APIService _lokacijeService = new APIService("Lokacije");
        private readonly APIService _gradoviService = new APIService("Gradovi");
        private int? _id = null;
        public frmLokacije(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmLokacije_Load(object sender, EventArgs e)
        {
            await LoadGradovi();

            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            dgvLokacije.AutoGenerateColumns = false;
            dgvLokacije.DataSource = result;
        }

        private async Task LoadGradovi()
        {
            var result = await _gradoviService.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi());
            cbGrad.DisplayMember = "Naziv";
            cbGrad.ValueMember = "GradId";
            cbGrad.DataSource = result;
        }
        private async Task LoadLokacije(int id)
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(new LokacijeUpsertRequest() { GradId = id });
            dgvLokacije.AutoGenerateColumns = false;
            dgvLokacije.DataSource = result;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            _id = null;
            btnDodaj.Text = "Dodaj";
            txtAdresa.Text = string.Empty;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && cbGradValidating())
            {
                var request = new LokacijeUpsertRequest()
                {
                    GradId = int.Parse(cbGrad.SelectedValue.ToString()),
                    Adresa = txtAdresa.Text
                };

                Model.Lokacije entity = null;

                if (_id.HasValue)
                    entity = await _lokacijeService.Update<Model.Lokacije>(_id.Value, request);
                else
                    entity = await _lokacijeService.Insert<Model.Lokacije>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");
                await LoadLokacije(request.GradId);
                Reload();
            }
        }

        private async void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(cbGrad.SelectedValue.ToString());
            await LoadLokacije(id);
        }

        private void dgvLokacije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvLokacije.SelectedRows[0].DataBoundItem as Model.Lokacije;
            txtAdresa.Text = result.Adresa;
            _id = result.LokacijaId;
            btnDodaj.Text = "Uredi";
            cbGrad.SelectedValue = result.GradId;
        }

        private bool cbGradValidating()
        {
            if (cbGrad.SelectedIndex == 0)
            {
                errorProvider.SetError(cbGrad, Properties.Resources.ObaveznoPolje);
                return false;
            }
            else
            {
                errorProvider.SetError(cbGrad, null);
            }
            return true;
        }
        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
  
    