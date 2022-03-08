using Circular_Bus_App.Models.Database;
using Circular_Bus_App.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Circular_Bus_App.Controllers
{
    public class UserController : Controller

    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginUser()
        {
            //if (User.Identity.IsAuthenticated) { return RedirectToAction("Index"); }
            return View();
        }
        [HttpPost]
        public ActionResult LoginUser(User user)
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = (from u in db.Users
                        where u.U_Password.Equals(user.U_Password) &&
                        u.U_UserName.Equals(user.U_UserName)
                        select u).FirstOrDefault(); ;
            if (data != null)
            {               
                FormsAuthentication.SetAuthCookie(data.U_UserName, true);
                Session["role"] = data.U_Role;
                Session["userid"] = data.U_Id;
                Session["username"] = data.U_UserName;

                return RedirectToAction("Index", "Home");
            }

            TempData["msg"] = "Invalid Username or Password";
            return RedirectToAction("LoginUser");
        }

        public ActionResult LogoutUser()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginUser");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User u)
        {
            
            if(ModelState.IsValid)
            {
                CircularBusEntities db = new CircularBusEntities();
                db.Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("LoginUser");
            }
            return View(u);

        }

        //[UserAccess]
        [HttpGet]
        public ActionResult BusDetails()
        {
            CircularBusEntities db = new CircularBusEntities();
            return View(db.BusInfoes.ToList());

        }

        [HttpGet]
        [Authorize]
        public ActionResult Profile(User user)
        {
            string loggedUserName = Session["username"].ToString();
            string id = Session["userid"].ToString(); 
            int loggedUserId = Int32.Parse(id);
            CircularBusEntities db = new CircularBusEntities();
            
;            var data = (from e in db.Users
                        where e.U_Id.Equals(loggedUserId) &&
                        e.U_UserName.Equals(loggedUserName)
                        select e).ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = (from u in db.Users
                        where u.U_Id == id
                        select u).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(User new_User)
        {
            if (ModelState.IsValid)
            {
                CircularBusEntities db = new CircularBusEntities();
                var data = (from u in db.Users
                            where u.U_Id == new_User.U_Id
                            select u).FirstOrDefault();
                db.Entry(data).CurrentValues.SetValues(new_User);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            return View();
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = (from u in db.Users
                         where u.U_Id == id
                         select u).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(User delete)
        {
            CircularBusEntities db = new CircularBusEntities();
            var data = (from u in db.Users
                        where u.U_Id == delete.U_Id
                        select u).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(delete);
            db.Users.Remove(data);
            db.SaveChanges();
            return RedirectToAction("LoginUser");

        }

    }
}