using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class VilleController : Controller
    {
        private VilleDataLayer _dataLayer = new VilleDataLayer();
        // GET: Ville
        public ActionResult Index()
        {
            return View(_dataLayer.getAll());
        }

        public ActionResult Create()
        {
            return this.View();
        }

        // POST : Ville
        [HttpPost]
        public ActionResult Create(Ville ville)
        {
            _dataLayer.add(ville);
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Ville uneVille = _dataLayer.getById(id);
            return this.View(uneVille);
        }
        [HttpPost]
        public ActionResult Edit(Ville ville)
        {
            _dataLayer.update(ville);
            return this.View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            _dataLayer.Delete(ID);
            return RedirectToAction("Index", "Ville");
        }
    }
}