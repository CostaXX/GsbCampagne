using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneBLL
{
    public class AgenceManager
    {
        #region Singleton
        private static AgenceManager instance;
        public static AgenceManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AgenceManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Agence> GetLesAgences()
        {
            return AgenceDAO.GetInstance().GetLesAgences();
        }

        public int AjouterUneAgence(string leLibelle, string ladresse, int leTelephone, string lemail, string leSiteWeb, string leTypeCommunication, string leTypeEvenementiel, int leIdVille)
        {
            Agence a = new Agence();
            a.Libelle = leLibelle;
            a.Adresse = ladresse;
            a.Telephone = leTelephone;
            a.Email = lemail;
            a.SiteWeb = leSiteWeb;
            a.TypeCommunication = leTypeCommunication;
            a.TypeEvenementiel = leTypeEvenementiel;
            a.IdVille = leIdVille;
            return AgenceDAO.GetInstance().AjouterUneAgence(a);
        }

        public int ModifierUneAgence(string leLibelle, string ladresse, int leTelephone, string lemail, string leSiteWeb, string leTypeCommunication, string leTypeEvenementiel, int leIdVille)
        {
            Agence a = new Agence();
            a.Libelle = leLibelle;

        }
    }
}
