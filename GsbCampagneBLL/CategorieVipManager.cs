using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneBLL
{
    public class CategorieVipManager
    {

        #region Singleton
        private static CategorieVipManager instance;
        public static CategorieVipManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieVipManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<CategorieVIP> GetLesCategoriesVip()
        {
            return CategorieVipDAO.GetInstance().GetLesCategoriesVip();
        }
        


    }
}
