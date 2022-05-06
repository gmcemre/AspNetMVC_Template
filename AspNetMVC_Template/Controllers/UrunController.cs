using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Template.Controllers
{
    using App_Classes;
    [Authorize]
    public class UrunController : Controller
    {
        // GET: Urun
        NorthwindContext ctx = new NorthwindContext();
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

        [HttpGet]
        public ActionResult Sil(int id)
        {
            Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            return View(u);
        }

        [HttpPost]
        public ActionResult Sil(Urunler u)
        {
            Urunler urn = ctx.Urunlers.FirstOrDefault(x => x.UrunID == u.UrunID);
            ctx.Urunlers.Remove(urn);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunDetay()
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            string adi = Request.QueryString["adi"].ToString();
            Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            return View(u);
        }

        [HttpPost]
        public void SepeteAt(int id)
        {
            Sepet s;
            if (Session["AktifSepet"] == null)
                s = new Sepet();
            else
                s = (Sepet)Session["AktifSepet"];
            Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            s.Urunler.Add(u);
            Session["AktifSepet"] = s;
        }
    }
}