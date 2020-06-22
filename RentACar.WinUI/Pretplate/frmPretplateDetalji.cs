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
    public partial class frmPretplateDetalji : Form
    {
        private readonly APIService _pretplateService = new APIService("Pretplate");
        private readonly APIService _kategorijeVozilaService = new APIService("KategorijeVozila");
        private readonly APIService _kupciService = new APIService("Kupci");

        private int? _id;
        public frmPretplateDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }
        private async void frmPretplateDetalji_Load(object sender, EventArgs e)
        {
            await LoadKupci();
            await LoadKategorijeVozila();
            if (_id.HasValue)
            {
                var result = await _pretplateService.GetById<Model.Pretplate>(_id);
                cmbKupac.SelectedValue = result.KupacId;
                cmbKategorijaVozila.SelectedValue = result.KategorijaVozilaId;
                cbStatus.Checked = result.Status;
            }
        }
        private async Task LoadKupci()
        {
            var result = await _kupciService.Get<List<Model.Kupci>>(null);
            result.Insert(0, new Model.Kupci());
            cmbKupac.DataSource = result;
            cmbKupac.DisplayMember = "KorisnickoIme";
            cmbKupac.ValueMember = "KupacId";
        }
        private async Task LoadKategorijeVozila()
        {
            var result = await _kategorijeVozilaService.Get<List<Model.KategorijeVozila>>(null);
            result.Insert(0, new Model.KategorijeVozila());
            cmbKategorijaVozila.DataSource = result;
            cmbKategorijaVozila.DisplayMember = "Naziv";
            cmbKategorijaVozila.ValueMember = "KategorijaVozilaId";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && await Unique_Validating())
            {

                var request = new PretplateUpsertRequest()
                {
                    KupacId = int.Parse(cmbKupac.SelectedValue.ToString()),
                    KategorijaVozilaId = int.Parse(cmbKategorijaVozila.SelectedValue.ToString()),
                    Status = cbStatus.Checked,
                    Datum = DateTime.Now
                };


                Model.Pretplate entity = null;
                if (_id.HasValue)
                {
                    entity = await _pretplateService.Update<Model.Pretplate>(_id.Value, request);
                }
                else
                {
                    entity = await _pretplateService.Insert<Model.Pretplate>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }
                this.Close();
            }
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(sender as ComboBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private async Task<bool> Unique_Validating()
        {
            var KupacId = int.Parse(cmbKupac.SelectedValue.ToString());
            var KategorijaVozilaId = int.Parse(cmbKategorijaVozila.SelectedValue.ToString());
            var list = await _pretplateService.Get<List<Model.Pretplate>>(new PretplateSearchRequest() {KategorijaVozilaId = KategorijaVozilaId, KupacId = KupacId  });
            foreach (var item in list) {
                if (item.Status && item.PretplataId != (_id??0))
                {
                    errorProvider.SetError(cbStatus, "Pretplata već postoji");
                    return false;
                }
            }
            errorProvider.SetError(cbStatus, null);
            return true;
        }



    }
}
