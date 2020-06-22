namespace RentACar.WinUI.Rezervacije
{
    partial class frmRezervacijeDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPopust = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.clbOprema = new System.Windows.Forms.CheckedListBox();
            this.cbLokacijaPovrata = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLokacijaPreuzimanja = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOsiguranje = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPovrata = new System.Windows.Forms.DateTimePicker();
            this.dtpPreuzimanja = new System.Windows.Forms.DateTimePicker();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnKupac = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPopust);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.clbOprema);
            this.groupBox1.Controls.Add(this.cbLokacijaPovrata);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbLokacijaPreuzimanja);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbOsiguranje);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNapomena);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpPovrata);
            this.groupBox1.Controls.Add(this.dtpPreuzimanja);
            this.groupBox1.Controls.Add(this.cbVozilo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbKupac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chbStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // numPopust
            // 
            this.numPopust.DecimalPlaces = 2;
            this.numPopust.Location = new System.Drawing.Point(208, 452);
            this.numPopust.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopust.Name = "numPopust";
            this.numPopust.Size = new System.Drawing.Size(120, 20);
            this.numPopust.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Popust";
            // 
            // clbOprema
            // 
            this.clbOprema.FormattingEnabled = true;
            this.clbOprema.Location = new System.Drawing.Point(12, 427);
            this.clbOprema.Name = "clbOprema";
            this.clbOprema.Size = new System.Drawing.Size(171, 79);
            this.clbOprema.TabIndex = 57;
            // 
            // cbLokacijaPovrata
            // 
            this.cbLokacijaPovrata.FormattingEnabled = true;
            this.cbLokacijaPovrata.Location = new System.Drawing.Point(12, 240);
            this.cbLokacijaPovrata.Name = "cbLokacijaPovrata";
            this.cbLokacijaPovrata.Size = new System.Drawing.Size(367, 21);
            this.cbLokacijaPovrata.TabIndex = 56;
            this.cbLokacijaPovrata.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Lokacija povrata";
            // 
            // cbLokacijaPreuzimanja
            // 
            this.cbLokacijaPreuzimanja.FormattingEnabled = true;
            this.cbLokacijaPreuzimanja.Location = new System.Drawing.Point(12, 189);
            this.cbLokacijaPreuzimanja.Name = "cbLokacijaPreuzimanja";
            this.cbLokacijaPreuzimanja.Size = new System.Drawing.Size(367, 21);
            this.cbLokacijaPreuzimanja.TabIndex = 54;
            this.cbLokacijaPreuzimanja.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Lokacija preuzimanja";
            // 
            // cbOsiguranje
            // 
            this.cbOsiguranje.FormattingEnabled = true;
            this.cbOsiguranje.Location = new System.Drawing.Point(12, 140);
            this.cbOsiguranje.Name = "cbOsiguranje";
            this.cbOsiguranje.Size = new System.Drawing.Size(367, 21);
            this.cbOsiguranje.TabIndex = 52;
            this.cbOsiguranje.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Osigurnaje";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(12, 350);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(365, 61);
            this.txtNapomena.TabIndex = 50;
            this.txtNapomena.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Napomena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Datum povrata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Datum preuzimanja";
            // 
            // dtpPovrata
            // 
            this.dtpPovrata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPovrata.Location = new System.Drawing.Point(208, 296);
            this.dtpPovrata.Name = "dtpPovrata";
            this.dtpPovrata.Size = new System.Drawing.Size(171, 20);
            this.dtpPovrata.TabIndex = 46;
            this.dtpPovrata.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_Validating);
            // 
            // dtpPreuzimanja
            // 
            this.dtpPreuzimanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPreuzimanja.Location = new System.Drawing.Point(12, 296);
            this.dtpPreuzimanja.Name = "dtpPreuzimanja";
            this.dtpPreuzimanja.Size = new System.Drawing.Size(171, 20);
            this.dtpPreuzimanja.TabIndex = 45;
            this.dtpPreuzimanja.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_Validating);
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(12, 94);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(367, 21);
            this.cbVozilo.TabIndex = 44;
            this.cbVozilo.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kupac";
            // 
            // cbKupac
            // 
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(12, 42);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(367, 21);
            this.cbKupac.TabIndex = 40;
            this.cbKupac.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Vozilo";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Checked = true;
            this.chbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatus.Location = new System.Drawing.Point(208, 489);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(62, 17);
            this.chbStatus.TabIndex = 36;
            this.chbStatus.Text = "Aktivna";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(319, 546);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(88, 32);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnKupac
            // 
            this.btnKupac.Location = new System.Drawing.Point(10, 546);
            this.btnKupac.Name = "btnKupac";
            this.btnKupac.Size = new System.Drawing.Size(88, 32);
            this.btnKupac.TabIndex = 3;
            this.btnKupac.Text = "Novi Kupac";
            this.btnKupac.UseVisualStyleBackColor = true;
            this.btnKupac.Click += new System.EventHandler(this.btnKupac_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 590);
            this.Controls.Add(this.btnKupac);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacijeDetalji";
            this.Text = "frmRezervacijeDetalji";
            this.Load += new System.EventHandler(this.frmRezervacijeDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnKupac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPovrata;
        private System.Windows.Forms.DateTimePicker dtpPreuzimanja;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLokacijaPovrata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLokacijaPreuzimanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOsiguranje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbOprema;
        private System.Windows.Forms.NumericUpDown numPopust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}