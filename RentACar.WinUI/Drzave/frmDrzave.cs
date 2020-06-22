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

namespace RentACar.WinUI.Drzave
{
    public partial class frmDrzave : Form
    {
        private readonly APIService _drzaveService = new APIService("Drzave");
        private int? _id = null;
        public frmDrzave(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDrzave_Load(object sender, EventArgs e)
        {
            var list = await _drzaveService.Get<List<Model.Drzave>>(null);
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = list;
        }

        private async Task DrzaveLoad()
        {
            _id = null;
            btnDodaj.Text = "Dodaj";
            txtNaziv.Text = string.Empty;
            var list = await _drzaveService.Get<List<Model.Drzave>>(null);
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = list;
        }

        private void dgvDrzave_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvDrzave.SelectedRows[0].DataBoundItem as Model.Drzave;
            txtNaziv.Text = result.Naziv;
            _id = result.DrzavaId;
            btnDodaj.Text = "Uredi";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new DrzaveUpsertRequest()
                {
                    Naziv = txtNaziv.Text
                };

                Model.Drzave entity = null;

                if (_id.HasValue)
                    entity = await _drzaveService.Update<Model.Drzave>(_id.Value, request);
                else
                    entity = await _drzaveService.Insert<Model.Drzave>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");

                await DrzaveLoad();
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await DrzaveLoad();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
