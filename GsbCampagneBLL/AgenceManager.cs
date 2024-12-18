using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class AgenceManager
    {
        #region Singleton
        private static AgenceManager instance;
        public static AgenceManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AgenceManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Agence> GetLesAgences()
        {
            return AgenceDAO.GetInstance().GetLesAgences();
        }

        public List<Agence> GetLesAgencesCommunication()
        {
            return AgenceDAO.GetInstance().GetLesAgencesCommunication();
        }

        public List<Agence> GetLesAgencesEvenementiel()
        {
            return AgenceDAO.GetInstance().GetLesAgencesEvenementiel();
        }
    }
}
