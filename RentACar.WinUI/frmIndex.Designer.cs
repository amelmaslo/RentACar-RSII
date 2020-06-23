namespace RentACar.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazKupacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKupacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulogeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodjaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijeVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazRegistracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRegistracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osiguranjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazNovostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaNovostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPreplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPreplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.kupciToolStripMenuItem,
            this.ulogeToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.racuniToolStripMenuItem,
            this.opremaToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.modeliToolStripMenuItem,
            this.kategorijeVozilaToolStripMenuItem,
            this.proizvodjaciToolStripMenuItem,
            this.registracijeVozilaToolStripMenuItem,
            this.osiguranjaToolStripMenuItem,
            this.lokacijeToolStripMenuItem,
            this.gradoviToolStripMenuItem,
            this.drzaveToolStripMenuItem,
            this.novostiToolStripMenuItem,
            this.preplateToolStripMenuItem,
            this.izvjestajiToolStripMenuItem,
            this.odjaviSeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip.Size = new System.Drawing.Size(130, 755);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // prikazKorisnikaToolStripMenuItem
            // 
            this.prikazKorisnikaToolStripMenuItem.Name = "prikazKorisnikaToolStripMenuItem";
            this.prikazKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.prikazKorisnikaToolStripMenuItem.Text = "Prikaz korisnika";
            this.prikazKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.prikazKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazKupacaToolStripMenuItem,
            this.noviKupacToolStripMenuItem});
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.kupciToolStripMenuItem.Text = "Kupci";
            // 
            // prikazKupacaToolStripMenuItem
            // 
            this.prikazKupacaToolStripMenuItem.Name = "prikazKupacaToolStripMenuItem";
            this.prikazKupacaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.prikazKupacaToolStripMenuItem.Text = "Prikaz kupaca";
            this.prikazKupacaToolStripMenuItem.Click += new System.EventHandler(this.prikazKupacaToolStripMenuItem_Click);
            // 
            // noviKupacToolStripMenuItem
            // 
            this.noviKupacToolStripMenuItem.Name = "noviKupacToolStripMenuItem";
            this.noviKupacToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.noviKupacToolStripMenuItem.Text = "Novi kupac";
            this.noviKupacToolStripMenuItem.Click += new System.EventHandler(this.noviKupacToolStripMenuItem_Click);
            // 
            // ulogeToolStripMenuItem
            // 
            this.ulogeToolStripMenuItem.Name = "ulogeToolStripMenuItem";
            this.ulogeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.ulogeToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.ulogeToolStripMenuItem.Text = "Uloge";
            this.ulogeToolStripMenuItem.Click += new System.EventHandler(this.ulogeToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazRezervacijaToolStripMenuItem,
            this.novaRezervacijaToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // prikazRezervacijaToolStripMenuItem
            // 
            this.prikazRezervacijaToolStripMenuItem.Name = "prikazRezervacijaToolStripMenuItem";
            this.prikazRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.prikazRezervacijaToolStripMenuItem.Text = "Prikaz rezervacija";
            this.prikazRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.prikazRezervacijaToolStripMenuItem_Click);
            // 
            // novaRezervacijaToolStripMenuItem
            // 
            this.novaRezervacijaToolStripMenuItem.Name = "novaRezervacijaToolStripMenuItem";
            this.novaRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.novaRezervacijaToolStripMenuItem.Text = "Nova rezervacija";
            this.novaRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.novaRezervacijaToolStripMenuItem_Click);
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.racuniToolStripMenuItem.Text = "Racuni";
            this.racuniToolStripMenuItem.Click += new System.EventHandler(this.racuniToolStripMenuItem_Click);
            // 
            // opremaToolStripMenuItem
            // 
            this.opremaToolStripMenuItem.Name = "opremaToolStripMenuItem";
            this.opremaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.opremaToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.opremaToolStripMenuItem.Text = "Oprema";
            this.opremaToolStripMenuItem.Click += new System.EventHandler(this.opremaToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazVozilaToolStripMenuItem,
            this.novoVoziloToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // prikazVozilaToolStripMenuItem
            // 
            this.prikazVozilaToolStripMenuItem.Name = "prikazVozilaToolStripMenuItem";
            this.prikazVozilaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.prikazVozilaToolStripMenuItem.Text = "Prikaz vozila";
            this.prikazVozilaToolStripMenuItem.Click += new System.EventHandler(this.prikazVozilaToolStripMenuItem_Click);
            // 
            // novoVoziloToolStripMenuItem
            // 
            this.novoVoziloToolStripMenuItem.Name = "novoVoziloToolStripMenuItem";
            this.novoVoziloToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novoVoziloToolStripMenuItem.Text = "Novo vozilo";
            this.novoVoziloToolStripMenuItem.Click += new System.EventHandler(this.novoVoziloToolStripMenuItem_Click);
            // 
            // modeliToolStripMenuItem
            // 
            this.modeliToolStripMenuItem.Name = "modeliToolStripMenuItem";
            this.modeliToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.modeliToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.modeliToolStripMenuItem.Text = "Modeli";
            this.modeliToolStripMenuItem.Click += new System.EventHandler(this.modeliToolStripMenuItem_Click);
            // 
            // kategorijeVozilaToolStripMenuItem
            // 
            this.kategorijeVozilaToolStripMenuItem.Name = "kategorijeVozilaToolStripMenuItem";
            this.kategorijeVozilaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.kategorijeVozilaToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.kategorijeVozilaToolStripMenuItem.Text = "Kategorije vozila";
            this.kategorijeVozilaToolStripMenuItem.Click += new System.EventHandler(this.kategorijeVozilaToolStripMenuItem_Click);
            // 
            // proizvodjaciToolStripMenuItem
            // 
            this.proizvodjaciToolStripMenuItem.Name = "proizvodjaciToolStripMenuItem";
            this.proizvodjaciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.proizvodjaciToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.proizvodjaciToolStripMenuItem.Text = "Proizvodjaci";
            this.proizvodjaciToolStripMenuItem.Click += new System.EventHandler(this.proizvodjaciToolStripMenuItem_Click);
            // 
            // registracijeVozilaToolStripMenuItem
            // 
            this.registracijeVozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazRegistracijaToolStripMenuItem,
            this.novaRegistracijaToolStripMenuItem});
            this.registracijeVozilaToolStripMenuItem.Name = "registracijeVozilaToolStripMenuItem";
            this.registracijeVozilaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.registracijeVozilaToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.registracijeVozilaToolStripMenuItem.Text = "Registracije vozila";
            // 
            // prikazRegistracijaToolStripMenuItem
            // 
            this.prikazRegistracijaToolStripMenuItem.Name = "prikazRegistracijaToolStripMenuItem";
            this.prikazRegistracijaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.prikazRegistracijaToolStripMenuItem.Text = "Prikaz registracija";
            this.prikazRegistracijaToolStripMenuItem.Click += new System.EventHandler(this.prikazRegistracijaToolStripMenuItem_Click);
            // 
            // novaRegistracijaToolStripMenuItem
            // 
            this.novaRegistracijaToolStripMenuItem.Name = "novaRegistracijaToolStripMenuItem";
            this.novaRegistracijaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novaRegistracijaToolStripMenuItem.Text = "Nova registracija";
            this.novaRegistracijaToolStripMenuItem.Click += new System.EventHandler(this.novaRegistracijaToolStripMenuItem_Click);
            // 
            // osiguranjaToolStripMenuItem
            // 
            this.osiguranjaToolStripMenuItem.Name = "osiguranjaToolStripMenuItem";
            this.osiguranjaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.osiguranjaToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.osiguranjaToolStripMenuItem.Text = "Osiguranja";
            this.osiguranjaToolStripMenuItem.Click += new System.EventHandler(this.osiguranjaToolStripMenuItem_Click);
            // 
            // lokacijeToolStripMenuItem
            // 
            this.lokacijeToolStripMenuItem.Name = "lokacijeToolStripMenuItem";
            this.lokacijeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.lokacijeToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.lokacijeToolStripMenuItem.Text = "Lokacije";
            this.lokacijeToolStripMenuItem.Click += new System.EventHandler(this.lokacijeToolStripMenuItem_Click);
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            this.gradoviToolStripMenuItem.Click += new System.EventHandler(this.gradoviToolStripMenuItem_Click);
            // 
            // drzaveToolStripMenuItem
            // 
            this.drzaveToolStripMenuItem.Name = "drzaveToolStripMenuItem";
            this.drzaveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.drzaveToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.drzaveToolStripMenuItem.Text = "Drzave";
            this.drzaveToolStripMenuItem.Click += new System.EventHandler(this.drzaveToolStripMenuItem_Click);
            // 
            // novostiToolStripMenuItem
            // 
            this.novostiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazNovostiToolStripMenuItem,
            this.novaNovostToolStripMenuItem});
            this.novostiToolStripMenuItem.Name = "novostiToolStripMenuItem";
            this.novostiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.novostiToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.novostiToolStripMenuItem.Text = "Novosti";
            // 
            // prikazNovostiToolStripMenuItem
            // 
            this.prikazNovostiToolStripMenuItem.Name = "prikazNovostiToolStripMenuItem";
            this.prikazNovostiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.prikazNovostiToolStripMenuItem.Text = "Prikaz novosti";
            this.prikazNovostiToolStripMenuItem.Click += new System.EventHandler(this.prikazNovostiToolStripMenuItem_Click);
            // 
            // novaNovostToolStripMenuItem
            // 
            this.novaNovostToolStripMenuItem.Name = "novaNovostToolStripMenuItem";
            this.novaNovostToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.novaNovostToolStripMenuItem.Text = "Nova novost";
            this.novaNovostToolStripMenuItem.Click += new System.EventHandler(this.novaNovostToolStripMenuItem_Click);
            // 
            // preplateToolStripMenuItem
            // 
            this.preplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazPreplataToolStripMenuItem,
            this.novaPreplataToolStripMenuItem});
            this.preplateToolStripMenuItem.Name = "preplateToolStripMenuItem";
            this.preplateToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.preplateToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.preplateToolStripMenuItem.Text = "Preplate";
            // 
            // prikazPreplataToolStripMenuItem
            // 
            this.prikazPreplataToolStripMenuItem.Name = "prikazPreplataToolStripMenuItem";
            this.prikazPreplataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.prikazPreplataToolStripMenuItem.Text = "Prikaz preplata";
            this.prikazPreplataToolStripMenuItem.Click += new System.EventHandler(this.prikazPreplataToolStripMenuItem_Click);
            // 
            // novaPreplataToolStripMenuItem
            // 
            this.novaPreplataToolStripMenuItem.Name = "novaPreplataToolStripMenuItem";
            this.novaPreplataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.novaPreplataToolStripMenuItem.Text = "Nova preplata";
            this.novaPreplataToolStripMenuItem.Click += new System.EventHandler(this.novaPreplataToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 4);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(130, 733);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1160, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.izvjestajiToolStripMenuItem.Text = "Izvjestaji";
            this.izvjestajiToolStripMenuItem.Click += new System.EventHandler(this.izvjestajiToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 755);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulogeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodjaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijeVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osiguranjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazKupacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem prikazRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazRegistracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKupacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVoziloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRegistracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazNovostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaNovostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazPreplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPreplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
    }
}



