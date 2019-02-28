using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class UtilisateurDataLayer
    {
        public List<Utilisateur> getAll()
        {
            List<Utilisateur> list;
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                list = context.Utilisateur.ToList();
            }
            return list;
        }

        public void add(Utilisateur utilisateur)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Utilisateur.Add(utilisateur);
                context.SaveChanges();
            }
        }
        public void update(Utilisateur utilisateur)
        {
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                context.Utilisateur.Add(utilisateur);
                context.Entry(utilisateur).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Utilisateur getById(int id)
        {
            Utilisateur unUtilisateur = new Utilisateur();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                unUtilisateur = context.Utilisateur.Find(id);
            }
            return unUtilisateur;
        }
        public List<Utilisateur> getByCourseId(int id)
        {
            List<Utilisateur> listUtilisateur = new List<Utilisateur>();
            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                listUtilisateur = context.Utilisateur.Where(p=>p.Course.Any(c=>c.ID==id)).ToList();
            }
            return listUtilisateur;
        }

        public void Delete(int id)
        {
            Utilisateur utilisateur = new Utilisateur();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                utilisateur = context.Utilisateur.Find(id);
                context.Utilisateur.Remove(utilisateur);
                context.SaveChanges();
            }
        }
    }
}
