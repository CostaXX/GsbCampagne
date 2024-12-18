using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneBLL
{
    public class SalarieManager
    {
        #region Singleton
        private static SalarieManager instance;
        public static SalarieManager GetInstance()
        {
            if (instance == null)
            {
                instance = new SalarieManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Salarie> GetLesSalaries()
        {
            return SalarieDAO.GetInstance().GetLesSalaries();
        }
    }
}
