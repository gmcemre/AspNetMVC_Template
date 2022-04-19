using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMVC_Template.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            NorthwindContext ctx = new NorthwindContext();

            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }
    }
}