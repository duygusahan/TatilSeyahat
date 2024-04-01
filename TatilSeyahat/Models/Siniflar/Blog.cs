using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Siniflar
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
    }
}