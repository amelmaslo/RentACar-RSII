namespace RentACar.WinUI.Racuni
{
    partial class frmRacuni
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.RacunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznajmljivanjeVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpremaUkupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsiguranjeUkupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(683, 39);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRacuni);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 339);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RacunId,
            this.BrojRacuna,
            this.KorisnickoIme,
            this.Vozilo,
            this.BrojDana,
            this.IznajmljivanjeVozila,
            this.OpremaUkupno,
            this.OsiguranjeUkupno,
            this.Popust,
            this.Datum,
            this.Pdv,
            this.IznosBezPdv,
            this.IznosSaPdv,
            this.Status});
            this.dgvRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuni.Location = new System.Drawing.Point(3, 16);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(740, 320);
            this.dgvRacuni.TabIndex = 0;
            this.dgvRacuni.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRacuni_CellMouseDoubleClick);
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(463, 42);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(159, 20);
            this.txtVozilo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vozilo";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(230, 42);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(159, 20);
            this.txtKorisnickoIme.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Broj racuna";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(15, 42);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(159, 20);
            this.txtBrojRacuna.TabIndex = 12;
            // 
            // RacunId
            // 
            this.RacunId.DataPropertyName = "RacunId";
            this.RacunId.HeaderText = "RacunId";
            this.RacunId.Name = "RacunId";
            this.RacunId.ReadOnly = true;
            this.RacunId.Visible = false;
            this.RacunId.Width = 73;
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.DataPropertyName = "BrojRacuna";
            this.BrojRacuna.HeaderText = "Broj racuna";
            this.BrojRacuna.Name = "BrojRacuna";
            this.BrojRacuna.ReadOnly = true;
            this.BrojRacuna.Width = 86;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Vozilo
            // 
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            this.Vozilo.Width = 60;
            // 
            // BrojDana
            // 
            this.BrojDana.DataPropertyName = "BrojDana";
            this.BrojDana.HeaderText = "Broj dana";
            this.BrojDana.Name = "BrojDana";
            this.BrojDana.ReadOnly = true;
            this.BrojDana.Width = 77;
            // 
            // IznajmljivanjeVozila
            // 
            this.IznajmljivanjeVozila.DataPropertyName = "IznajmljivanjeVozila";
            this.IznajmljivanjeVozila.HeaderText = "Cijena iznajmljivanja";
            this.IznajmljivanjeVozila.Name = "IznajmljivanjeVozila";
            this.IznajmljivanjeVozila.ReadOnly = true;
            this.IznajmljivanjeVozila.Width = 114;
            // 
            // OpremaUkupno
            // 
            this.OpremaUkupno.DataPropertyName = "OpremaUkupno";
            this.OpremaUkupno.HeaderText = "Cijena opreme";
            this.OpremaUkupno.Name = "OpremaUkupno";
            this.OpremaUkupno.ReadOnly = true;
            this.OpremaUkupno.Width = 91;
            // 
            // OsiguranjeUkupno
            // 
            this.OsiguranjeUkupno.DataPropertyName = "OsiguranjeUkupno";
            this.OsiguranjeUkupno.HeaderText = "Cijena osiguranja";
            this.OsiguranjeUkupno.Name = "OsiguranjeUkupno";
            this.OsiguranjeUkupno.ReadOnly = true;
            this.OsiguranjeUkupno.Width = 103;
            // 
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            this.Popust.Width = 65;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 63;
            // 
            // Pdv
            // 
            this.Pdv.DataPropertyName = "Pdv";
            this.Pdv.HeaderText = "PDV";
            this.Pdv.Name = "Pdv";
            this.Pdv.ReadOnly = true;
            this.Pdv.Width = 54;
            // 
            // IznosBezPdv
            // 
            this.IznosBezPdv.DataPropertyName = "IznosBezPdv";
            this.IznosBezPdv.HeaderText = "Ukupno (bez PDV)";
            this.IznosBezPdv.Name = "IznosBezPdv";
            this.IznosBezPdv.ReadOnly = true;
            this.IznosBezPdv.Width = 88;
            // 
            // IznosSaPdv
            // 
            this.IznosSaPdv.DataPropertyName = "IznosSaPdv";
            this.IznosSaPdv.HeaderText = "Ukupno";
            this.IznosSaPdv.Name = "IznosSaPdv";
            this.IznosSaPdv.ReadOnly = true;
            this.IznosSaPdv.Width = 70;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 62;
            // 
            // frmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRacuni";
            this.Text = "frmRacuni";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznajmljivanjeVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpremaUkupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsiguranjeUkupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPdv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}