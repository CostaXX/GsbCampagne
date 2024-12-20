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

        public int AjouterUneAgence(Agence agence)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_add(agence.Libelle, agence.Adresse, agence.Telephone, agence.Email, agence.SiteWeb, agence.TypeCommunication, agence.TypeEvenementiel, agence.IdVille);
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
