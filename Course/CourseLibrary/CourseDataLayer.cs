using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class CourseDataLayer
    {
        public List<Course> getAll()
        {
            List<Course> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.Course.Include("Sport").Include("Utilisateur").Include("Ville").ToList();
            }
            return list;
        }

        public void add(Course course)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Course.Add(course);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Course course = new Course();
            
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                course = context.Course.Find(id);
                context.Course.Remove(course);
                context.SaveChanges();
            }
        }

        public void update(Course course)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Course.Add(course);
                context.Entry(course).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Course getById(int id)
        {
            Course uneCourse = new Course();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                uneCourse = context.Course.Find(id);
                uneCourse.Ville = context.Course.Find(id).Ville;
                uneCourse.Utilisateur = context.Course.Find(id).Utilisateur;
                uneCourse.Sport = context.Course.Find(id).Sport;
                uneCourse.POI = context.Course.Find(id).POI.Where(p=>p.CourseID== id).ToList() ;
            }
            return uneCourse;
        }
    }
}
