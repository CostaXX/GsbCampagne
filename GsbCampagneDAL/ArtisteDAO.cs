using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class ArtisteDAO
    {
        #region Singleton
        private static ArtisteDAO instance;
        public static ArtisteDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ArtisteDAO();
            }
            return instance;
        }
        #endregion
        public List<Artiste> GetLesArtistes()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Artistes
                .Include("CourantArtistique")
                .ToList();
                return liste;
            }
        }
        public int AjouterUnArtiste(Artiste a)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_artiste_add(a.Nom, a.SiteWeb, a.IdCourantArtistique);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public int SupprimerUnArtiste(Artiste a)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_artiste_delete(a.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public int ModifierUnArtiste(Artiste a)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_artiste_update(a.Id, a.Nom, a.SiteWeb,a.IdCourantArtistique);
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
