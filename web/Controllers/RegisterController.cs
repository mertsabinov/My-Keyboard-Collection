using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class RegisterController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Register(User user)
        {
            string error = DbManager.UserRegister(user.UserName, user.Password);
            if (error != "")
            {
                ViewBag.error = error;
                return View();
            }
            User u = DbManager.UserLogin(user.UserName,user.Password);
            if (u != null)
            {
                HttpContext.Session["userID"] = u.Id;
                return new RedirectResult("/keyboard");
            }
            return View();
        }
    }
}