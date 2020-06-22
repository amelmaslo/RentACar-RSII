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

namespace RentACar.WinUI.Racuni
{
    public partial class frmRacuniDetalji : Form
    {
        private readonly APIService _racuniService = new APIService("Racuni");
        private int _id;
        public frmRacuniDetalji(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            var result = await _racuniService.GetById<Model.Racuni>(_id);
            txtBrojRacuna.Text = "No. " + result.BrojRacuna;
            dateTimePicker1.Value = result.Datum;
            txtIznajmljivanjeVozila.Text = result.IznajmljivanjeVozila.ToString()+" €";
            txtOpremaUkupno.Text = result.OpremaUkupno.ToString() + " €";
            txtOsiguranjeUkupno.Text = result.OsiguranjeUkupno.ToString() + " €";
            txtPopust.Text = result.Popust.ToString() + " %";
            txtPdv.Text = result.Pdv.ToString() + " €";
            txtIznosBezPdv.Text = result.IznosBezPdv.ToString() + " €";
            txtIznosSaPdv.Text = result.IznosSaPdv.ToString() + " €";
            txtVozilo.Text = result.Vozilo;        
            txtKorisnickoIme.Text = result.KorisnickoIme;
            pictureBox1.Image = BytesToImage(result.QRCode);
            cbStatus.Checked = result.Status;
        }

        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }
        private void btnUredu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
