using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Siniflar
{
    public class AdresBlog
    {
        public int AdresBlogId { get; set; }

        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AdresAcik { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}