using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class LoginController : Controller
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
        public ActionResult Login(User user)
        {
            User u = UserDbManager.UserLogin(user.UserName,user.Password);
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
            return Redirect("/");
        }
    }
}