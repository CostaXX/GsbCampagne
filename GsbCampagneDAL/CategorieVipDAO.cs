using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CategorieVipDAO
    {
        #region Singleton
        private static CategorieVipDAO instance;
        public static CategorieVipDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieVipDAO();
            }
            return instance;
        }
        #endregion

        public List<CategorieVIP> GetLesCategoriesVip()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.CategorieVIPs
                .ToList();
                return liste;
            }
        }
    }
}
