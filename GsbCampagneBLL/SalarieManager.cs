using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace GsbCampagneBLL
{
    public class SalarieManager
    {
        #region Singleton
        private static SalarieManager instance;
        public static SalarieManager GetInstance()
        {
            if (instance == null)
            {
                instance = new SalarieManager();
            }
            return instance;
        }
        #endregion Singleton

        public Salarie GetInfosSalarie(string login, string motPasse)
        {
            Salarie salarie = SalarieDAO.GetInstance().GetInfosSalarie(login);

            if(salarie == null)
            {
                return salarie;
            }
            if (BCrypt.Net.BCrypt.Verify(motPasse, salarie.Mdp) == false)
            {
                salarie = null;
            }
            return salarie;
        }

        public List<Salarie> GetLesSalaries()
        {
            return SalarieDAO.GetInstance().GetLesSalaries();
        }
    }
}
