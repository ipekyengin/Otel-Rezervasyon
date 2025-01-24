using OtelRezervasyon.DAL;
using System;
using System.Linq;
using System.Windows.Forms;
using static OtelRezervasyon.DAL.DatabaseHelper;
using OtelRezervasyon.Helpers;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace OtelRezervasyon
{
    public partial class RezervasyonlarForm : Form
    {
        private DatabaseHelper _databaseHelper;

        public RezervasyonlarForm()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void RezervasyonlarForm_Load(object sender, EventArgs e)
        {
            // Oda numaralarını ComboBox'a yükle
            LoadOdaNumaralari();

            // Rezervasyon listesini DataGridView'e yükle
            LoadReservations();
        }
        private void LoadOdaNumaralari()
        {
            try
            {
                // Oda numaralarını veritabanından al
                List<string> odaNumaralari = _databaseHelper.LoadOdaNumbers();  // Veritabanından oda numaralarını alıyoruz

                // Combobox'ı temizle
                cmbOdaNo.Items.Clear();

                // Oda numaralarını combobox'a ekle
                foreach (string odaNo in odaNumaralari)
                {
                    cmbOdaNo.Items.Add(odaNo);
                }

                // Combobox'ı ilk öğe ile seçili yap
                if (cmbOdaNo.Items.Count > 0)
                {
                    cmbOdaNo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda numaraları yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadReservations()
        {
            try
            {
                // Veritabanından rezervasyonları al ve DataGridView'e yükle
                var rezervasyonListesi = _databaseHelper.GetReservationList();
                dataGridViewRezervasyonlar.DataSource = null;
                dataGridViewRezervasyonlar.DataSource = rezervasyonListesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki alanlardan verileri al
                string odaNo = cmbOdaNo.SelectedItem?.ToString();
                string adSoyad = txtAdSoyad.Text;
                string tcKimlikNo = txtTCKimlikNo.Text;
                string telefonNo = txtTelefonNo.Text;
                string email = txtEmail.Text;
                string adres = txtAdres.Text;
                DateTime girisTarihi = dtpGirisTarihi.Value;
                DateTime cikisTarihi = dtpCikisTarihi.Value;

                // Giriş doğrulaması yap
                if (string.IsNullOrEmpty(odaNo) || string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(tcKimlikNo))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (girisTarihi >= cikisTarihi)
                {
                    MessageBox.Show("Giriş tarihi, çıkış tarihinden önce olmalıdır.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Oda ID'sini al
                int odaId = _databaseHelper.GetOdaIdByOdaNo(odaNo);

                // Rezervasyon ekle
                _databaseHelper.AddReservation(
                    odaId,
                    odaNo,
                    adSoyad,
                    tcKimlikNo,
                    telefonNo,
                    email,
                    adres,
                    girisTarihi,
                    cikisTarihi
                );

                // Başarı mesajı ve form temizliği
                MessageBox.Show("Rezervasyon başarıyla yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();

                // Rezervasyon listesini yenile
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon sırasında bir hata oluştu: " + ex.Message);
            }
        }


        private void ClearFormFields()
        {
            cmbOdaNo.SelectedIndex = -1;
            txtAdSoyad.Clear();
            txtTCKimlikNo.Clear();
            txtTelefonNo.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now.AddDays(1);
        }
    }
}