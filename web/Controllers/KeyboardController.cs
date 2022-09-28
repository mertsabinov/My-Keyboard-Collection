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
            ViewBag.Name = keyboard.Name;
            return View();
        }
    }
}