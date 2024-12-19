using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class ThemeManager
    {
        #region Instance
        private static ThemeManager instance;
        public static ThemeManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ThemeManager();
            }
            return instance;
        }
        #endregion 

        public List<Theme> GetLesThemes()
        {
            return ThemeDAO.GetInstance().GetLesThemes();
        }

    }
}
