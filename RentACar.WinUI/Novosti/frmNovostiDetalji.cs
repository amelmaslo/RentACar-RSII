using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Novosti
{
    public partial class frmNovostiDetalji : Form
    {
        private readonly APIService _novostiService = new APIService("Novosti");
        private readonly APIService _korisniciService = new APIService("Korisnici");

        private byte[] slikaTemp;
        private int? _id;
        public frmNovostiDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmNovostiDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _novostiService.GetById<Model.Novosti>(_id.Value);
                txtNaziv.Text = result.Naziv;
                txtOpis.Text = result.Opis;

                slikaTemp = result.Slika;

                //slika
                if (result.Slika.Length != 0)
                {
                    pbSlika.Image = Image.FromStream(new MemoryStream(result.Slika));
                }

            }

        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var korisniklist = await _korisniciService.Get<List<Model.Korisnici>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.Username });
            var korisnik = korisniklist.Where(x => x.KorisnickoIme == APIService.Username).FirstOrDefault();

            if (ValidateChildren())
            {
                var request = new NovostiUpsertRequest()
                {
                  Datum = DateTime.Now,
                  Naziv = txtNaziv.Text,
                  Opis = txtOpis.Text,
                  KorisnikId =  korisnik.KorisnikId
                };

                if (txtSlika.Text != string.Empty)//Slika
                {
                    var file = File.ReadAllBytes(txtSlika.Text);
                    request.Slika = file;
                }
                else
                {
                    request.Slika = slikaTemp;
                }

                Model.Novosti entity = null;
                if (_id.HasValue)
                    entity = await _novostiService.Update<Model.Novosti>(_id.Value, request);
                else
                    entity = await _novostiService.Insert<Model.Novosti>(request);

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }
                this.Close();
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
            {
                var result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    txtSlika.Text = fileName;
                    Image image = Image.FromFile(fileName);
                    pbSlika.Image = image;
                }
            }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeRtxt(sender as RichTextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
