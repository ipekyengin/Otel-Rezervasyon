using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyon.DAL;

namespace OtelRezervasyon
{
    public partial class OdaIslemleriForm : Form
    {
        private DatabaseHelper _databaseHelper;

        public OdaIslemleriForm()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void OdaIslemleriForm_Load(object sender, EventArgs e)
        {
            // Oda listelerini veritabanından çekip DataGridView'e yükle
            LoadRoomData();

            // Oda Tipi ve Durum ComboBox'larını dolduralım
            cmbOdaTipi.Items.Add("Tek Kişilik");
            cmbOdaTipi.Items.Add("Çift Kişilik");
            cmbOdaTipi.Items.Add("Suit");
            cmbDurum.Items.Add("Müsait");
            cmbDurum.Items.Add("Dolu");

            cmbOdaTipi.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;

            LoadRoomNumbers();

            cmbOdaTipi.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;
            cmbOdaNo.SelectedIndex = -1;  // Oda numarası combo-box'ı için başlangıç seçimi

        }

        private void LoadRoomNumbers()
        {
            try
            {
                // Veritabanından oda numaralarını alıyoruz
                var odaListesi = _databaseHelper.GetOdaList();
                cmbOdaNo.Items.Clear();  // Önce oda numaralarını sıfırlayalım
                foreach (var oda in odaListesi)
                {
                    cmbOdaNo.Items.Add(oda.OdaNo);  // Oda numarasını ComboBox'a ekle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda numaraları yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private bool ValidateRoomInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (cmbOdaNo.SelectedItem == null)  // Oda numarası seçilmediğinde hata mesajı
                errorMessage = "Oda numarası seçilmelidir.";
            else if (cmbOdaTipi.SelectedItem == null)
                errorMessage = "Oda tipi seçilmelidir.";
            else if (cmbDurum.SelectedItem == null)
                errorMessage = "Oda durumu seçilmelidir.";
            else if (!decimal.TryParse(txtFiyat.Text, out _))
                errorMessage = "Geçerli bir fiyat girilmelidir.";

            return string.IsNullOrEmpty(errorMessage);
        }

        private void LoadRoomData()
        {
            try
            {
                // Veritabanından oda bilgilerini alıyoruz
                var odaListesi = _databaseHelper.GetOdaList();
                dataGridViewOdaListesi.DataSource = null;  // Önce veriyi sıfırla
                dataGridViewOdaListesi.DataSource = odaListesi;  // Yeniden yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda verilerini yüklerken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateRoomInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Geçersiz Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kullanıcıdan alınan oda bilgilerini veritabanına ekliyoruz
                string odaNo = cmbOdaNo.SelectedItem.ToString();  // Oda numarasını ComboBox'tan alıyoruz
                string odaTipi = cmbOdaTipi.SelectedItem.ToString();
                string durum = cmbDurum.SelectedItem.ToString();
                decimal fiyat = decimal.Parse(txtFiyat.Text);

                _databaseHelper.AddOda(odaNo, odaTipi, durum, fiyat);
                MessageBox.Show("Oda başarıyla eklendi.");
                LoadRoomData(); // Veritabanına ekledikten sonra oda listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            if (!ValidateRoomInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Geçersiz Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Seçilen oda bilgisini düzenle
                string odaNo = cmbOdaNo.SelectedItem.ToString();  // Oda numarasını ComboBox'tan alıyoruz
                string odaTipi = cmbOdaTipi.SelectedItem.ToString();
                string durum = cmbDurum.SelectedItem.ToString();
                decimal fiyat = decimal.Parse(txtFiyat.Text);

                _databaseHelper.UpdateOda(odaNo, odaTipi, durum, fiyat);
                MessageBox.Show("Oda başarıyla düzenlendi.");
                LoadRoomData(); // Veritabanına düzenledikten sonra oda listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda düzenlenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bu odayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                // Seçilen odayı sil
                string odaNo = cmbOdaNo.SelectedItem.ToString();  // Oda numarasını ComboBox'tan alıyoruz

                _databaseHelper.DeleteOda(odaNo);
                MessageBox.Show("Oda başarıyla silindi.");
                LoadRoomData(); // Veritabanına sildikten sonra oda listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda silinirken bir hata oluştu: " + ex.Message);
            }
        }
        private void dataGridViewOdaListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOdaListesi.Rows[e.RowIndex];
                cmbOdaNo.SelectedItem = row.Cells["odaNo"].Value.ToString();  // Oda numarasını ComboBox'a yükle
                cmbOdaTipi.SelectedItem = row.Cells["odaTipi"].Value.ToString();
                cmbDurum.SelectedItem = row.Cells["durum"].Value.ToString();
                txtFiyat.Text = row.Cells["fiyat"].Value.ToString();

                cmbOdaNo.Enabled = false; // Düzenleme sırasında oda numarası değiştirilemesin
            }
        }

        private void btnYeniOda_Click(object sender, EventArgs e)
        {
            cmbOdaNo.SelectedIndex = -1;
            cmbOdaTipi.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;
            txtFiyat.Clear();

            cmbOdaNo.Enabled = true; // Yeni oda ekleme modunda oda numarası aktif olsun
        }
    }
}