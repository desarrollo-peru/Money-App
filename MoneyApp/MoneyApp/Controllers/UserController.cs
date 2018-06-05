using MoneyApp.Helpers;
using MoneyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyApp.Controllers
{
    public class UserController : Controller
    {
        MoneyAppModel context = new MoneyAppModel();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                context.User.Add(user);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            SessionHelper.UserID = context.User.FirstOrDefault(x => x.username == user.username && x.password == user.password).Id;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}