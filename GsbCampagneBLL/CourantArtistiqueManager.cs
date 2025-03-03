using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;


namespace GsbCampagneBLL
{
    public class CourantArtistiqueManager
    {
        #region Singleton
        private static CourantArtistiqueManager instance;
        public static CourantArtistiqueManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CourantArtistiqueManager();
            }
            return instance;
        }
        #endregion Singleton
        public List<CourantArtistique> GetLesCourantArtistiques()
        {
            return CourantArtistiqueDAO.GetInstance().GetLesCourantArtistiques();
        }
        public int AjouterUneCategArtiste(string libelle)
        {
            CourantArtistique a = new CourantArtistique();
            a.Libelle = libelle;


            return CourantArtistiqueDAO.GetInstance().AjouterUneCategArtiste(a);
        }
        public int SupprimerUneCategArtiste(CourantArtistique a)
        {
            return CourantArtistiqueDAO.GetInstance().SupprimerUneCategArtiste(a);
        }

    }
}
