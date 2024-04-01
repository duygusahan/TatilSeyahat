using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Siniflar
{
    public class Iletisim
    {
        public int IletisimId { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}