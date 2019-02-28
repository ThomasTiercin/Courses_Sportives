using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class POIDataLayer
    {
        public List<POI> getAll()
        {
            List<POI> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.POI.Include("Position").Include("Course").ToList();
            }
            return list;
        }

        public void add(POI poi)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.POI.Add(poi);
                context.SaveChanges();
            }
        }
        public void update(POI poi)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.POI.Add(poi);
                context.Entry(poi).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public POI getById(int id)
        {
            POI unPOI = new POI();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                unPOI = context.POI.Find(id);
            }
            return unPOI;
        }

        public void Delete(int id)
        {
            POI poi = new POI();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                poi = context.POI.Find(id);
                context.POI.Remove(poi);
                context.SaveChanges();
            }
        }
    }
}
