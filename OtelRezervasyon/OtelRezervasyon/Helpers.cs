using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Helpers
{
    public static class CurrentSession
    {
        public static int PersonelId { get; set; } // Giriş yapan personelin ID'si
        public static string KullaniciAdi { get; set; } // Giriş yapan kullanıcının adı
    }
}