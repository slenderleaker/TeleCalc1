using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Index(string opName, double? x, double? y)
        {
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.opName = opName;
            return View();
        }
    }
}