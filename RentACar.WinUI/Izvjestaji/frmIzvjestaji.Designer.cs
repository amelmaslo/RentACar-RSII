namespace RentACar.WinUI.Izvjestaji
{
    partial class frmIzvjestaji
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVozilo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 99);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kreiraj izvještaj";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(214, 120);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 4;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vozilo";
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(28, 50);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(221, 21);
            this.cbVozilo.TabIndex = 32;
            this.cbVozilo.Validating += new System.ComponentModel.CancelEventHandler(this.cbVozilo_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 152);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOdaberi);
            this.Name = "frmIzvjestaji";
            this.Text = "frmIzvjestaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}