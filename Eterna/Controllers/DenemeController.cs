using Eterna.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Controllers
{
    public class DenemeController : Controller
    {
        MyContext db = new MyContext();
        // GET: Deneme
        public ActionResult Index()
        {
            return View(db.Hizmetler.ToList());
        }
    }
}