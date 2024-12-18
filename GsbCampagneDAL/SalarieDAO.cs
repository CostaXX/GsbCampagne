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
        #endregion Singleton

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
