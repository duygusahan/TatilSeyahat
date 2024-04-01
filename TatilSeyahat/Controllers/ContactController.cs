using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Siniflar;

namespace TatilSeyahat.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMessage(Iletisim p)
        {
            context.Iletisims.Add(p);
            context.SaveChanges();
            return View();
        }
    }
}