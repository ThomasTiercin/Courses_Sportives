using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class UtilisateurController : Controller
    {
        private UtilisateurDataLayer _dataLayer = new UtilisateurDataLayer();
        // GET: Utilisateur
        public ActionResult Index()
        {
            return View(_dataLayer.getAll());
        }

        public ActionResult Create()
        {
            return this.View();
        }

        // POST : Utilisateur
        [HttpPost]
        public ActionResult Create(Utilisateur utilisateur)
        {
            _dataLayer.add(utilisateur);
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Utilisateur unUtilisateur = _dataLayer.getById(id);
            return this.View();
        }
        [HttpPost]
        public ActionResult Edit(Utilisateur utilisateur)
        {
            _dataLayer.update(utilisateur);
            return this.View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            _dataLayer.Delete(ID);
            return RedirectToAction("Index", "Utilisateur");
        }
    }
}