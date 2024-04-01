using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TatilSeyahat.Models.Siniflar;

namespace TatilSeyahat.Controllers
{
    public class GirisYapController : Controller
    {
        Context context = new Context();
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = context.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler !=null) 
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kukkanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}