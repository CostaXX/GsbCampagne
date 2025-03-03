using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CategorieVIPDAO
    {
        #region Singleton
        private static CategorieVIPDAO instance;
        public static CategorieVIPDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieVIPDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<CategorieVIP> GetLesCategoriesVIP()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.CategorieVIPs
                .ToList();
                return liste;
            }
        }

        public int AjouterCategorieVIP(CategorieVIP c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_categorieVIP_add(c.Libelle);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int ModifierCategorieVIP(CategorieVIP c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_categorieVIP_edit(c.Id, c.Libelle);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerCategorieVIP(CategorieVIP c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_categorieVIP_delete(c.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
    }
}
