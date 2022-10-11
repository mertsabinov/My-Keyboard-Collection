using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class RegisterController : Controller
    {
        // GET
        public ActionResult Index()
        {
            if (HttpContext.Session["userID"] is null )
            {
                return View();
            }
            return Redirect("/");
        }
         [HttpPost]
        public ActionResult Register(User user)
        {
            string error = UserDbManager.UserRegister(user.UserName, user.Password);
            if (error != "")
            {
                ViewBag.error = error;
                return View();
            }
            User u = UserDbManager.UserLogin(user.UserName,user.Password);
            if (u != null)
            {
                HttpContext.Session["userID"] = u.Id;
                return new RedirectResult("/keyboard");
            }
            return View();
        }
    }
}