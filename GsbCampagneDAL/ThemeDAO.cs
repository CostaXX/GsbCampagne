using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class ThemeDAO
    {
        #region Instance
        private static ThemeDAO instance;
        public static ThemeDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ThemeDAO();
            }
            return instance;
        }
        #endregion 

        public List<Theme> GetLesThemes() 
        {

            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Themes
                    .ToList();
                return liste;
            }
        }

    }
}
