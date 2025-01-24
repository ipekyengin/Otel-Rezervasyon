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
using OtelRezervasyon.DAL;

namespace OtelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtParola.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;

            DatabaseHelper dbHelper = new DatabaseHelper();
            string pozisyon = dbHelper.AuthenticateUser(kullaniciAdi, parola);

            if (pozisyon != null)
            {
                MessageBox.Show("Giriş başarılı! Hoş geldiniz: " + pozisyon);

                if (pozisyon == "Yönetici")
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else if (pozisyon == "Personel")
                {
                    PersonelForm personelForm = new PersonelForm();
                    this.Hide();
                    personelForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı!");
            }
        }
    }
}