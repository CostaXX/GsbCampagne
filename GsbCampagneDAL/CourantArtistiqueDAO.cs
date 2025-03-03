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

        public int AjouterUneCategArtiste(CourantArtistique a)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_CourantArtistique_add(a.Libelle);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerUneCategArtiste(CourantArtistique a)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_CourantArtistique_delete(a.Id);
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
