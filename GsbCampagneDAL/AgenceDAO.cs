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
            using (var ctx = new CampagneEntities)
        }
    }
}
