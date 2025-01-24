using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyon.DAL;
using static OtelRezervasyon.DAL.DatabaseHelper;  // DAL kullanımı

namespace OtelRezervasyon
{
    public partial class OdaAramaForm : Form
    {
        public OdaAramaForm()
        {
            InitializeComponent();
        }

        private void OdaAramaForm_Load(object sender, EventArgs e)
        {
            // Oda bilgilerini veritabanından çekip DataGridView'e yükleme
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            try
            {
                // DatabaseHelper sınıfından bir nesne oluşturuyoruz
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Oda verilerini DAL sınıfı üzerinden alıyoruz
                List<Oda> odaListesi = dbHelper.GetOdaList();

                // Alınan oda verilerini DataTable'a dönüştür
                DataTable odaDataTable = ConvertListToDataTable(odaListesi);

                // Alınan oda bilgilerini DataGridView'e yüklüyoruz
                dataGridViewOdaListesi.DataSource = odaDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda verilerini yüklerken bir hata oluştu: " + ex.Message);
            }
        }

        // List<Oda> nesnesini DataTable'a dönüştüren metod
        private DataTable ConvertListToDataTable(List<Oda> odaListesi)
        {
            DataTable table = new DataTable();

            // DataTable'a sütun ekleme
            table.Columns.Add("Oda No");
            table.Columns.Add("Oda Tipi");
            table.Columns.Add("Durum");
            table.Columns.Add("Fiyat");

            // List<Oda>'daki verileri DataTable'a ekleme
            foreach (Oda oda in odaListesi)
            {
                DataRow row = table.NewRow();
                row["Oda No"] = oda.OdaNo;
                row["Oda Tipi"] = oda.OdaTipi;
                row["Durum"] = oda.Durum;
                row["Fiyat"] = oda.Fiyat;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}