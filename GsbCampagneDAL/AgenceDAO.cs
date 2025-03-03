using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class AgenceDAO
    {
        #region Singleton
        private static AgenceDAO instance;
        public static AgenceDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new AgenceDAO();
            }
            return instance;
        }
        #endregion

        public List<Agence> GetLesAgences() 
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Agences
                    .Include("Ville")
                    .ToList();
                return liste;
            }
        }

        public Agence GetLesAgencesById(Agence agence)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
               var a = ctx.Agences
                    .Include("Ville")
                    .Where(x => x.Id == agence.Id)
                    .FirstOrDefault();
                return a;
            }
        }

        public int AjouterUneAgence(Agence agence)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_add(agence.Libelle, agence.Adresse, agence.Telephone, agence.Email, agence.SiteWeb,
                        agence.TypeAgence, agence.CodeInseeVille);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            
        }

        public int ModifierUneAgence(Agence agence)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_update(agence.Id, agence.Libelle, agence.Adresse, agence.Telephone,
                        agence.Email, agence.SiteWeb, agence.TypeAgence, agence.CodeInseeVille);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerUneAgence(Agence agence)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_delete(agence.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public List<Agence> GetLesAgencesCommunication()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Agences
                .Include("Ville")
                .Where(a => a.TypeAgence == "C")
                .ToList();
                return liste;
            }
        }
        
        public List<Agence> GetLesAgencesEvenementiel()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Agences
                .Include("Ville")
                .Where(a => a.TypeAgence == "E")
                .ToList();
                return liste;
            }
        }
    }
}
