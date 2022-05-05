using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Template.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        // GET: Kategori
        NorthwindContext ctx = new NorthwindContext();
        public ActionResult Index()
        {
            List<Kategoriler> ktg = ctx.Kategorilers.ToList();
            return View(ktg);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategoriler ktg)
        {
            ctx.Kategorilers.Add(ktg);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Sil(int id)
        {
            Kategoriler k = ctx.Kategorilers.FirstOrDefault(x => x.KategoriID == id);
            ctx.Kategorilers.Remove(k);
            ctx.SaveChanges();
        }
    }
}