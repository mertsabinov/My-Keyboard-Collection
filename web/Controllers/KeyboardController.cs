using System;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class KeyboardController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Save(Keyboard keyboard)
        {
            keyboard.Id = Guid.NewGuid().ToString();
            DbManager.Data.Add(keyboard);
            ViewBag.Keyboard = keyboard;
            return View();
        }
    }
}