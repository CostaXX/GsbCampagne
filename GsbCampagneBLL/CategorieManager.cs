using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class CategorieManager
    {
        #region Instance
        private static CategorieManager instance;
        public static CategorieManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieManager();
            }
            return instance;
        }
        #endregion

        public List<CategorieVIP> GetLesCategoriesVIP()
        {
            return CategorieDAO.GetInstance().GetLesCategoriesVIP();
        }
    }
}
