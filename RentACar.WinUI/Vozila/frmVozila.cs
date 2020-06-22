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

namespace RentACar.WinUI.Vozila
{
    public partial class frmVozila : Form
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _modeliService = new APIService("Modeli");
        private readonly APIService _kategorijeVozilaService = new APIService("KategorijeVozila");
        private readonly APIService _lokacijeService = new APIService("Lokacije");
        public frmVozila()
        {
            InitializeComponent();
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            VozilaSearchRequest request = new VozilaSearchRequest()
            {
                BrojSasije = txtBrojSasije.Text
            };
            
            var objmodel  = cmbModeli.SelectedValue;
            if (objmodel == null)
                request.ModelId = 0;
            else 
                request.ModelId = int.Parse(objmodel.ToString());
            
            var objlokacija = cmbLokacije.SelectedValue;
            if (objlokacija == null)
                request.LokacijaId = 0;
            else
                request.LokacijaId = int.Parse(objlokacija.ToString());
            
            var objKategorije = cmbKategorijeVozila.SelectedValue;
            if (objKategorije == null)
                request.KategorijaVozilaId = 0;
            else
                request.KategorijaVozilaId = int.Parse(objKategorije.ToString());

            var result = await _vozilaService.Get<List<Model.Vozila>>(request);

            dgvVozila.AutoGenerateColumns = false;
            dgvVozila.DataSource = result;
        }
        private async void frmVozila_Load(object sender, EventArgs e)
        {
            await LoadModeli();
            await LoadLokacije();
            await LoadKategorijeVozila();
        }
        private async Task LoadModeli(){
            var result = await _modeliService.Get<List<Model.Modeli>>(null);
            result.Insert(0, new Model.Modeli());
            cmbModeli.DataSource = result;
            cmbModeli.DisplayMember = "Naziv";
            cmbModeli.ValueMember = "ModelId";
        }
        private async Task LoadLokacije(){
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());
            cmbLokacije.DataSource = result;
            cmbLokacije.DisplayMember = "Adresa";
            cmbLokacije.ValueMember = "LokacijaId";
        }
        private async Task LoadKategorijeVozila()
        {
            var result = await _kategorijeVozilaService.Get<List<Model.KategorijeVozila>>(null);
            result.Insert(0, new Model.KategorijeVozila());
            cmbKategorijeVozila.DataSource = result;
            cmbKategorijeVozila.DisplayMember = "Naziv";
            cmbKategorijeVozila.ValueMember = "KategorijaVozilaId";
        }

        private void dgvVozila_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvVozila.SelectedRows[0].Cells[0].Value.ToString());
            frmVozilaDetalji frm = new frmVozilaDetalji(id);
            frm.ShowDialog();
        }
    }
}
