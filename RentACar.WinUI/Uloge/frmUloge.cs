using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Uloge
{
    public partial class frmUloge : Form
    {
        private readonly APIService _ulogeService = new APIService("Uloge");
        public frmUloge()
        {
            InitializeComponent();
        }

        private async void frmUloge_Load(object sender, EventArgs e)
        {
            var result = await _ulogeService.Get<List<Model.Uloge>>(null);
            dgvUloge.AutoGenerateColumns = false;
            dgvUloge.DataSource = result;
        }

    }
}
