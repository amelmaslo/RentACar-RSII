namespace RentACar.WinUI.Vozila
{
    partial class frmVozilaDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbModeli = new System.Windows.Forms.ComboBox();
            this.cbKategorijeVozila = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.txtGodinaProizvodnje = new System.Windows.Forms.MaskedTextBox();
            this.numBrojVrata = new System.Windows.Forms.NumericUpDown();
            this.numBrojSjedista = new System.Windows.Forms.NumericUpDown();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.txtTransmisija = new System.Windows.Forms.TextBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Vozilo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSnaga = new System.Windows.Forms.TextBox();
            this.cbLokacije = new System.Windows.Forms.ComboBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojVrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.Vozilo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // cbModeli
            // 
            this.cbModeli.FormattingEnabled = true;
            this.cbModeli.Location = new System.Drawing.Point(6, 41);
            this.cbModeli.Name = "cbModeli";
            this.cbModeli.Size = new System.Drawing.Size(255, 21);
            this.cbModeli.TabIndex = 1;
            this.cbModeli.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // cbKategorijeVozila
            // 
            this.cbKategorijeVozila.FormattingEnabled = true;
            this.cbKategorijeVozila.Location = new System.Drawing.Point(6, 93);
            this.cbKategorijeVozila.Name = "cbKategorijeVozila";
            this.cbKategorijeVozila.Size = new System.Drawing.Size(255, 21);
            this.cbKategorijeVozila.TabIndex = 3;
            this.cbKategorijeVozila.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategorija vozila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lokacija";
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(6, 408);
            this.numCijena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(252, 20);
            this.numCijena.TabIndex = 6;
            this.numCijena.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(137, 359);
            this.txtGodinaProizvodnje.Mask = "0000";
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(121, 20);
            this.txtGodinaProizvodnje.TabIndex = 7;
            this.txtGodinaProizvodnje.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaProizvodnje_Validating);
            // 
            // numBrojVrata
            // 
            this.numBrojVrata.Location = new System.Drawing.Point(6, 253);
            this.numBrojVrata.Name = "numBrojVrata";
            this.numBrojVrata.Size = new System.Drawing.Size(120, 20);
            this.numBrojVrata.TabIndex = 8;
            this.numBrojVrata.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // numBrojSjedista
            // 
            this.numBrojSjedista.Location = new System.Drawing.Point(140, 253);
            this.numBrojSjedista.Name = "numBrojSjedista";
            this.numBrojSjedista.Size = new System.Drawing.Size(120, 20);
            this.numBrojSjedista.TabIndex = 9;
            this.numBrojSjedista.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(140, 306);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(118, 20);
            this.txtGorivo.TabIndex = 10;
            this.txtGorivo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(6, 197);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(256, 20);
            this.txtBrojSasije.TabIndex = 11;
            this.txtBrojSasije.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtTransmisija
            // 
            this.txtTransmisija.Location = new System.Drawing.Point(6, 359);
            this.txtTransmisija.Name = "txtTransmisija";
            this.txtTransmisija.Size = new System.Drawing.Size(118, 20);
            this.txtTransmisija.TabIndex = 12;
            this.txtTransmisija.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Checked = true;
            this.chbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatus.Location = new System.Drawing.Point(292, 253);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(62, 17);
            this.chbStatus.TabIndex = 13;
            this.chbStatus.Text = "Aktivan";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(292, 197);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.ReadOnly = true;
            this.txtSlika.Size = new System.Drawing.Size(192, 20);
            this.txtSlika.TabIndex = 14;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(292, 41);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(192, 125);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 15;
            this.pbSlika.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cijena(€)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj vrata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Broj sjedišta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Godina proizvodnje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Broj šasije";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gorivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Transmisija";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Slika";
            // 
            // Vozilo
            // 
            this.Vozilo.Controls.Add(this.label12);
            this.Vozilo.Controls.Add(this.txtSnaga);
            this.Vozilo.Controls.Add(this.cbLokacije);
            this.Vozilo.Controls.Add(this.btnSlika);
            this.Vozilo.Controls.Add(this.txtSlika);
            this.Vozilo.Controls.Add(this.chbStatus);
            this.Vozilo.Controls.Add(this.pbSlika);
            this.Vozilo.Controls.Add(this.label11);
            this.Vozilo.Controls.Add(this.label1);
            this.Vozilo.Controls.Add(this.label8);
            this.Vozilo.Controls.Add(this.cbModeli);
            this.Vozilo.Controls.Add(this.label9);
            this.Vozilo.Controls.Add(this.label2);
            this.Vozilo.Controls.Add(this.label10);
            this.Vozilo.Controls.Add(this.cbKategorijeVozila);
            this.Vozilo.Controls.Add(this.label7);
            this.Vozilo.Controls.Add(this.label3);
            this.Vozilo.Controls.Add(this.label6);
            this.Vozilo.Controls.Add(this.label5);
            this.Vozilo.Controls.Add(this.numCijena);
            this.Vozilo.Controls.Add(this.label4);
            this.Vozilo.Controls.Add(this.txtGodinaProizvodnje);
            this.Vozilo.Controls.Add(this.numBrojVrata);
            this.Vozilo.Controls.Add(this.numBrojSjedista);
            this.Vozilo.Controls.Add(this.txtGorivo);
            this.Vozilo.Controls.Add(this.txtTransmisija);
            this.Vozilo.Controls.Add(this.txtBrojSasije);
            this.Vozilo.Location = new System.Drawing.Point(12, 12);
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.Size = new System.Drawing.Size(499, 436);
            this.Vozilo.TabIndex = 24;
            this.Vozilo.TabStop = false;
            this.Vozilo.Text = "Vozilo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Snaga(KW)";
            // 
            // txtSnaga
            // 
            this.txtSnaga.Location = new System.Drawing.Point(6, 306);
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.Size = new System.Drawing.Size(118, 20);
            this.txtSnaga.TabIndex = 26;
            this.txtSnaga.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // cbLokacije
            // 
            this.cbLokacije.FormattingEnabled = true;
            this.cbLokacije.Location = new System.Drawing.Point(6, 145);
            this.cbLokacije.Name = "cbLokacije";
            this.cbLokacije.Size = new System.Drawing.Size(255, 21);
            this.cbLokacije.TabIndex = 25;
            this.cbLokacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(409, 228);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 24;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(425, 454);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(86, 36);
            this.btnSacuvaj.TabIndex = 25;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmVozilaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 497);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.Vozilo);
            this.Name = "frmVozilaDetalji";
            this.Text = "frmVozilaDetalji";
            this.Load += new System.EventHandler(this.frmVozilaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojVrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.Vozilo.ResumeLayout(false);
            this.Vozilo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModeli;
        private System.Windows.Forms.ComboBox cbKategorijeVozila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.MaskedTextBox txtGodinaProizvodnje;
        private System.Windows.Forms.NumericUpDown numBrojVrata;
        private System.Windows.Forms.NumericUpDown numBrojSjedista;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.TextBox txtTransmisija;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox Vozilo;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbLokacije;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSnaga;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}