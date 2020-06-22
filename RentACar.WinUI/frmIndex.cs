using RentACar.WinUI.Drzave;
using RentACar.WinUI.Gradovi;
using RentACar.WinUI.KategorijeVozila;
using RentACar.WinUI.Korisnici;
using RentACar.WinUI.Kupci;
using RentACar.WinUI.Lokacije;
using RentACar.WinUI.Modeli;
using RentACar.WinUI.Novosti;
using RentACar.WinUI.Oprema;
using RentACar.WinUI.Osiguranja;
using RentACar.WinUI.Pretplate;
using RentACar.WinUI.Proizvodjaci;
using RentACar.WinUI.Racuni;
using RentACar.WinUI.RegistracijeVozila;
using RentACar.WinUI.Rezervacije;
using RentACar.WinUI.Uloge;
using RentACar.WinUI.Vozila;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.Show();
        }
        private void prikazKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupci frm = new frmKupci();
            frm.MdiParent = this;
            frm.Show();
        }
        private void prikazRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacije frm = new frmRezervacije();
            frm.MdiParent = this;
            frm.Show();
        }
        private void prikazVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozila frm = new frmVozila();
            frm.MdiParent = this;
            frm.Show();
        }
        private void prikazRegistracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistracijeVozila frm = new frmRegistracijeVozila();
            frm.MdiParent = this;
            frm.Show();
        }     
        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji frm = new frmKorisniciDetalji();
            frm.Show();
        }
        private void noviKupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupciDetalji frm = new frmKupciDetalji();
            frm.Show();
        }
        private void novaRegistracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistracijeVozilaDetalji frm = new frmRegistracijeVozilaDetalji();
            frm.Show();
        }
        private void novoVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozilaDetalji frm = new frmVozilaDetalji();
            frm.Show();
        }
        private void novaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacijeDetalji frm = new frmRezervacijeDetalji();
            frm.Show();
        }
        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni frm = new frmRacuni();
            frm.MdiParent = this;
            frm.Show();
        }
        private void opremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOprema frm = new frmOprema();
            frm.MdiParent = this;
            frm.Show();
        }
        private void drzaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzave frm = new frmDrzave(null);
            frm.MdiParent = this;
            frm.Show();
        }
        private void ulogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUloge frm = new frmUloge();
            frm.MdiParent = this;
            frm.Show();
        }
        private void modeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeli frm = new frmModeli();
            frm.MdiParent = this;
            frm.Show();
        }
        private void kategorijeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijeVozila frm = new frmKategorijeVozila();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proizvodjaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodjaci frm = new frmProizvodjaci();
            frm.MdiParent = this;
            frm.Show();
        }
        private void osiguranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOsiguranja frm = new frmOsiguranja();
            frm.MdiParent = this;
            frm.Show();
        }
        private void lokacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLokacije frm = new frmLokacije();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gradoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradovi frm = new frmGradovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazNovostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovosti frm = new frmNovosti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazPreplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretplate frm = new frmPretplate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaPreplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretplateDetalji frm = new frmPretplateDetalji();
            frm.Show();
        }

        private void novaNovostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovostiDetalji frm = new frmNovostiDetalji();
            frm.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            this.Close();
        }
    }
}
