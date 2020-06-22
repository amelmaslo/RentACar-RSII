using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private readonly APIService _ulogeService = new APIService("Uloge");
        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtLozinka_Validating() && await txtKorisnickoIme_Validating() && await txtEmail_Validating())
            {
                var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();
                var request = new KorisniciUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text,
                    Status = cbStatus.Checked,
                    Uloge = roleList
                };

                Model.Korisnici entity = null;
                try
                {
                    if (_id.HasValue)
                    {
                        
                        entity = await _korisniciService.Update<Model.Korisnici>(_id.Value, request);
                        if (entity.KorisnickoIme.Equals(APIService.Username)) {
                            APIService.Password = request.Password;
                        }
                    }
                    else
                    {
                        entity = await _korisniciService.Insert<Model.Korisnici>(request);
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }
                this.Close();
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {

            var ulogeList = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";


            if (_id.HasValue)
            {
                var result = await _korisniciService.GetById<Model.Korisnici>(_id);
                txtIme.Text = result.Ime;
                txtPrezime.Text = result.Prezime;
                txtEmail.Text = result.Email;
                txtTelefon.Text = result.Telefon;
                txtKorisnickoIme.Text = result.KorisnickoIme;
                cbStatus.Checked = result.Status;

                foreach (var item in result.KorisniciUloge)
                {
                    for (int i = 0; i < clbUloge.Items.Count; i++)
                    {
                        Model.Uloge trenutni = (Model.Uloge)clbUloge.Items[i];
                        if (trenutni.UlogaId == item.UlogaId)
                        {
                            clbUloge.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void clbUloge_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeClb(clbUloge, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            Validator.KorisnickoIme(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private bool txtLozinka_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                if (_id.HasValue)
                {
                    errorProvider.SetError(txtLozinka, null);
                    errorProvider.SetError(txtPotvrdaLozinke, null);
                    return true;
                }
                else
                {
                    errorProvider.SetError(txtLozinka, Properties.Resources.ObaveznoPolje);
                    errorProvider.SetError(txtPotvrdaLozinke, Properties.Resources.ObaveznoPolje);
                    return false;
                }
            }
            else if (txtLozinka.Text != txtPotvrdaLozinke.Text)
            {
                errorProvider.SetError(txtLozinka, "Passwordi se ne slažu");
                errorProvider.SetError(txtPotvrdaLozinke, "Passwordi se ne slažu");
                return false;
            }
            errorProvider.SetError(txtLozinka, null);
            errorProvider.SetError(txtPotvrdaLozinke, null);
            return true;
        }

        private async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _korisniciService.Get<List<Model.Korisnici>>(null);
            int id = _id ?? 0;
            foreach (var item in result)
                if (item.KorisnickoIme == txtKorisnickoIme.Text && item.KorisnikId != id)
                {
                    errorProvider.SetError(txtKorisnickoIme, "Korisničko ime je zauzeto");
                    return false;
                }
            errorProvider.SetError(txtKorisnickoIme, null);
            return true;
        }

        private async Task<bool> txtEmail_Validating()
        {
            var result = await _korisniciService.Get<List<Model.Korisnici>>(null);
            int id = _id ?? 0;
            foreach (var item in result)
                if (item.Email == txtEmail.Text && item.KorisnikId != id)
                {
                    errorProvider.SetError(txtEmail, "Email je iskorišćen");
                    return false;
                }
            errorProvider.SetError(txtEmail, null);
            return true;
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}$") && !Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{4}$"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona je: +123 45 678 910 ili +123 45 678 9101");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider.SetError(txtEmail, "Pogrešan format email-a");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }
    }
}
