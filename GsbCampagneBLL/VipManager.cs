using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class VipManager
    {
        #region Singleton
        private static VipManager instance;
        public static VipManager GetInstance()
        {
            if (instance == null)
            {
                instance = new VipManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<VIP> GetLesVips()
        {
            return VipDAO.GetInstance().GetLesVips();
        }
        public int AjouterUnVip(string nom, string adressepostal, string email,int idcategorievip, string CodeInseeVille)
        {
            VIP v = new VIP();
            v.Nom = nom;
            v.AdressePostal = adressepostal;
            v.Email = email;
            v.IdCategorieVIP = idcategorievip;
            v.CodeInseeVille = CodeInseeVille;

            return VipDAO.GetInstance().AjouterUnVip(v);
        }
        public int SupprimerUnVip(VIP v)
        {
            return VipDAO.GetInstance().SupprimerUnVip(v);
        }
        public int ModifierUnVip(VIP v)
        {
            return VipDAO.GetInstance().ModifierUnVip(v);
        }
    }
}
