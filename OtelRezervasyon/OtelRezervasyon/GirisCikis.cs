using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class GirisCikis
    {
        public int islem_id { get; set; }
        public int rezervasyon_id { get; set; }
        public int oda_id { get; set; }
        public int personel_id { get; set; }
        public string islem_tarihi { get; set; }
        public string islem_tipi { get; set; }
    }
}
