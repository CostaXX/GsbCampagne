using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GsbCampagneDAL
{
    public class VilleDAO
    {
        #region Singleton
        private static VilleDAO instance;
        public static VilleDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new VilleDAO();
            }
            return instance;
        }
        #endregion

        #region Listes des villes
        public List<Ville> GetLesVilles()

        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Villes
                    .ToList();
                return liste;
            }
        }
        #endregion




    }
}
