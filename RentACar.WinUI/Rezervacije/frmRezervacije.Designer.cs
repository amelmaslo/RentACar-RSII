namespace RentACar.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLokacijaPreuzimanja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokacijaPreuzimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokacijaPovrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osiguranje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oprema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPreuzimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPovrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranjaRezervacij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.cmbLokacijaPovrata = new System.Windows.Forms.ComboBox();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Lokacija povrata";
            // 
            // cmbLokacijaPreuzimanja
            // 
            this.cmbLokacijaPreuzimanja.FormattingEnabled = true;
            this.cmbLokacijaPreuzimanja.Location = new System.Drawing.Point(431, 32);
            this.cmbLokacijaPreuzimanja.Name = "cmbLokacijaPreuzimanja";
            this.cmbLokacijaPreuzimanja.Size = new System.Drawing.Size(260, 21);
            this.cmbLokacijaPreuzimanja.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Korisničko ime kupca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lokacija preuzimanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vozilo";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(864, 99);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 26;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 339);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.Kupac,
            this.Vozilo,
            this.LokacijaPreuzimanja,
            this.LokacijaPovrata,
            this.Osiguranje,
            this.Oprema,
            this.DatumPreuzimanja,
            this.DatumPovrata,
            this.DatumKreiranjaRezervacij,
            this.Napomena,
            this.Status});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije.Location = new System.Drawing.Point(3, 16);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(924, 320);
            this.dgvRezervacije.TabIndex = 0;
            this.dgvRezervacije.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRezervacije_CellMouseDoubleClick);
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            this.RezervacijaId.Width = 97;
            // 
            // Kupac
            // 
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            this.Kupac.Width = 63;
            // 
            // Vozilo
            // 
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            this.Vozilo.Width = 60;
            // 
            // LokacijaPreuzimanja
            // 
            this.LokacijaPreuzimanja.DataPropertyName = "LokacijaPreuzimanja";
            this.LokacijaPreuzimanja.HeaderText = "Lokacija preuzimanja";
            this.LokacijaPreuzimanja.Name = "LokacijaPreuzimanja";
            this.LokacijaPreuzimanja.ReadOnly = true;
            this.LokacijaPreuzimanja.Width = 120;
            // 
            // LokacijaPovrata
            // 
            this.LokacijaPovrata.DataPropertyName = "LokacijaPovrata";
            this.LokacijaPovrata.HeaderText = "Lokacija povrata";
            this.LokacijaPovrata.Name = "LokacijaPovrata";
            this.LokacijaPovrata.ReadOnly = true;
            this.LokacijaPovrata.Width = 102;
            // 
            // Osiguranje
            // 
            this.Osiguranje.DataPropertyName = "Osiguranje";
            this.Osiguranje.HeaderText = "Osiguranje";
            this.Osiguranje.Name = "Osiguranje";
            this.Osiguranje.ReadOnly = true;
            this.Osiguranje.Width = 82;
            // 
            // Oprema
            // 
            this.Oprema.DataPropertyName = "Oprema";
            this.Oprema.HeaderText = "Oprema";
            this.Oprema.Name = "Oprema";
            this.Oprema.ReadOnly = true;
            this.Oprema.Width = 69;
            // 
            // DatumPreuzimanja
            // 
            this.DatumPreuzimanja.DataPropertyName = "DatumPreuzimanja";
            this.DatumPreuzimanja.HeaderText = "Datum preuzimanja";
            this.DatumPreuzimanja.Name = "DatumPreuzimanja";
            this.DatumPreuzimanja.ReadOnly = true;
            this.DatumPreuzimanja.Width = 112;
            // 
            // DatumPovrata
            // 
            this.DatumPovrata.DataPropertyName = "DatumPovrata";
            this.DatumPovrata.HeaderText = "Datum povrata";
            this.DatumPovrata.Name = "DatumPovrata";
            this.DatumPovrata.ReadOnly = true;
            this.DatumPovrata.Width = 94;
            // 
            // DatumKreiranjaRezervacij
            // 
            this.DatumKreiranjaRezervacij.DataPropertyName = "DatumKreiranjaRezervacij";
            this.DatumKreiranjaRezervacij.HeaderText = "Datum kreiranja rezervacije";
            this.DatumKreiranjaRezervacij.Name = "DatumKreiranjaRezervacij";
            this.DatumKreiranjaRezervacij.ReadOnly = true;
            this.DatumKreiranjaRezervacij.Width = 146;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 84;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 43;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(12, 101);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(260, 20);
            this.txtKorisnickoIme.TabIndex = 35;
            // 
            // cmbLokacijaPovrata
            // 
            this.cmbLokacijaPovrata.FormattingEnabled = true;
            this.cmbLokacijaPovrata.Location = new System.Drawing.Point(431, 101);
            this.cmbLokacijaPovrata.Name = "cmbLokacijaPovrata";
            this.cmbLokacijaPovrata.Size = new System.Drawing.Size(260, 21);
            this.cmbLokacijaPovrata.TabIndex = 36;
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(12, 33);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(260, 20);
            this.txtVozilo.TabIndex = 37;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 495);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.cmbLokacijaPovrata);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLokacijaPreuzimanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLokacijaPreuzimanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.ComboBox cmbLokacijaPovrata;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaPreuzimanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaPovrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osiguranje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oprema;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPreuzimanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPovrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranjaRezervacij;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}