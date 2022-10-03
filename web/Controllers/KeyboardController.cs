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
            string userId;
            string userName = "";
            try
            {
                userId = HttpContext.Session["userId"].ToString();
            }
            catch (Exception e)
            {
                userId = "";
            }
            userName = DbManager.UserGetUserName(userId);
            if (userName != "")
            {
                ViewBag.UserName = userName;
                return View();
            }
            return new RedirectResult("/Login");
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