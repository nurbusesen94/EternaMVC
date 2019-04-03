using Eterna.Contexts;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Eterna.ViewModels;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Sitemize Hoşgeldiniz";
            ViewBag.ActiveH = "active";
            ViewBag.Sehirler = db.Sehir.ToList();

            return View(db.Yorum.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Title = "Hakkımızda";
            ViewBag.ActiveA = "active";

            return View(db.Personel.ToList());
        }
        public ActionResult Paq()
        {
            ViewBag.Title = "Sorular";
            ViewBag.ActiveS = "active";

            return View(db.Kategori.Include("Sorular").ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "İletişim";
            ViewBag.ActiveC = "active";

            return View();
        }
        public ActionResult BlogFull()
        {
            ViewBag.Title = "Bloglar";
            ViewBag.ActiveBF = "active";

            return View(db.Blog.Include("BlogTag").Include("BlogTag.Tag").ToList());
        }
        public ActionResult Ara(string ara)
        {           
            return View("BlogFull", db.Blog.Where(w => w.Title.Contains(ara) || w.Write.Contains(ara) || w.BlogTag.Any(a => a.Tag.TagName.Contains(ara))).Include("BlogTag").Include("BlogTag.Tag").ToList()); 
        }

        public ActionResult Portfolio3()
        {
            ViewBag.Title = "Referanslar";
            ViewBag.ActiveP = "active";
            return View();
        }
        public ActionResult Hizmet()
        {
            ViewBag.ActiveHizmet = "active";
            return PartialView(db.Hizmetler.ToList());
        }

        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.rtn =ReturnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(string kullaniciAdi, string pass,string rURL)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(pass))
            {
                Admin admin = db.Admin.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == pass);
                if (admin!=null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciAdi, true);
                    Session["AdSoyad"] = admin.AdSoyad;
                    if (!string.IsNullOrEmpty(rURL)) return Redirect(rURL);
                    return Redirect("/admin");
                }
                else ViewBag.Hata = "Kullanıcı Adı veya Şifre Hatalı!";
            }
            else ViewBag.Hata = "Kullanıcı Adı ve Şifre Gerekli!";
            return View();
        }
        
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }



    }

}