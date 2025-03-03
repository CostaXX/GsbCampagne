using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class SalarieDAO
    {
        #region Singleton
        private static SalarieDAO instance;
        public static SalarieDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new SalarieDAO();
            }
            return instance;
        }
        #endregion

        public Salarie GetInfosSalarie(string login) 
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                return ctx.Salaries
                .Include("Role")
                .Where(u => u.Login == login)
                .SingleOrDefault();
            }
        }

        public List<Salarie> GetLesSalaries()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Salaries
                .Include("Role")
                .ToList();
                return liste;
            }
        }
    }
}
