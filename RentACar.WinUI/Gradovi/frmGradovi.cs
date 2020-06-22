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

namespace RentACar.WinUI.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _gradoviService = new APIService("Gradovi");
        private readonly APIService _drzaveService = new APIService("Drzave");

        private int? _id = null;
        public frmGradovi(int? id = null)
        {
            InitializeComponent();
            _id = null;
        }

        private async void frmGradovi_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            var list = await _gradoviService.Get<List<Model.Gradovi>>(null);
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = list;
        }

        private async Task LoadDrzave() {
            var result = await _drzaveService.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave());
            cbDrzava.DisplayMember = "Naziv";
            cbDrzava.ValueMember = "DrzavaId";
            cbDrzava.DataSource = result;
        }
        private async Task LoadGradovi(int id)
        {
            dgvGradovi.AutoGenerateColumns = false;
            var result = await _gradoviService.Get<List<Model.Gradovi>>(new GradoviSearchRequest() { DrzavaId = id});
            dgvGradovi.DataSource = result;
        }
        private void dgvGradovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvGradovi.SelectedRows[0].DataBoundItem as Model.Gradovi;
            txtNaziv.Text = result.Naziv;
            _id = result.GradId;
            btnDodaj.Text = "Uredi";
            cbDrzava.SelectedValue = result.DrzavaId;
        }
        private async void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(cbDrzava.SelectedValue.ToString());
            await LoadGradovi(id);  
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
          
            if (ValidateChildren() && cbDrzava_Validating())
            {
                var request = new GradoviUpsertRequest()
                {
                    DrzavaId = int.Parse(cbDrzava.SelectedValue.ToString()),
                    Naziv = txtNaziv.Text
                };

                Model.Gradovi entity = null;

                if (_id.HasValue)
                    entity = await _gradoviService.Update<Model.Gradovi>(_id.Value, request);
                else
                    entity = await _gradoviService.Insert<Model.Gradovi>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");
                await LoadGradovi(request.DrzavaId);

                Reload();
            }
        }
        private void Reload()
        {
            _id = null;
            btnDodaj.Text = "Dodaj";
            txtNaziv.Text = string.Empty;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private bool cbDrzava_Validating()
        {
            if (cbDrzava.SelectedIndex == 0)
            {
                errorProvider.SetError(cbDrzava, Properties.Resources.ObaveznoPolje);
               return false;
            }
            else
            {
                errorProvider.SetError(cbDrzava, null);
            }
            return true;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
