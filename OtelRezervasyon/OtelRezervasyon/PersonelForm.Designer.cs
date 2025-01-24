namespace OtelRezervasyon
{
    partial class PersonelForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOdaArama = new System.Windows.Forms.Button();
            this.btnRezervasyonlar = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdaArama
            // 
            this.btnOdaArama.BackColor = System.Drawing.Color.LightGray;
            this.btnOdaArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOdaArama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdaArama.ForeColor = System.Drawing.Color.Maroon;
            this.btnOdaArama.Location = new System.Drawing.Point(490, 310);
            this.btnOdaArama.Name = "btnOdaArama";
            this.btnOdaArama.Size = new System.Drawing.Size(212, 80);
            this.btnOdaArama.TabIndex = 0;
            this.btnOdaArama.Text = "ODA ARAMA";
            this.btnOdaArama.UseVisualStyleBackColor = false;
            this.btnOdaArama.Click += new System.EventHandler(this.btnOdaArama_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.BackColor = System.Drawing.Color.LightGray;
            this.btnRezervasyonlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRezervasyonlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonlar.ForeColor = System.Drawing.Color.Maroon;
            this.btnRezervasyonlar.Location = new System.Drawing.Point(721, 310);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(212, 80);
            this.btnRezervasyonlar.TabIndex = 1;
            this.btnRezervasyonlar.Text = "REZERVASYON OLUŞTURMA";
            this.btnRezervasyonlar.UseVisualStyleBackColor = false;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.LightGray;
            this.btnCikisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisYap.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikisYap.Location = new System.Drawing.Point(632, 436);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(161, 64);
            this.btnCikisYap.TabIndex = 2;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelRezervasyon.Properties.Resources._30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 688);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnOdaArama);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnOdaArama;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnCikisYap;
    }
}