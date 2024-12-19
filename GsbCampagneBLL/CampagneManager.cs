using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class CampagneManager
    {
        #region Instance
        private static CampagneManager instance;
        public static CampagneManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneManager();
            }
            return instance;
        }
        #endregion 

        public List<Campagne> GetLesCampagnes()
        {
            return CampagneDAO.GetInstance().GetLesCampagnes();
        }
    }
}
