namespace RentACar.WinUI.Pretplate
{
    partial class frmPretplate
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPretplate = new System.Windows.Forms.DataGridView();
            this.PretplataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijaVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategorijeVozila = new System.Windows.Forms.ComboBox();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(528, 40);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 14;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Korisničko ime (kupac)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPretplate);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 281);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretplate";
            // 
            // dgvPretplate
            // 
            this.dgvPretplate.AllowUserToAddRows = false;
            this.dgvPretplate.AllowUserToDeleteRows = false;
            this.dgvPretplate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPretplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PretplataId,
            this.Kupac,
            this.KategorijaVozila,
            this.Datum,
            this.Status});
            this.dgvPretplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPretplate.Location = new System.Drawing.Point(3, 16);
            this.dgvPretplate.Name = "dgvPretplate";
            this.dgvPretplate.ReadOnly = true;
            this.dgvPretplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretplate.Size = new System.Drawing.Size(588, 262);
            this.dgvPretplate.TabIndex = 0;
            this.dgvPretplate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPretplate_CellMouseDoubleClick);
            // 
            // PretplataId
            // 
            this.PretplataId.DataPropertyName = "PretplataId";
            this.PretplataId.HeaderText = "PretplataId";
            this.PretplataId.Name = "PretplataId";
            this.PretplataId.ReadOnly = true;
            this.PretplataId.Visible = false;
            this.PretplataId.Width = 83;
            // 
            // Kupac
            // 
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            this.Kupac.Width = 63;
            // 
            // KategorijaVozila
            // 
            this.KategorijaVozila.DataPropertyName = "KategorijaVozila";
            this.KategorijaVozila.HeaderText = "Kategorija vozila";
            this.KategorijaVozila.Name = "KategorijaVozila";
            this.KategorijaVozila.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 63;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kategorija vozila";
            // 
            // cmbKategorijeVozila
            // 
            this.cmbKategorijeVozila.FormattingEnabled = true;
            this.cmbKategorijeVozila.Location = new System.Drawing.Point(268, 39);
            this.cmbKategorijeVozila.Name = "cmbKategorijeVozila";
            this.cmbKategorijeVozila.Size = new System.Drawing.Size(183, 21);
            this.cmbKategorijeVozila.TabIndex = 15;
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(15, 40);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(183, 20);
            this.txtKupac.TabIndex = 17;
            // 
            // frmPretplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 370);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategorijeVozila);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPretplate";
            this.Text = "frmPretplate";
            this.Load += new System.EventHandler(this.frmPretplate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPretplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategorijeVozila;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretplataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}