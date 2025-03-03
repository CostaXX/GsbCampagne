using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CampagneDAO
    {
        #region Instance
        private static CampagneDAO instance;
        public static CampagneDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneDAO();
            }
            return instance;
        }
        #endregion

        #region Liste des Campagnes
        public List<Campagne> GetLesCampagnes()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Campagnes
                    .ToList();
                return liste;
            }
        }
        #endregion

        public List<Campagne> GetAllCampagnes()
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
                    ctx.sp_campagne_add(c.Intitule, c.Objectif, c.DateDebut, c.DateFin, c.IdSalarie, c.IdTypePublic, c.IdAgenceCommunication, c.IdAgenceEvenementiel);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int ModifierCampagne(Campagne c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_campagne_update(c.Id, c.Intitule, c.Objectif , c.DateDebut, c.DateFin, c.IdSalarie, c.IdTypePublic, c.IdAgenceCommunication, c.IdAgenceEvenementiel);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerCampagne(Campagne c)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_campagne_delete(c.Id);
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
