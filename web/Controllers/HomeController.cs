using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var keyboards = DbManager.Data;
            if (keyboards == null)
            {
                keyboards = new List<Keyboard>();
            }
            ViewBag.Keyboards = keyboards;
            return View();
        }
    }
}