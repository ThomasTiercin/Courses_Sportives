using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary
{
    public class LoginDataLayer
    {
        public Boolean AllowUser(string mail, string mdp)
        {

            Boolean isValid = false;

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                var query = from item in context.Utilisateur
                            where item.Login == mail && item.Password == mdp
                            select item;

                isValid = query.Any();

            }

            return isValid;
        }

        public Utilisateur GetUser(string mail)
        {

            Utilisateur utilisateur = new Utilisateur();

            using (Tp_CoursesEntities1 context = new Tp_CoursesEntities1())
            {
                var query = from item in context.Utilisateur
                            where item.Login == mail
                            select item;

                utilisateur = query.First();
            }

            return utilisateur;
        }

    }
}
