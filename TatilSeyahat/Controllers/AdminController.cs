using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Siniflar;


namespace TatilSeyahat.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var value = context.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog p)
        {
            context.Blogs.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var value = context.Blogs.Find(id);
            context.Blogs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var value = context.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult BlogGuncelle(Blog b)
        {
            var value = context.Blogs.Find(b.BlogId);
            value.Aciklama = b.Aciklama;
            value.Baslik = b.Baslik;
            value.ImgUrl = b.ImgUrl;
            value.Tarih = b.Tarih;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumList()
        {
            var value = context.Yorums.ToList();
            return View(value);
        }
        public ActionResult YorumSil(int id)
        {
            var value = context.Yorums.Find(id);
            context.Yorums.Remove(value);
            context.SaveChanges();
            return RedirectToAction("YorumList");
        }
        [HttpGet]
        public ActionResult YorumGuncelle(int id)
        {
            var value = context.Yorums.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult YorumGuncelle(Yorum y)
        {
            var value = context.Yorums.Find(y.YorumId);
            value.KullaniciAdi = y.KullaniciAdi;
            value.Mail = y.Mail;
            value.Yorumlar = y.Yorumlar;
            
            context.SaveChanges();

            return RedirectToAction("YorumList");
        }
    }
}