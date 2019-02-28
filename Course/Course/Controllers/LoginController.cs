using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class LoginController : Controller
    {
        private LoginDataLayer _layer = new LoginDataLayer();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            if (_layer.AllowUser(login, password))
            {

                Utilisateur utilisateur = _layer.GetUser(login);

                this.Session["USER_LOGIN"] = login;
                this.Session["USER_ID"] = utilisateur.ID;

                return RedirectToAction("Index", "Course");
            }

            return this.View();
        }

        [HttpGet]
        public ActionResult Deco()
        {
            this.Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}