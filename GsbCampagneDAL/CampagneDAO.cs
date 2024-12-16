using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CampagneDAO
    {
        #region Singleton
        private static CampagneDAO instance;
        public static CampagneDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Campagne> GetLesCampagnes()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Campagnes
                .Include("TypePublic")
                .Include("Agence")
                .Include("Agence1")
                .Include("Salarie")
                .ToList();
                return liste;
            }
        }

        public int AjouterCampagne(Campagne c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_campagne_add(c.Intitule, c.Objectif, c.DateDebut, c.DateFin, c.IdSalarie, c.TypePublic, c.IdAgenceCommunication, c.IdAgenceEvenementiel);
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
