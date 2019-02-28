using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class VilleDataLayer
    {
        public List<Ville> getAll()
        {
            List<Ville> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.Ville.ToList();
            }
            return list;
        }

        public void add(Ville ville)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Ville.Add(ville);
                context.SaveChanges();
            }
        }
        public void update(Ville ville)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Ville.Add(ville);
                context.Entry(ville).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Ville getById(int id)
        {
            Ville uneVille = new Ville();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                uneVille = context.Ville.Find(id);
            }
            return uneVille;
        }

        public void Delete(int id)
        {
            Ville ville = new Ville();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                ville = context.Ville.Find(id);
                context.Ville.Remove(ville);
                context.SaveChanges();
            }
        }
    }
}
