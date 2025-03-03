using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class CategorieVIPManager
    {
        #region Singleton
        private static CategorieVIPManager instance;
        public static CategorieVIPManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CategorieVIPManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<CategorieVIP> GetLesCategoriesVIP()
        {
            return CategorieVipDAO.GetInstance().GetLesCategoriesVIP();
        }
        public int AjouterCategorieVIP(CategorieVIP categorieVIP)
        {

            CategorieVIP c = new CategorieVIP();
            c.Libelle = categorieVIP.Libelle;

            return CategorieVipDAO.GetInstance().AjouterCategorieVIP(c);
        }

        public int ModifierCategorieVIP(CategorieVIP categorieVIP)
        {
            CategorieVIP c = new CategorieVIP();
            c.Id = categorieVIP.Id;
            c.Libelle = categorieVIP.Libelle;

            return CategorieVipDAO.GetInstance().ModifierCategorieVIP(c);
        }

        public int SupprimerCategorieVIP(CategorieVIP categorieVIP)
        {
            CategorieVIP c = new CategorieVIP();
            c.Id = categorieVIP.Id;
            return CategorieVipDAO.GetInstance().SupprimerCategorieVIP(c);
        }
    }
}
