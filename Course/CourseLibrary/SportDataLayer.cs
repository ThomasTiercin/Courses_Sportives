using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class SportDataLayer
    {
        public List<Sport> getAll()
        {
            List<Sport> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.Sport.ToList();
            }
            return list;
        }

        public void add(Sport sport)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Sport.Add(sport);
                context.SaveChanges();
            }
        }
        public void update(Sport sport)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Sport.Add(sport);
                context.Entry(sport).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Sport getById(int id)
        {
            Sport unSport = new Sport();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                unSport = context.Sport.Find(id);
            }
            return unSport;
        }

        public void Delete(int id)
        {
            Sport sport = new Sport();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                sport = context.Sport.Find(id);
                context.Sport.Remove(sport);
                context.SaveChanges();
            }
        }
    }
}
