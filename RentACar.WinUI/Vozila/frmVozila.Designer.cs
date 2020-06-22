namespace RentACar.WinUI.Vozila
{
    partial class frmVozila
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModeli = new System.Windows.Forms.ComboBox();
            this.cmbKategorijeVozila = new System.Windows.Forms.ComboBox();
            this.cmbLokacije = new System.Windows.Forms.ComboBox();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VoziloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijaVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmisija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSasije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategorije vozila";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Model";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(864, 109);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVozila);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 339);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozila";
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoziloId,
            this.Model,
            this.KategorijaVozila,
            this.Lokacija,
            this.Cijena,
            this.Gorivo,
            this.Snaga,
            this.Transmisija,
            this.BrojVrata,
            this.BrojSjedista,
            this.BrojSasije,
            this.GodinaProizvodnje,
            this.Status});
            this.dgvVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVozila.Location = new System.Drawing.Point(3, 16);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(924, 320);
            this.dgvVozila.TabIndex = 0;
            this.dgvVozila.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVozila_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lokacija";
            // 
            // cmbModeli
            // 
            this.cmbModeli.FormattingEnabled = true;
            this.cmbModeli.Location = new System.Drawing.Point(12, 41);
            this.cmbModeli.Name = "cmbModeli";
            this.cmbModeli.Size = new System.Drawing.Size(260, 21);
            this.cmbModeli.TabIndex = 20;
            // 
            // cmbKategorijeVozila
            // 
            this.cmbKategorijeVozila.FormattingEnabled = true;
            this.cmbKategorijeVozila.Location = new System.Drawing.Point(431, 43);
            this.cmbKategorijeVozila.Name = "cmbKategorijeVozila";
            this.cmbKategorijeVozila.Size = new System.Drawing.Size(260, 21);
            this.cmbKategorijeVozila.TabIndex = 21;
            // 
            // cmbLokacije
            // 
            this.cmbLokacije.FormattingEnabled = true;
            this.cmbLokacije.Location = new System.Drawing.Point(12, 111);
            this.cmbLokacije.Name = "cmbLokacije";
            this.cmbLokacije.Size = new System.Drawing.Size(260, 21);
            this.cmbLokacije.TabIndex = 22;
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(431, 112);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(260, 20);
            this.txtBrojSasije.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Broj šasije";
            // 
            // VoziloId
            // 
            this.VoziloId.DataPropertyName = "VoziloId";
            this.VoziloId.HeaderText = "VoziloId";
            this.VoziloId.Name = "VoziloId";
            this.VoziloId.ReadOnly = true;
            this.VoziloId.Visible = false;
            this.VoziloId.Width = 69;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 61;
            // 
            // KategorijaVozila
            // 
            this.KategorijaVozila.DataPropertyName = "KategorijaVozila";
            this.KategorijaVozila.HeaderText = "Kategorija vozila";
            this.KategorijaVozila.Name = "KategorijaVozila";
            this.KategorijaVozila.ReadOnly = true;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            this.Lokacija.Width = 72;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 61;
            // 
            // Gorivo
            // 
            this.Gorivo.DataPropertyName = "Gorivo";
            this.Gorivo.HeaderText = "Gorivo";
            this.Gorivo.Name = "Gorivo";
            this.Gorivo.ReadOnly = true;
            this.Gorivo.Width = 63;
            // 
            // Snaga
            // 
            this.Snaga.DataPropertyName = "Snaga";
            this.Snaga.HeaderText = "Snaga(KW)";
            this.Snaga.Name = "Snaga";
            this.Snaga.ReadOnly = true;
            this.Snaga.Width = 87;
            // 
            // Transmisija
            // 
            this.Transmisija.DataPropertyName = "Transmisija";
            this.Transmisija.HeaderText = "Transmisija";
            this.Transmisija.Name = "Transmisija";
            this.Transmisija.ReadOnly = true;
            this.Transmisija.Width = 84;
            // 
            // BrojVrata
            // 
            this.BrojVrata.DataPropertyName = "BrojVrata";
            this.BrojVrata.HeaderText = "Broj vrata";
            this.BrojVrata.Name = "BrojVrata";
            this.BrojVrata.ReadOnly = true;
            this.BrojVrata.Width = 71;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedišta";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Width = 81;
            // 
            // BrojSasije
            // 
            this.BrojSasije.DataPropertyName = "BrojSasije";
            this.BrojSasije.HeaderText = "Broj šasije";
            this.BrojSasije.Name = "BrojSasije";
            this.BrojSasije.ReadOnly = true;
            this.BrojSasije.Width = 73;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            this.GodinaProizvodnje.HeaderText = "Godina proizvodnje";
            this.GodinaProizvodnje.Name = "GodinaProizvodnje";
            this.GodinaProizvodnje.ReadOnly = true;
            this.GodinaProizvodnje.Width = 113;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 43;
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.cmbLokacije);
            this.Controls.Add(this.cmbKategorijeVozila);
            this.Controls.Add(this.cmbModeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVozila";
            this.Text = "frmVozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModeli;
        private System.Windows.Forms.ComboBox cmbKategorijeVozila;
        private System.Windows.Forms.ComboBox cmbLokacije;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoziloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmisija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSasije;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaProizvodnje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}