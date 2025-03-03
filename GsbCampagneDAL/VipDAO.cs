using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class VipDAO
    {

        #region Singleton
        private static VipDAO instance;
        public static VipDAO GetInstance()
          {
            if (instance == null)
            {
               instance = new VipDAO();
            }
              return instance;
            }
        #endregion
        public List<VIP> GetLesVips()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.VIPs
                .Include("CategorieVIP")
                .Include("Ville")
                .ToList();
                return liste;
            }
        }
        public int AjouterUnVip(VIP v)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_vip_add(v.Nom,v.AdressePostal,v.Email,v.IdCategorieVIP,v.CodeInseeVille);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerUnVip(VIP v)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_vip_delete(v.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public int ModifierUnVip(VIP v)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_vip_update(v.Id, v.Nom, v.AdressePostal, v.Email, v.IdCategorieVIP, v.CodeInseeVille);
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