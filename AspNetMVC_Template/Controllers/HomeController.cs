using AspNetMVC_Template.App_Classes;
using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Template.Controllers
{
    [Authorize]  //Bu controller içerisindeki Action'lar açılması için sisteme giriş yapması lazım.
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.AktifKullanici = HttpContext.Application["AktifKullanici"];
            ViewBag.ToplamZiyaretci = HttpContext.Application["ToplamZiyaretci"];
            return View();
        }

        public ActionResult CookieAta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CookieAta(string CookieAdi, string CookieDegeri)
        {
            HttpCookie ck = new HttpCookie(CookieAdi);
            ck.Value = CookieDegeri;
            ck.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(ck);
            return View();
        }

        public ActionResult CookieOku()
        {
            string deger = Request.Cookies["Grup Kodu"].Value;
            ViewBag.Cerez = deger;
            return View();
        }

        public ActionResult Sepetim()
        {
            List<Urunler> urunler = new List<Urunler>();
            if (Session["AktifSepet"] != null)
            {
                Sepet s = (Sepet)Session["AktifSepet"];
                urunler = s.Urunler;
            }
            return View(urunler);
        }
    }
}