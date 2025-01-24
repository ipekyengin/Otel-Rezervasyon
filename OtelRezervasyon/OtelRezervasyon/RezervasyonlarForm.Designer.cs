namespace OtelRezervasyon
{
    partial class RezervasyonlarForm
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
            this.dataGridViewRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTcNO = new System.Windows.Forms.Label();
            this.lblTelNO = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervasyonlar
            // 
            this.dataGridViewRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervasyonlar.Location = new System.Drawing.Point(646, 12);
            this.dataGridViewRezervasyonlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRezervasyonlar.Name = "dataGridViewRezervasyonlar";
            this.dataGridViewRezervasyonlar.RowHeadersWidth = 51;
            this.dataGridViewRezervasyonlar.RowTemplate.Height = 24;
            this.dataGridViewRezervasyonlar.Size = new System.Drawing.Size(711, 576);
            this.dataGridViewRezervasyonlar.TabIndex = 0;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblOdaNo.ForeColor = System.Drawing.Color.Tan;
            this.lblOdaNo.Location = new System.Drawing.Point(83, 21);
            this.lblOdaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(104, 25);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "Oda NO:";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisTarihi.ForeColor = System.Drawing.Color.Tan;
            this.lblGirisTarihi.Location = new System.Drawing.Point(56, 71);
            this.lblGirisTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(131, 25);
            this.lblGirisTarihi.TabIndex = 1;
            this.lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.Tan;
            this.lblCikisTarihi.Location = new System.Drawing.Point(53, 117);
            this.lblCikisTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(134, 25);
            this.lblCikisTarihi.TabIndex = 1;
            this.lblCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Tan;
            this.lblAdSoyad.Location = new System.Drawing.Point(71, 248);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(116, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTcNO
            // 
            this.lblTcNO.AutoSize = true;
            this.lblTcNO.BackColor = System.Drawing.Color.Transparent;
            this.lblTcNO.ForeColor = System.Drawing.Color.Tan;
            this.lblTcNO.Location = new System.Drawing.Point(24, 292);
            this.lblTcNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcNO.Name = "lblTcNO";
            this.lblTcNO.Size = new System.Drawing.Size(163, 25);
            this.lblTcNO.TabIndex = 1;
            this.lblTcNO.Text = "TC Kimlik NO:";
            // 
            // lblTelNO
            // 
            this.lblTelNO.AutoSize = true;
            this.lblTelNO.BackColor = System.Drawing.Color.Transparent;
            this.lblTelNO.ForeColor = System.Drawing.Color.Tan;
            this.lblTelNO.Location = new System.Drawing.Point(53, 340);
            this.lblTelNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNO.Name = "lblTelNO";
            this.lblTelNO.Size = new System.Drawing.Size(134, 25);
            this.lblTelNO.TabIndex = 1;
            this.lblTelNO.Text = "Telefon NO:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Tan;
            this.lblEmail.Location = new System.Drawing.Point(111, 389);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.ForeColor = System.Drawing.Color.Tan;
            this.lblAdres.Location = new System.Drawing.Point(108, 435);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(79, 25);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres:";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(214, 61);
            this.dtpGirisTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(412, 34);
            this.dtpGirisTarihi.TabIndex = 2;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(214, 106);
            this.dtpCikisTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(412, 34);
            this.dtpCikisTarihi.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(214, 238);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(412, 34);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(214, 281);
            this.txtTCKimlikNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(412, 34);
            this.txtTCKimlikNo.TabIndex = 4;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(214, 330);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(412, 34);
            this.txtTelefonNo.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 378);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(412, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(214, 427);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(412, 34);
            this.txtAdres.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.Silver;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(332, 484);
            this.btnRezervasyonYap.Margin = new System.Windows.Forms.Padding(5);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(296, 67);
            this.btnRezervasyonYap.TabIndex = 8;
            this.btnRezervasyonYap.Text = "REZERVASYON YAP";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOdaNo.Location = new System.Drawing.Point(214, 13);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(412, 33);
            this.cmbOdaNo.TabIndex = 9;
            // 
            // RezervasyonlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelRezervasyon.Properties.Resources._10270d101990779_5f2bff047f9e2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 600);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelNO);
            this.Controls.Add(this.lblTcNO);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblCikisTarihi);
            this.Controls.Add(this.lblGirisTarihi);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.dataGridViewRezervasyonlar);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RezervasyonlarForm";
            this.Text = "Rezervasyonlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridViewRezervasyonlar;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTcNO;
        private System.Windows.Forms.Label lblTelNO;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.ComboBox cmbOdaNo;
    }
}