using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Call_Logger.Models;

namespace Call_Logger.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (CallDBContext db = new CallDBContext())
            {
                return View(db.userAccount.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {

            if (ModelState.IsValid)
            {
                using (CallDBContext db = new CallDBContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered.";
            }
            return View();
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (CallDBContext db = new CallDBContext())
            {
                var usr = db.userAccount.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    return Redirect("http://localhost:52319/CallLog/Index");
                   // return @Url.Action("/CallLog/Index").ToString();            
                }
                else
                {
                    ModelState.AddModelError("", "Username//Password combination is incorrect.");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
                {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}