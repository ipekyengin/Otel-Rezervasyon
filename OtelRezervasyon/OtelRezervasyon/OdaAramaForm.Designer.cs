namespace OtelRezervasyon
{
    partial class OdaAramaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOdaListesi;

        private void InitializeComponent()
        {
            this.dataGridViewOdaListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdaListesi
            // 
            this.dataGridViewOdaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdaListesi.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOdaListesi.Name = "dataGridViewOdaListesi";
            this.dataGridViewOdaListesi.RowHeadersWidth = 51;
            this.dataGridViewOdaListesi.RowTemplate.Height = 24;
            this.dataGridViewOdaListesi.Size = new System.Drawing.Size(1332, 653);
            this.dataGridViewOdaListesi.TabIndex = 0;
            // 
            // OdaAramaForm
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1356, 677);
            this.Controls.Add(this.dataGridViewOdaListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OdaAramaForm";
            this.Text = "Oda Arama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OdaAramaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaListesi)).EndInit();
            this.ResumeLayout(false);

        }
    }
}