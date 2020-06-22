using RentACar.Model.Requests;
using RentACar.WinUI.Kupci;
using RentACar.WinUI.Racuni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Rezervacije
{
    public partial class frmRezervacijeDetalji : Form
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _racuniService = new APIService("Racuni");
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _osiguranjaVozilaService = new APIService("Osiguranja");
        private readonly APIService _lokacijeService = new APIService("Lokacije");
        private readonly APIService _opremaService = new APIService("Oprema");

        

        private int? _id;
        public frmRezervacijeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && dtm_Validating())
            {
                var opremaList = clbOprema.CheckedItems.Cast<Model.Oprema>().Select(x => x.OpremaId).ToList();

                var request = new RezervacijeUpsertRequest()
                {
                    KupacId = int.Parse(cbKupac.SelectedValue.ToString()),
                    VoziloId = int.Parse(cbVozilo.SelectedValue.ToString()),
                    OsiguranjeId = int.Parse(cbOsiguranje.SelectedValue.ToString()),
                    LokacijaPovrataId = int.Parse(cbLokacijaPovrata.SelectedValue.ToString()),
                    LokacijaPreuzimanjaId = int.Parse(cbLokacijaPreuzimanja.SelectedValue.ToString()),
                    DatumKreiranjaRezervacij = DateTime.Now,
                    DatumPovrata = dtpPovrata.Value.Date,
                    DatumPreuzimanja = dtpPreuzimanja.Value.Date,
                    Napomena = txtNapomena.Text,
                    Status = chbStatus.Checked,
                    Oprema = opremaList,
                    Popust = numPopust.Value
                };


                Model.Rezervacije entity = null;
                if (_id.HasValue)
                {
                    entity = await _rezervacijeService.Update<Model.Rezervacije>(_id.Value, request);
                }
                else
                {
                    entity = await _rezervacijeService.Insert<Model.Rezervacije>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");

                    var result = await _racuniService.Get<List<Model.Racuni>>(null);
                    foreach (var item in result)
                    {
                        if (item.RezervacijaId == entity.RezervacijaId && item.Status == true)
                        {
                            frmRacuniDetalji frm = new frmRacuniDetalji(item.RacunId);
                            frm.ShowDialog();
                            break;
                        }
                    }

                }
                this.Close();
            }
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            await LoadKupci();
            await LoadOsiguranja();
            await LoadVozila();
            await LoadLokacijePovrata();
            await LoadLokacijePreuzimanja();
            await LoadOpreme();

            if (_id.HasValue) {
                var result = await _rezervacijeService.GetById<Model.Rezervacije>(_id);
                cbKupac.SelectedValue = result.KupacId;
                cbOsiguranje.SelectedValue = result.OsiguranjeId;
                cbLokacijaPovrata.SelectedValue = result.LokacijaPovrataId;
                cbLokacijaPreuzimanja.SelectedValue = result.LokacijaPreuzimanjaId;
                cbVozilo.SelectedValue = result.VoziloId;
                dtpPovrata.Value = result.DatumPovrata;
                dtpPreuzimanja.Value = result.DatumPreuzimanja;
                txtNapomena.Text = result.Napomena;
                chbStatus.Checked = result.Status;
                numPopust.Value = result.Popust ?? 0;
                //oprema
                foreach (var item in result.DodatnaOprema)
                {
                    for (int i = 0; i < clbOprema.Items.Count; i++)
                    {
                        Model.Oprema trenutni = (Model.Oprema)clbOprema.Items[i];
                        if (trenutni.OpremaId == item.OpremaId)
                        {
                            clbOprema.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
        }
        }
        private async Task LoadOpreme() {
            var opermaList = await _opremaService.Get<List<Model.Oprema>>(null);
            clbOprema.DataSource = opermaList;
            clbOprema.DisplayMember = "Ispis";
            clbOprema.ValueMember = "OpremaId";
        }
        private async Task LoadKupci()
        {
            var result = await _kupciService.Get<List<Model.Kupci>>(null);
            result.Insert(0, new Model.Kupci());
            cbKupac.DataSource = result;
            cbKupac.DisplayMember = "KorisnickoIme";
            cbKupac.ValueMember = "KupacId";
        }
        private async Task LoadOsiguranja()
        {
            var result = await _osiguranjaVozilaService.Get<List<Model.Osiguranja>>(null);
            result.Insert(0, new Model.Osiguranja());
            cbOsiguranje.DataSource = result;
            cbOsiguranje.DisplayMember = "Ispis";
            cbOsiguranje.ValueMember = "OsiguranjeId";
        }
        private async Task LoadLokacijePreuzimanja()
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());
            cbLokacijaPreuzimanja.DataSource = result;
            cbLokacijaPreuzimanja.DisplayMember = "Ispis";
            cbLokacijaPreuzimanja.ValueMember = "LokacijaId";
        }
        private async Task LoadLokacijePovrata()
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());
            cbLokacijaPovrata.DataSource = result;
            cbLokacijaPovrata.DisplayMember = "Ispis";
            cbLokacijaPovrata.ValueMember = "LokacijaId";
        }
        private async Task LoadVozila()
        {
            var result = await _vozilaService.Get<List<Model.Vozila>>(null);
            result.Insert(0, new Model.Vozila());
            cbVozilo.DataSource = result;
            cbVozilo.DisplayMember = "Ispis";
            cbVozilo.ValueMember = "VoziloId";
        }
        private void btnKupac_Click(object sender, EventArgs e)
        {
            frmKupciDetalji frm = new frmKupciDetalji();
            frm.ShowDialog();
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(sender as ComboBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtp_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(sender as DateTimePicker, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }


        private bool dtm_Validating()
        {
            var razlika = (int)(dtpPovrata.Value - dtpPreuzimanja.Value).TotalDays;

            if (razlika < 1)
            {
                errorProvider.SetError(dtpPreuzimanja, "Datum preuzmanja veći od datuma povrata");
                errorProvider.SetError(dtpPovrata, "Datum povrata manji od datuma preuzimanja");
                return false;
            }
            errorProvider.SetError(dtpPreuzimanja, null);
            errorProvider.SetError(dtpPovrata, null);
            return true;
        }
    }
}
