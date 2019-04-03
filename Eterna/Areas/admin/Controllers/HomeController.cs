using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eterna.Areas.admin.Controllers
{
    //kimlik denetimi var tüm classtaki actionlarda
    [Authorize]
    public class HomeController : Controller
    {
        // GET: admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}