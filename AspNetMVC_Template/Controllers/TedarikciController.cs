using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Template.Controllers
{
    public class TedarikciController : Controller
    {
        // GET: Tedarikci
        NorthwindEntities ctx = new NorthwindEntities();
        public ActionResult Index()
        {
            List<Tedarikciler> ted = ctx.Tedarikcilers.ToList();
            return View(ted);
        }

        [HttpPost]
        public string Sil(int id)
        {
            Tedarikciler t = ctx.Tedarikcilers.FirstOrDefault(x => x.TedarikciID == id);
            ctx.Tedarikcilers.Remove(t);
            try
            {
                ctx.SaveChanges();
                return "Başarılı";
            }
            catch (Exception)
            {
                return "Hata";
            }
        }
    }
}