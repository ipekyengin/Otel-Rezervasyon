namespace OtelRezervasyon
{
    partial class OdaIslemleriForm
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
            this.dataGridViewOdaListesi = new System.Windows.Forms.DataGridView();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.btnOdaDuzenle = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdaListesi
            // 
            this.dataGridViewOdaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdaListesi.Location = new System.Drawing.Point(380, 14);
            this.dataGridViewOdaListesi.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewOdaListesi.Name = "dataGridViewOdaListesi";
            this.dataGridViewOdaListesi.RowHeadersWidth = 51;
            this.dataGridViewOdaListesi.RowTemplate.Height = 24;
            this.dataGridViewOdaListesi.Size = new System.Drawing.Size(968, 603);
            this.dataGridViewOdaListesi.TabIndex = 0;
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(161, 74);
            this.cmbOdaTipi.Margin = new System.Windows.Forms.Padding(5);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(209, 33);
            this.cmbOdaTipi.TabIndex = 2;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(161, 135);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(209, 33);
            this.cmbDurum.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(161, 184);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(209, 34);
            this.txtFiyat.TabIndex = 4;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(16, 23);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(104, 25);
            this.lblOdaNo.TabIndex = 5;
            this.lblOdaNo.Text = "Oda NO:";
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.Location = new System.Drawing.Point(16, 82);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(107, 25);
            this.lblOdaTipi.TabIndex = 5;
            this.lblOdaTipi.Text = "Oda Tipi:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(31, 143);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(92, 25);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(52, 193);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(71, 25);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(161, 226);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(209, 55);
            this.btnOdaEkle.TabIndex = 6;
            this.btnOdaEkle.Text = "ODA EKLE";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // btnOdaDuzenle
            // 
            this.btnOdaDuzenle.Location = new System.Drawing.Point(161, 287);
            this.btnOdaDuzenle.Name = "btnOdaDuzenle";
            this.btnOdaDuzenle.Size = new System.Drawing.Size(209, 55);
            this.btnOdaDuzenle.TabIndex = 6;
            this.btnOdaDuzenle.Text = "ODA DÜZENLE";
            this.btnOdaDuzenle.UseVisualStyleBackColor = true;
            this.btnOdaDuzenle.Click += new System.EventHandler(this.btnOdaDuzenle_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Location = new System.Drawing.Point(161, 348);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(209, 55);
            this.btnOdaSil.TabIndex = 6;
            this.btnOdaSil.Text = "ODA SİL";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(161, 23);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(209, 33);
            this.cmbOdaNo.TabIndex = 7;
            // 
            // OdaIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 631);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.btnOdaDuzenle);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblOdaTipi);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.dataGridViewOdaListesi);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OdaIslemleriForm";
            this.Text = "OdaIslemleriForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OdaIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdaListesi;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.Button btnOdaDuzenle;
        private System.Windows.Forms.Button btnOdaSil;
        private System.Windows.Forms.ComboBox cmbOdaNo;
    }
}