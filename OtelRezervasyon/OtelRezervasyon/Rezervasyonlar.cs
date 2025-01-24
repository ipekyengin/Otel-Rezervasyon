using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Rezervasyonlar
    {
        public int rezervasyon_id { get; set; }
        public int oda_id { get; set; }
        public int personel_id { get; set; }
        public string giris_tarihi { get; set; }
        public string cikis_tarihi { get; set; }
        public string durum { get; set; }
    }
}
