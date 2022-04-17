using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Template.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        NorthwindEntities ctx = new NorthwindEntities();
        public ActionResult Index()
        {
            List<Urunler> urunler = ctx.Urunlers.ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            ViewBag.Kategoriler = ctx.Kategorilers.ToList();
            ViewBag.Tedarikciler = ctx.Tedarikcilers.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(Urunler urun)
        {
            ctx.Urunlers.Add(urun);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}