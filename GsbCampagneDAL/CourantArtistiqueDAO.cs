using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class CourantArtistiqueDAO
    {
        #region Singleton
        private static CourantArtistiqueDAO instance;
        public static CourantArtistiqueDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new CourantArtistiqueDAO();
            }
            return instance;
        }
        #endregion

        public List<CourantArtistique> GetLesCourantArtistiques()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.CourantArtistiques
                .ToList();
                return liste;
            }
        }
    }
}
