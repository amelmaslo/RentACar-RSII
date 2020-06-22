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

namespace RentACar.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _lokacijeService = new APIService("Lokacije");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijeSearchRequest request = new RezervacijeSearchRequest() {
                KorisnickoIme = txtKorisnickoIme.Text,
                Vozilo = txtVozilo.Text,
            };

            var objlokacijaPreuzimanja = cmbLokacijaPreuzimanja.SelectedValue;
            request.LokacijaPreuzimanjaId = int.Parse(objlokacijaPreuzimanja?.ToString()??"0"); 
            
            var objlokacijaPovrata = cmbLokacijaPovrata.SelectedValue;
            request.LokacijaPovrataId = int.Parse(objlokacijaPovrata?.ToString()??"0");


            var result = await _rezervacijeService.Get<List<Model.Rezervacije>>(request);

            foreach (var item in result)
            {
                item.Oprema = "";
                foreach (var x in item.DodatnaOprema)
                {
                    item.Oprema += $"{x.Oprema.Naziv + x.Oprema.Cijena}  ";
                }
            }

            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;

        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            await LoadLokacijaPreuzimanja();
            await LoadLokacijaPovrata();
        }

        private async Task LoadLokacijaPovrata()
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());

            cmbLokacijaPovrata.DataSource = result;
            cmbLokacijaPovrata.DisplayMember = "Adresa";
            cmbLokacijaPovrata.ValueMember = "LokacijaID";
        }
        private async Task LoadLokacijaPreuzimanja()
        {
            var result = await _lokacijeService.Get<List<Model.Lokacije>>(null);
            result.Insert(0, new Model.Lokacije());

            cmbLokacijaPreuzimanja.DataSource = result;
            cmbLokacijaPreuzimanja.DisplayMember = "Adresa";
            cmbLokacijaPreuzimanja.ValueMember = "LokacijaID";
        }

        private void dgvRezervacije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());
            frmRezervacijeDetalji frm = new frmRezervacijeDetalji(id);
            frm.ShowDialog();
        }
    }
}
