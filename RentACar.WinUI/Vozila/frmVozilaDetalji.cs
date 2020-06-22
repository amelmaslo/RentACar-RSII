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

namespace RentACar.WinUI.Vozila
{
    public partial class frmVozilaDetalji : Form
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _notifikacijeServices = new APIService("Notifikacije");
        private readonly APIService _pretplateServices = new APIService("Pretplate");
        private readonly APIService _modeliService = new APIService("Modeli");
        private readonly APIService _kategorijeVozilaService = new APIService("KategorijeVozila");
        private readonly APIService _lokacijeService = new APIService("Lokacije");

        private int? _id;
        private byte[] slikaTemp;
        private byte[] slikaThumbTemp;
        public frmVozilaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async Task LoadModeli()
        {
            var result = await _modeliService.Get<List<Model.Modeli>>(null);
            result.Insert(0,new Model.Modeli());
            cbModeli.DataSource = result;
            cbModeli.DisplayMember = "Naziv";
            cbModeli.ValueMember = "ModelId";
        }
        private async Task LoadLokacije()
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());
            cbLokacije.DataSource = result;
            cbLokacije.DisplayMember = "Adresa";
            cbLokacije.ValueMember = "LokacijaId";
        }
        private async Task LoadKategorijeVozila()
        {
            var result = await _kategorijeVozilaService.Get<List<Model.KategorijeVozila>>(null);
            result.Insert(0, new Model.KategorijeVozila());
            cbKategorijeVozila.DataSource = result;
            cbKategorijeVozila.DisplayMember = "Naziv";
            cbKategorijeVozila.ValueMember = "KategorijaVozilaId";
        }

        private async void frmVozilaDetalji_Load(object sender, EventArgs e)
        {
            await LoadModeli();
            await LoadLokacije();
            await LoadKategorijeVozila();

            if (_id.HasValue)
            {
                var result = await _vozilaService.GetById<Model.Vozila>(_id.Value);

                numCijena.Value = result.Cijena;
                txtGodinaProizvodnje.Text = result.GodinaProizvodnje.ToString();
                txtGorivo.Text = result.Gorivo;
                txtSnaga.Text = result.Snaga;
                txtTransmisija.Text = result.Transmisija;
                numBrojVrata.Value = result.BrojVrata;
                numBrojSjedista.Value = result.BrojSjedista;
                txtBrojSasije.Text = result.BrojSasije;
                cbModeli.SelectedValue = result.ModelId; 
                cbKategorijeVozila.SelectedValue = result.KategorijaVozilaId; 
                cbLokacije.SelectedValue = result.LokacijaId;
                chbStatus.Checked = result.Status;
                slikaTemp = result.Slika;
                slikaThumbTemp = result.SlikaThumb;

                //slika
                if (result.Slika.Length != 0) {
                    pbSlika.Image = Image.FromStream(new MemoryStream(result.SlikaThumb));
                }

            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtSlika_Validating())
            {
                var request = new VozilaUpsertRequest()
                {
                    ModelId = int.Parse(cbModeli.SelectedValue.ToString()),
                    LokacijaId = int.Parse(cbLokacije.SelectedValue.ToString()),
                    KategorijaVozilaId = int.Parse(cbKategorijeVozila.SelectedValue.ToString()),
                    Cijena = numCijena.Value,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    Gorivo = txtGorivo.Text,
                    Transmisija = txtTransmisija.Text,
                    Snaga = txtSnaga.Text,
                    BrojVrata = (int)numBrojVrata.Value,
                    BrojSjedista = (int)numBrojSjedista.Value,
                    BrojSasije = txtBrojSasije.Text,
                    Status = chbStatus.Checked
                };

                if (txtSlika.Text != string.Empty)//Slika
                {
                    var file = File.ReadAllBytes(txtSlika.Text);
                    request.Slika = file;
                    request.SlikaThumb = file;
                }
                else
                {
                    request.Slika = slikaTemp;
                    request.SlikaThumb = slikaThumbTemp;
                }

                Model.Vozila entity = null;
                if (_id.HasValue)
                {
                    entity = await _vozilaService.Update<Model.Vozila>(_id.Value, request);
                }
                else
                {
                    entity = await _vozilaService.Insert<Model.Vozila>(request);
                    if (entity != null)
                    {
                        var vozilo = await _vozilaService.GetById<Model.Vozila>(entity.VoziloId);
                        var listPretplate = await _pretplateServices.Get<List<Model.Pretplate>>(new PretplateSearchRequest() { KategorijaVozilaId = entity.KategorijaVozilaId });
                        foreach (var item in listPretplate)
                        {
                            if (item.Status)
                            {
                                NotifikacijeUpsertRequest _requestNotifikacija = new NotifikacijeUpsertRequest()
                                {
                                    DatumSlanja = DateTime.Now,
                                    Status = true,
                                    Naziv = $"Obavješavamo vas da smo našu ponudu obogatili novim vozilom {vozilo.Model.Proizvodjac.Naziv} {vozilo.Model.Naziv} {vozilo.GodinaProizvodnje}!\nRezervišite ga na lokacji {vozilo.Lokacija.Adresa}",
                                    //NovostId = null,
                                    KupacId = item.KupacId
                                };
                               var notifikacija = await _notifikacijeServices.Insert<Model.Notifikacije>(_requestNotifikacija);//slanje notifikacija pretplatnicima
                            }
                        }
                    }
                }

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

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(sender as TextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void num_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeNumeric(sender as NumericUpDown, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtGodinaProizvodnje_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeMtxt(sender as MaskedTextBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(sender as ComboBox, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private bool txtSlika_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text) && !_id.HasValue)
            {
                errorProvider.SetError(txtSlika, Properties.Resources.ObaveznoPolje);
                return false;
            }
            else
            {
                errorProvider.SetError(txtSlika, null);
            }
            return true;
        }
    }
}
