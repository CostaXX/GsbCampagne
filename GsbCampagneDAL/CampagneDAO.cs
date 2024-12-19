using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CampagneDAO
    {
        #region Instance
        private static CampagneDAO instance;
        public static CampagneDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneDAO();
            }
            return instance;
        }
        #endregion

        #region Liste des Campagnes
        public List<Campagne> GetLesCampagnes()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Campagnes
                    .ToList();
                return liste;
            }
        }
        #endregion
    }
}
