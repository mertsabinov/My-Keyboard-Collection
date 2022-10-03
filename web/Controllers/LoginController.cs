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
            User u = DbManager.UserLogin(user.UserName,user.Password);
            if (u != null)
            {
                HttpContext.Session["userID"] = u.Id;
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