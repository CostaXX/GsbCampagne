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

        public Agence GetLesAgencesById(int id)
        {
            Agence a = new Agence();
            a.Id = id;
            return AgenceDAO.GetInstance().GetLesAgencesById(a);
        }

        public int AjouterUneAgence(string leLibelle, string ladresse, string leTelephone, string lemail, 
            string leSiteWeb, string leTypeAgence, string leCodeInseeVille)
        {
            Agence a = new Agence();
            a.Libelle = leLibelle;
            a.Adresse = ladresse;
            a.Telephone = leTelephone;
            a.Email = lemail;
            a.SiteWeb = leSiteWeb;
            a.TypeAgence = leTypeAgence;
            a.CodeInseeVille = leCodeInseeVille;
            return AgenceDAO.GetInstance().AjouterUneAgence(a);
        }

        public int ModifierUneAgence(int id, string leLibelle, string ladresse, string leTelephone, 
            string lemail, string leSiteWeb, string leTypeAgence, string leCodeInseeVille)
        {
            Agence a = new Agence();
            
            a.Id = id;
            a.Libelle = leLibelle;
            a.Adresse = ladresse;
            a.Telephone = leTelephone;
            a.Email = lemail;
            a.SiteWeb = leSiteWeb;
            a.TypeAgence = leTypeAgence;
            a.CodeInseeVille = leCodeInseeVille;
            return AgenceDAO.GetInstance().ModifierUneAgence(a);
        }

        public int SupprimerUneAgence(int id)
        {
            Agence a = new Agence();

            a.Id = id;
            return AgenceDAO.GetInstance().SupprimerUneAgence(a);
        }

        public List<Agence> GetLesAgencesCommunication()
        {
            return AgenceDAO.GetInstance().GetLesAgencesCommunication();
        }

        public List<Agence> GetLesAgencesEvenementiel()
        {
            return AgenceDAO.GetInstance().GetLesAgencesEvenementiel();
        }
    }
}
