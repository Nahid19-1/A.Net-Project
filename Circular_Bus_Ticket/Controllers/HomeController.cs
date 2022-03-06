using Circular_Bus_Ticket.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Circular_Bus_Ticket.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = db.BusRoutes.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated) { return RedirectToAction("Index"); }
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = (from u in db.Users
                        where u.U_Password.Equals(user.U_Password) &&
                        u.U_UserName.Equals(user.U_UserName)
                        select u).FirstOrDefault(); ;
            if (data != null)
            {
               // tracing the cookie
                FormsAuthentication.SetAuthCookie(data.U_UserName, true);
                return RedirectToAction("Index");
            }

            TempData["msg"] = "Invalid Crdentials";
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // this will delete value from SetAuthCookie and logout user
            return RedirectToAction("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}