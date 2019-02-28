using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class SportController : Controller
    {
        private SportDataLayer _dataLayer = new SportDataLayer();
        // GET: Sport
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
        public ActionResult Create(Sport sport)
        {
            _dataLayer.add(sport);
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Sport unSport = _dataLayer.getById(id);
            return this.View();
        }
        [HttpPost]
        public ActionResult Edit(Sport sport)
        {
            _dataLayer.update(sport);
            return this.View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            _dataLayer.Delete(ID);
            return RedirectToAction("Index", "Sport");
        }
    }
}