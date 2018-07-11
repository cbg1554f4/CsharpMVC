using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_201807.Controllers
{
    public class RoutersController : Controller
    {
        // GET: Routers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2(String ids )
        {
            return Content("AAASDD" + ids);
        }

        public ActionResult Index3(String ids ,String Pages )
        {
            return Content( "AAASDD_" + ids + "  KKK_" + Pages);
        }
    }
}