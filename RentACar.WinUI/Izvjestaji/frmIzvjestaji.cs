using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var tap = cbVozilo.SelectedValue.ToString();
                if (int.TryParse(tap, out int id))
                {
                    frmIzvjestajiDetalji frm = new frmIzvjestajiDetalji(id);
                    frm.ShowDialog();
                }
            }
        }

        private void cbVozilo_Validating(object sender, CancelEventArgs e)
        {
                Validator.ObaveznoPoljeCmb(cbVozilo, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private async void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var result = await _vozilaService.Get<List<Model.Vozila>>(null);
            result.Insert(0, new Model.Vozila());
            cbVozilo.DataSource = result;
            cbVozilo.DisplayMember = "Ispis";
            cbVozilo.ValueMember = "VoziloId";
        }
    }
}
