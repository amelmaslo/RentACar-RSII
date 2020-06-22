namespace RentACar.WinUI.RegistracijeVozila
{
    partial class frmRegistracijeVozila
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistracijeVozila = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistarskeOznake = new System.Windows.Forms.TextBox();
            this.cbUposlenik = new System.Windows.Forms.ComboBox();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.RegistracijaVozilaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistarskeOznake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrajRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistracijeVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistracijeVozila);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registracije vozila";
            // 
            // dgvRegistracijeVozila
            // 
            this.dgvRegistracijeVozila.AllowUserToAddRows = false;
            this.dgvRegistracijeVozila.AllowUserToDeleteRows = false;
            this.dgvRegistracijeVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRegistracijeVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistracijeVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistracijaVozilaId,
            this.Uposlenik,
            this.Vozilo,
            this.RegistarskeOznake,
            this.PocetakRegistracije,
            this.KrajRegistracije,
            this.Cijena,
            this.Status});
            this.dgvRegistracijeVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistracijeVozila.Location = new System.Drawing.Point(3, 16);
            this.dgvRegistracijeVozila.Name = "dgvRegistracijeVozila";
            this.dgvRegistracijeVozila.ReadOnly = true;
            this.dgvRegistracijeVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistracijeVozila.Size = new System.Drawing.Size(659, 283);
            this.dgvRegistracijeVozila.TabIndex = 0;
            this.dgvRegistracijeVozila.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistracijeVozila_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uposlenik";
            // 
            // txtRegistarskeOznake
            // 
            this.txtRegistarskeOznake.Location = new System.Drawing.Point(305, 26);
            this.txtRegistarskeOznake.Name = "txtRegistarskeOznake";
            this.txtRegistarskeOznake.Size = new System.Drawing.Size(219, 20);
            this.txtRegistarskeOznake.TabIndex = 5;
            // 
            // cbUposlenik
            // 
            this.cbUposlenik.FormattingEnabled = true;
            this.cbUposlenik.Location = new System.Drawing.Point(12, 25);
            this.cbUposlenik.Name = "cbUposlenik";
            this.cbUposlenik.Size = new System.Drawing.Size(219, 21);
            this.cbUposlenik.TabIndex = 6;
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(12, 74);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(219, 21);
            this.cbVozilo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vozilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Registarska oznaka";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(602, 72);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 10;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // RegistracijaVozilaId
            // 
            this.RegistracijaVozilaId.DataPropertyName = "RegistracijaVozilaId";
            this.RegistracijaVozilaId.HeaderText = "RegistracijaVozilaId";
            this.RegistracijaVozilaId.Name = "RegistracijaVozilaId";
            this.RegistracijaVozilaId.ReadOnly = true;
            this.RegistracijaVozilaId.Visible = false;
            this.RegistracijaVozilaId.Width = 124;
            // 
            // Uposlenik
            // 
            this.Uposlenik.DataPropertyName = "Uposlenik";
            this.Uposlenik.HeaderText = "Uposlenik";
            this.Uposlenik.Name = "Uposlenik";
            this.Uposlenik.ReadOnly = true;
            this.Uposlenik.Width = 79;
            // 
            // Vozilo
            // 
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            this.Vozilo.Width = 60;
            // 
            // RegistarskeOznake
            // 
            this.RegistarskeOznake.DataPropertyName = "RegistarskeOznake";
            this.RegistarskeOznake.HeaderText = "Registarske oznake";
            this.RegistarskeOznake.Name = "RegistarskeOznake";
            this.RegistarskeOznake.ReadOnly = true;
            this.RegistarskeOznake.Width = 115;
            // 
            // PocetakRegistracije
            // 
            this.PocetakRegistracije.DataPropertyName = "PocetakRegistracije";
            this.PocetakRegistracije.HeaderText = "Pocetak registracije";
            this.PocetakRegistracije.Name = "PocetakRegistracije";
            this.PocetakRegistracije.ReadOnly = true;
            this.PocetakRegistracije.Width = 114;
            // 
            // KrajRegistracije
            // 
            this.KrajRegistracije.DataPropertyName = "KrajRegistracije";
            this.KrajRegistracije.HeaderText = "Kraj registracije";
            this.KrajRegistracije.Name = "KrajRegistracije";
            this.KrajRegistracije.ReadOnly = true;
            this.KrajRegistracije.Width = 95;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 61;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 43;
            // 
            // frmRegistracijeVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVozilo);
            this.Controls.Add(this.cbUposlenik);
            this.Controls.Add(this.txtRegistarskeOznake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistracijeVozila";
            this.Text = "frmRegistracijeVozila";
            this.Load += new System.EventHandler(this.frmRegistracijeVozila_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistracijeVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRegistracijeVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistarskeOznake;
        private System.Windows.Forms.ComboBox cbUposlenik;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistracijaVozilaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistarskeOznake;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrajRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}