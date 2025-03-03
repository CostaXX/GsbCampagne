using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneBLL
{
    public class ArtisteManager
    {
        #region Singleton
        private static ArtisteManager instance;
        public static ArtisteManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ArtisteManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<Artiste> GetLesArtistes()
        {
            return ArtisteDAO.GetInstance().GetLesArtistes();
        }
         public int AjouterUnArtiste(string nom, string siteweb, int idcourantartistique)
        {
            Artiste a = new Artiste();
            a.Nom = nom;
            a.SiteWeb = siteweb;
            a.IdCourantArtistique = idcourantartistique;

            return ArtisteDAO.GetInstance().AjouterUnArtiste(a);
        }
        public int SupprimerUnArtiste(Artiste a)
        {
            return ArtisteDAO.GetInstance().SupprimerUnArtiste(a);
        }
        public int ModifierUnArtiste(Artiste a)
        {
            return ArtisteDAO.GetInstance().ModifierUnArtiste(a);
        }
    }
   
}
