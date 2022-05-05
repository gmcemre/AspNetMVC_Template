using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMVC_Template.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            List<string> roller = Roles.GetAllRoles().ToList();
            return View(roller);
        }

        [HttpGet]
        public ActionResult RolEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RolEkle(string RolAdi)
        {
            Roles.CreateRole(RolAdi);
            return RedirectToAction("Index");
        }
    }
}