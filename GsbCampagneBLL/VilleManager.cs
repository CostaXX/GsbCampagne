using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class VilleManager
    {

        #region Singleton
        private static VilleManager instance;
        public static VilleManager GetInstance()
        {
            if (instance == null)
            {
                instance = new VilleManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Ville> GetLesVilles()
        {
            return VilleDAO.GetInstance().GetLesVilles();
        }
    }
}
