using CourseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private CourseDataLayer _dataLayer = new CourseDataLayer();
        private VilleDataLayer _dataLayerVille = new VilleDataLayer();
        private UtilisateurDataLayer _dataLayerOrganisateur = new UtilisateurDataLayer();
        private SportDataLayer _dataLayerSport = new SportDataLayer();
        public ActionResult Index()
        {
            return View(_dataLayer.getAll());
        }

        public ActionResult Create()
        {
            this.ViewBag.ListVille = _dataLayerVille.getAll();
            this.ViewBag.ListOrganisateur = _dataLayerOrganisateur.getAll();
            this.ViewBag.ListSport = _dataLayerSport.getAll();
            return this.View();
        }

        // POST : course
        [HttpPost]
        public ActionResult Create(CourseLibrary.Course course)
        {
            _dataLayer.add(course);
            this.ViewBag.ListVille = _dataLayerVille.getAll();
            this.ViewBag.ListOrganisateur = _dataLayerOrganisateur.getAll();
            this.ViewBag.ListSport = _dataLayerSport.getAll();
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            CourseLibrary.Course uneCourse = _dataLayer.getById(id);
            this.ViewBag.ListVille = _dataLayerVille.getAll();
            this.ViewBag.ListOrganisateur = _dataLayerOrganisateur.getAll();
            this.ViewBag.ListSport = _dataLayerSport.getAll();
            return this.View(uneCourse);
        }
        [HttpPost]
        public ActionResult Edit(CourseLibrary.Course course)
        {
            _dataLayer.update(course);
            this.ViewBag.ListVille = _dataLayerVille.getAll();
            this.ViewBag.ListOrganisateur = _dataLayerOrganisateur.getAll();
            this.ViewBag.ListSport = _dataLayerSport.getAll();
            return this.View();
        }

        [HttpGet]
        public ActionResult Details(int ID)
        {
            this.ViewBag.ListParticipant = _dataLayerOrganisateur.getByCourseId(ID);
            this.ViewBag.Course = _dataLayer.getById(ID); 

            return View();
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            _dataLayer.Delete(ID);
            return RedirectToAction("Index", "Course");
        }
    }
}