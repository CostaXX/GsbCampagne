using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class TypePublicDAO
    {
        #region Singleton
        private static TypePublicDAO instance;
        public static TypePublicDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new TypePublicDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<TypePublic> GetLesTypesPublic()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.TypePublics
                .ToList();
                return liste;
            }
        }
    }
}
