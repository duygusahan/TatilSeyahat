using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Siniflar;
namespace TatilSeyahat.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {  
            return View();
        }
        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult _PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult _PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult _PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult _PartialSlider()
        {
            var value = context.Blogs.OrderByDescending(x=>x.BlogId).Take(8).ToList();
            return PartialView(value);
        }

        public PartialViewResult _PartialDesciription()
        {
          
            return PartialView();
        }
        public PartialViewResult _PartialHotels()
        {
            var value = context.Blogs.OrderByDescending(m => m.BlogId).Take(2).ToList();
            return PartialView(value);
        }
        public PartialViewResult _PartialHotels2()
        {
            var value = context.Blogs.Where(m => m.BlogId == 1).ToList();
            return PartialView(value);
        }
        public PartialViewResult _PartialTop10()
        {
            var value = context.Blogs.Take(10).ToList();
            return PartialView(value);
        }
        public PartialViewResult _PartialBestPlace()
        {
            var value = context.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult _PartialBestPlaceRightSide()
        {
            var value = context.Blogs.OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return PartialView(value);
        }



    }
}