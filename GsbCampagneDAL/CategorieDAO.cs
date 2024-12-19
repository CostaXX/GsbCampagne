using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CategorieDAO
    {
        #region Instance
        private static CategorieDAO instance;
        public static CategorieDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieDAO();
            }
            return instance;
        }
        #endregion

        public List<CategorieVIP> GetLesCategoriesVIP()
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
