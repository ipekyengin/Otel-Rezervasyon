using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelRezervasyon
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }
        private void btnOdaArama_Click(object sender, EventArgs e)
        {
            // Oda Arama ve Rezervasyon Formu
            OdaAramaForm odaAramaForm = new OdaAramaForm();
            odaAramaForm.Show();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            // Mevcut Rezervasyonları Görüntüleme
            RezervasyonlarForm rezervasyonlarForm = new RezervasyonlarForm();
            rezervasyonlarForm.Show();
        }

        private void btnRezervasyonIptali_Click(object sender, EventArgs e)
        {
            // Rezervasyon İptali Formu
            RezervasyonIptalForm rezervasyonIptaliForm = new RezervasyonIptalForm();
            rezervasyonIptaliForm.Show();
        }

        private void btnOdaIslemleri_Click(object sender, EventArgs e)
        {
            // Oda Ekleme/Düzenleme/Silme Formu
            OdaIslemleriForm odaIslemleriForm = new OdaIslemleriForm();
            odaIslemleriForm.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            // Diğer tüm açık formları kapat
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != form1) // Form1'i kapatmadan diğerlerini kapat
                {
                    form.Close();
                }
            }
        }
    }
}
