using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneBLL
{
    public class CampagneManager
    {
        #region Singleton
        private static CampagneManager instance;
        public static CampagneManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Campagne> GetLesCampagnes()
        {
            return CampagneDAO.GetInstance().GetLesCampagnes();
        }


    }
}
