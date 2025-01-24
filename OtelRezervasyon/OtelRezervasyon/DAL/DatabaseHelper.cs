using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace OtelRezervasyon.DAL
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=172.21.54.253;Database=25_132330045;User=25_132330045;Password=!nif.ogr45YE;";

        // Veritabanı bağlantısını döndürme
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public int GetOdaIdByOdaNo(string odaNo)
        {
            int odaId = 0;

            string query = "SELECT oda_id FROM Odalar WHERE oda_no = @odaNo";

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@odaNo", odaNo);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        odaId = Convert.ToInt32(result);
                    }
                }
            }

            return odaId;
        }


        // Kullanıcı doğrulama fonksiyonu
        public string AuthenticateUser(string kullaniciAdi, string parola)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    // Kullanıcı adı ve parolayı doğrulamak için sorgu
                    string query = "SELECT pozisyon FROM personeller WHERE kullanici_adi = @kullaniciAdi AND parola = @parola";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@parola", parola);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();  // Kullanıcının pozisyonunu döndürüyoruz
                        }
                        else
                        {
                            return null;  // Kullanıcı adı veya parola hatalı
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);  // MessageBox hata düzeltildi
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş işlemi sırasında bir hata oluştu: " + ex.Message); // MessageBox hata düzeltildi
                return null;
            }
        }

        // Oda listesini alıyoruz
        public List<Oda> GetOdaList()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Odalar";  // Oda tablosu

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            List<Oda> odaListesi = new List<Oda>();
                            while (reader.Read())
                            {
                                Oda oda = new Oda
                                {
                                    OdaNo = reader["oda_no"].ToString(),
                                    OdaTipi = reader["oda_tipi"].ToString(),
                                    Durum = reader["durum"].ToString(),
                                    Fiyat = decimal.Parse(reader["fiyat"].ToString())
                                };
                                odaListesi.Add(oda);
                            }
                            return odaListesi;
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda verilerini yüklerken bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        // Oda ekleme
        public void AddOda(string odaNo, string odaTipi, string durum, decimal fiyat)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Odalar (oda_no, oda_tipi, durum, fiyat) VALUES (@odaNo, @odaTipi, @durum, @fiyat)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@odaNo", odaNo);
                        command.Parameters.AddWithValue("@odaTipi", odaTipi);
                        command.Parameters.AddWithValue("@durum", durum);
                        command.Parameters.AddWithValue("@fiyat", fiyat);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Oda eklenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Oda güncelleme
        public void UpdateOda(string odaNo, string odaTipi, string durum, decimal fiyat)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE Odalar SET oda_tipi = @odaTipi, durum = @durum, fiyat = @fiyat WHERE oda_no = @odaNo";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@odaNo", odaNo);
                        command.Parameters.AddWithValue("@odaTipi", odaTipi);
                        command.Parameters.AddWithValue("@durum", durum);
                        command.Parameters.AddWithValue("@fiyat", fiyat);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Oda güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Oda silme
        public void DeleteOda(string odaNo)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Odalar WHERE oda_no = @odaNo";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@odaNo", odaNo);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Oda silinirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda silinirken bir hata oluştu: " + ex.Message);
            }
        }

        // Rezervasyonları listeleme
        public List<Rezervasyon> GetReservationList(bool sadeceAktif = true)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar";
                    if (sadeceAktif)
                    {
                        query += " WHERE durum = 'Aktif'";
                    }

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            List<Rezervasyon> rezervasyonListesi = new List<Rezervasyon>();
                            while (reader.Read())
                            {
                                Rezervasyon rezervasyon = new Rezervasyon
                                {
                                    RezervasyonId = int.Parse(reader["rezervasyon_id"].ToString()),
                                    OdaId = int.Parse(reader["oda_id"].ToString()),
                                    PersonelId = int.Parse(reader["personel_id"].ToString()),
                                    AdSoyad = reader["ad_soyad"].ToString(),
                                    TcKimlikNo = reader["tc_kimlik_no"].ToString(),
                                    TelefonNo = reader["telefon_no"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Adres = reader["adres"].ToString(),
                                    GirisTarihi = DateTime.Parse(reader["giris_tarihi"].ToString()),
                                    CikisTarihi = DateTime.Parse(reader["cikis_tarihi"].ToString()),
                                    Durum = reader["durum"].ToString()
                                };
                                rezervasyonListesi.Add(rezervasyon);
                            }
                            return rezervasyonListesi;
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon verilerini yüklerken bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        // Rezervasyon ekleme
        public void AddReservation(int odaId, string odaNo, string adSoyad, string tcKimlikNo, string telefonNo, string email, string adres, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO Rezervasyonlar (oda_id, oda_no, ad_soyad, tc_kimlik_no, telefon_no, email, adres, giris_tarihi, cikis_tarihi, durum) 
                            VALUES (@odaId, @odaNo, @adSoyad, @tcKimlikNo, @telefonNo, @email, @adres, @girisTarihi, @cikisTarihi, 'Aktif')";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@odaId", MySqlDbType.Int32).Value = odaId;
                        command.Parameters.Add("@odaNo", MySqlDbType.VarChar).Value = odaNo;
                        command.Parameters.Add("@adSoyad", MySqlDbType.VarChar).Value = adSoyad;
                        command.Parameters.Add("@tcKimlikNo", MySqlDbType.VarChar).Value = tcKimlikNo;
                        command.Parameters.Add("@telefonNo", MySqlDbType.VarChar).Value = telefonNo;
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        command.Parameters.Add("@adres", MySqlDbType.VarChar).Value = adres;
                        command.Parameters.Add("@girisTarihi", MySqlDbType.DateTime).Value = girisTarihi;
                        command.Parameters.Add("@cikisTarihi", MySqlDbType.DateTime).Value = cikisTarihi;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Rezervasyon eklenirken bir hata oluştu.");
                        }

                        // Odanın durumunu 'Dolu' olarak güncelle
                        UpdateOdaDurum(odaId, "Dolu");
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                // Veritabanı hatalarını logla veya mesaj göster
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Diğer hataları logla veya mesaj göster
                MessageBox.Show("Rezervasyon eklenirken bir hata oluştu: " + ex.Message);
            }
        }


        // Rezervasyon iptal etme
        public void CancelReservation(int rezervasyonId)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE Rezervasyonlar SET durum = 'İptal Edildi' WHERE rezervasyon_id = @rezervasyonId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Rezervasyon iptal edilirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon iptal edilirken bir hata oluştu: " + ex.Message);
            }
        }

        // Oda durumunu güncelleme
        public void UpdateOdaDurum(int odaId, string durum)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE Odalar SET durum = @durum WHERE oda_id = @odaId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@odaId", odaId);
                        command.Parameters.AddWithValue("@durum", durum);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Oda durumu güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<string> LoadOdaNumbers()
        {
            List<string> odaNumaralari = new List<string>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT oda_no FROM Odalar WHERE durum = 'Müsait'"; // Müsait odalar
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                odaNumaralari.Add(reader["oda_no"].ToString()); // Oda numarasını ekle
                            }
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda numaraları yüklenirken bir hata oluştu: " + ex.Message);
            }
            return odaNumaralari;
        }


        public class Oda
        {
            public string OdaNo { get; set; }
            public string OdaTipi { get; set; }
            public string Durum { get; set; }
            public decimal Fiyat { get; set; }
        }
        public class Rezervasyon
        {
            public int RezervasyonId { get; set; }
            public int OdaId { get; set; }
            public int PersonelId { get; set; }
            public string AdSoyad { get; set; }
            public string TcKimlikNo { get; set; }
            public string TelefonNo { get; set; }
            public string Email { get; set; }
            public string Adres { get; set; }
            public DateTime GirisTarihi { get; set; }
            public DateTime CikisTarihi { get; set; }
            public string Durum { get; set; }
        }
        public class Fatura
        {
            public int FaturaId { get; set; }
            public int RezervasyonId { get; set; }
            public DateTime FaturaTarihi { get; set; }
            public decimal ToplamTutar { get; set; }
            public string OdemeDurumu { get; set; }
        }
    }
}