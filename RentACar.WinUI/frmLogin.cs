using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Uloge");
        APIService _korisniciService = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtLozinka.Text;
                await _service.Get<dynamic>(null);

                List<Model.Korisnici> listKorisnici = await _korisniciService.Get<List<Model.Korisnici>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.Username }) ;
                Model.Korisnici korisnik = listKorisnici.Where(x => x.KorisnickoIme == APIService.Username).FirstOrDefault();
                if (korisnik != null)
                {
                    frmIndex frm = new frmIndex();
                    frm.Show();
                }
                else { 
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                }
            }
            catch(Exception ex) {
                //MessageBox.Show(ex.Message);
            }
        }
    
    }
}
