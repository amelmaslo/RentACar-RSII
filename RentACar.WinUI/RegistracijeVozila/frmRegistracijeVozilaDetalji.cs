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

namespace RentACar.WinUI.RegistracijeVozila
{
    public partial class frmRegistracijeVozilaDetalji : Form
    {
        private readonly APIService _registracijeVozilaService = new APIService("RegistracijeVozila");
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private int? _id;
        public frmRegistracijeVozilaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                RegistracijeVozilaUpsertRequest request = new RegistracijeVozilaUpsertRequest()
                {
                    VoziloId = int.Parse(cbVozilo.SelectedValue.ToString()),
                    UposlenikId = int.Parse(cbUposlenik.SelectedValue.ToString()),
                    Status = cbStatus.Checked,
                    Cijena = numCijena.Value,
                    PocetakRegistracije = dtpPocetak.Value,
                    KrajRegistracije = dtpKraj.Value,
                    RegistarskeOznake = txtRegistarskeOznake.Text
                };

                Model.RegistracijeVozila entity = null;
                if (_id.HasValue)
                    entity = await _registracijeVozilaService.Update<Model.RegistracijeVozila>(_id.Value, request);
                else
                    entity = await _registracijeVozilaService.Insert<Model.RegistracijeVozila>(request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");
                this.Close();
            }
        }

        private async void frmRegistracijeVozilaDetalji_Load(object sender, EventArgs e)
        {
            await LoadVozila();
            await LoadKorisnici();
            if (_id.HasValue) {
                var result = await _registracijeVozilaService.GetById<Model.RegistracijeVozila>(_id.Value);
                cbUposlenik.SelectedValue = result.UposlenikId;
                cbVozilo.SelectedValue = result.VoziloId;
                cbStatus.Checked = result.Status;
                numCijena.Value = result.Cijena;
                txtRegistarskeOznake.Text = result.RegistarskeOznake;
                dtpPocetak.Value = result.PocetakRegistracije;
                dtpKraj.Value = result.KrajRegistracije;
            }
        }
        private async Task LoadVozila()
        {
            var result = await _vozilaService.Get<List<Model.Vozila>>(null); 
            result.Insert(0, new Model.Vozila());
            cbVozilo.DataSource = result;
            cbVozilo.DisplayMember = "Ispis";
            cbVozilo.ValueMember = "VoziloId";
        }
        private async Task LoadKorisnici()
        {
            var result = await _korisniciService.Get<List<Model.Korisnici>>(null);

            List<Model.Korisnici> listaKorisnika = new List<Model.Korisnici>();//Samo radnici
            foreach (var korisnici in result)
            {
                bool ima = false;
                foreach (var korisnckaUloga in korisnici.KorisniciUloge)
                {
                    if (korisnckaUloga.UlogaId == 2)
                    {
                        ima = true;
                        break;
                    }
                }
                if (ima)
                    listaKorisnika.Add(korisnici);
            }
            listaKorisnika.Insert(0, new Model.Korisnici());
            cbUposlenik.DataSource = listaKorisnika;
            cbUposlenik.DisplayMember = "KorisnickoIme";
            cbUposlenik.ValueMember = "KorisnikId";
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(sender as ComboBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtp_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(sender as DateTimePicker, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
        private void numCijena_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeNumeric(sender as NumericUpDown, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
