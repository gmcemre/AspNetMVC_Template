using AspNetMVC_Template.App_Classes;
using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMVC_Template.Controllers
{
    [Authorize]
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public ActionResult KullaniciEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KullaniciEkle(Kullanici k)
        {
            MembershipCreateStatus durum;
            Membership.CreateUser(k.KullaniciAdi, k.Parola, k.Email, k.GizliSoru, k.GizliCevap, true, out durum);
            string message = "";
            switch (durum)
            {
                case MembershipCreateStatus.Success:

                    break;
                case MembershipCreateStatus.InvalidUserName:
                    message += " Geçersiz Kullanıcı Adı ";
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    message += " Geçersiz Parola ";
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    message += " Geçersiz Gizli Soru ";
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    message += " Geçersiz Gizli Cevap ";
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    message += " Geçersiz Mail Adresi ";
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    message += " Kullanılmış kullanıcı adı. ";
                    break;
                case MembershipCreateStatus.DuplicateEmail:
                    message += " Kullanılmış mail adresi girildi. ";
                    break;
                case MembershipCreateStatus.UserRejected:
                    message += " Kullanıcı Engel Hatası ";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    message += " Geçersiz Kullanıcı Key Hatası ";
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    message += " Kullanılmış kullanıcı key hatası. ";
                    break;
                case MembershipCreateStatus.ProviderError:
                    message += " Üye Yönetimi Sağlayıcısı Hatası ";
                    break;
                default:
                    break;
            }

            ViewBag.Message = message;

            if (durum == MembershipCreateStatus.Success)
                return RedirectToAction("Index");
            else
                return View();
        }

        public ActionResult RolAta()
        {
            ViewBag.Roller = Roles.GetAllRoles().ToList();
            ViewBag.Kullanicilar = Membership.GetAllUsers();
            return View();
        }

        [HttpPost]
        public ActionResult RolAta(string KullaniciAdi, string RolAdi)
        {
            Roles.AddUserToRole(KullaniciAdi, RolAdi);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string UyeRolleri(string kullaniciAdi)
        {
            List<string> roller = Roles.GetRolesForUser(kullaniciAdi).ToList();
            string rol = "";
            foreach (string r in roller)
            {
                rol += r + "-";
            }
            rol = rol.Remove(rol.Length - 1, 1);
            return rol;
        }
    }
}