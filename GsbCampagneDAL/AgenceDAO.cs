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
        #endregion Singleton

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
        
        public List<Agence> GetLesAgencesCommunication()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Agences
                .Include("Ville")
                .Where(a => a.TypeCommunication != null)
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
                .Where(a => a.TypeEvenementiel != null)
                .ToList();
                return liste;
            }
        }
    }
}
