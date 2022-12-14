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
            var keyboards = DbManager.GetAllData();
            if (keyboards == null)
            {
                keyboards = new List<Keyboard>();
            }
            return View(keyboards);
        }
    }
}