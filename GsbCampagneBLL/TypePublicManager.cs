using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class TypePublicManager
    {
        #region Singleton
        private static TypePublicManager instance;
        public static TypePublicManager GetInstance()
        {
            if (instance == null)
            {
                instance = new TypePublicManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<TypePublic> GetLesTypesPublic()
        {
            return TypePublicDAO.GetInstance().GetLesTypesPublic();
        }
    }
}
