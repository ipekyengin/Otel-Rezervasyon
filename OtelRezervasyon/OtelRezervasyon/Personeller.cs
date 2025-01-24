using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Personeller
    {
        public int personel_id { get; set; }
        public string ad_soyad { get; set; }
        public string pozisyon { get; set; }
        public string kullanici_adi { get; set; }
        public string parola { get; set; }

        public bool personalEntryControl(string password, int UserId)
        {
            bool result = false;

            try
            {
                SqlConnection conn = new SqlConnection();
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
    }
}
