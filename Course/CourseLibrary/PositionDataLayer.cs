using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class PositionDataLayer
    {
        public List<Position> getAll()
        {
            List<Position> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.Position.ToList();
            }
            return list;
        }

        public void add(Position position)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Position.Add(position);
                context.SaveChanges();
            }
        }
        public void update(Position position)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Position.Add(position);
                context.Entry(position).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Position getById(int id)
        {
            Position unePosition = new Position();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                unePosition = context.Position.Find(id);
            }
            return unePosition;
        }

        public void Delete(int id)
        {
            Position position = new Position();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                position = context.Position.Find(id);
                context.Position.Remove(position);
                context.SaveChanges();
            }
        }
    }
}
