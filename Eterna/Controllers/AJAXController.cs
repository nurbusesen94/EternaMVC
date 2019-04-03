using Eterna.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class AJAXController : Controller
    {
        MyContext db = new MyContext();
        // GET: AJAX
        public ActionResult Index(string ad,string soyad,int yil)
        {
            string rtn = "Selam bebek: " + ad + soyad;
            if ((DateTime.Now.Year - yil) > 35) rtn += " yolun Yarısı";
            else rtn += " henüz gençsin bebek.";
            return Content(rtn);
        }

        public ActionResult Sehirler()
        {
            //string[] sehirler = { "İstanbul", "İzmir", "Ankara", "Kocaeli","Bursa" };         
            //return Json(sehirler,JsonRequestBehavior.AllowGet);

            return Json(db.Tag.Select(s=> new { s.ID,s.TagName}),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Ilceler(int plaka)
        {        
            return Json(db.Ilce.Where(w=>w.SehirPlaka==plaka), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Mahalle(int id)
        {
            return Json(db.Mahalle.Where(w => w.IlceID == id), JsonRequestBehavior.AllowGet);
        }
    }
}