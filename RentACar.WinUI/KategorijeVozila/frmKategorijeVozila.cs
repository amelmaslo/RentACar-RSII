using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.KategorijeVozila
{
    public partial class frmKategorijeVozila : Form
    {
        private readonly APIService _kategorijeVozilaService = new APIService("KategorijeVozila");
        public frmKategorijeVozila()
        {
            InitializeComponent();
        }

        private async void frmKategorijeVozila_Load(object sender, EventArgs e)
        {
            var result = await _kategorijeVozilaService.Get<List<Model.KategorijeVozila>>(null);
            dgvKategotijeVozila.AutoGenerateColumns = false;
            dgvKategotijeVozila.DataSource = result;
        }
    }
}
