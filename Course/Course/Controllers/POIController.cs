using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class POIController : Controller
    {
        private POIDataLayer _dataLayer = new POIDataLayer();
        private CourseDataLayer _dataLayerCourse = new CourseDataLayer();
        private PositionDataLayer _dataLayerPosition = new PositionDataLayer();
        // GET: POI
        public ActionResult Index()
        {
            return View(_dataLayer.getAll());
        }
        

        public ActionResult Create()
        {
            this.ViewBag.ListCourse = _dataLayerCourse.getAll();
            this.ViewBag.ListPosition = _dataLayerPosition.getAll();
            return this.View();
        }

        // POST : POI
        [HttpPost]
        public ActionResult Create(POI poi)
        {
            _dataLayer.add(poi);
            this.ViewBag.ListCourse = _dataLayerCourse.getAll();
            this.ViewBag.ListPosition = _dataLayerPosition.getAll();
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            POI unPOI = _dataLayer.getById(id);
            this.ViewBag.ListPosition = _dataLayerPosition.getAll();
            this.ViewBag.ListCourse = _dataLayerCourse.getAll();
            return this.View();
        }
        [HttpPost]
        public ActionResult Edit(POI poi)
        {
            _dataLayer.update(poi);
            this.ViewBag.ListPosition = _dataLayerPosition.getAll();
            this.ViewBag.ListCourse = _dataLayerCourse.getAll();
            return this.View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            _dataLayer.Delete(ID);
            return RedirectToAction("Index", "POI");
        }
    }
}