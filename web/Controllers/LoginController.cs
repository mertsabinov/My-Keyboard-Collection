using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.UserName == "admin" && user.Password == "admin123")
            {
                HttpContext.Session["UserName"] = user.UserName; 
                return new RedirectResult("/keyboard");
            } 
            return View("Index");
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return new RedirectResult("/");
        }
    }
}