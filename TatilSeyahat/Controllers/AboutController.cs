using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Siniflar; 


namespace TatilSeyahat.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        
        public ActionResult Index()
        {
            var value = c.Hakkimizdas.ToList();
            return View(value);
        }
    }
}