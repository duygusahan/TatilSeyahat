using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Siniflar;

namespace TatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();
            by.Deger4 = c.Yorums.OrderByDescending(x => x.YorumId).Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {

            by.Deger1 = c.Blogs.Where(m => m.BlogId == id).ToList();
            by.Deger2 = c.Yorums.Where(m => m.Blogid == id).ToList();
            // var blogbul = c.Blogs.Where(m => m.BlogId == id).ToList(); 
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        } 

        [HttpPost]
        public PartialViewResult YorumYap(Yorum a)
        {
            c.Yorums.Add(a);
            c.SaveChanges();

            return PartialView();
        }
        
    }
}