using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneBLL
{
    public class CampagneManager
    {
        #region Singleton
        private static CampagneManager instance;
        public static CampagneManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CampagneManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Campagne> GetLesCampagnes()
        {
            return CampagneDAO.GetInstance().GetAllCampagnes();
        }

        public int AjouterCampagne(Campagne campagne)
        {

            Campagne c = new Campagne();
            c.Intitule = campagne.Intitule;
            c.Objectif = campagne.Objectif;
            c.DateDebut = campagne.DateDebut;
            c.DateFin = campagne.DateFin;
            c.IdSalarie = campagne.IdSalarie;
            c.IdTypePublic = campagne.IdTypePublic;
            c.IdAgenceCommunication = campagne.IdAgenceCommunication;
            c.IdAgenceEvenementiel = campagne.IdAgenceEvenementiel;

            return CampagneDAO.GetInstance().AjouterCampagne(c);
        }

        public int ModifierCampagne(Campagne campagne)
        {
            Campagne c = new Campagne();
            c.Id = campagne.Id;
            c.Intitule = campagne.Intitule;
            c.Objectif = campagne.Objectif;
            c.DateDebut = campagne.DateDebut;
            c.DateFin = campagne.DateFin;
            c.IdSalarie = campagne.IdSalarie;
            c.IdTypePublic = campagne.IdTypePublic;
            c.IdAgenceCommunication = campagne.IdAgenceCommunication;
            c.IdAgenceEvenementiel = campagne.IdAgenceEvenementiel;

            return CampagneDAO.GetInstance().ModifierCampagne(c);
        }

        public int SupprimerCampagne(Campagne campagne)
        {
            Campagne c = new Campagne();
            c.Id = campagne.Id;
            return CampagneDAO.GetInstance().SupprimerCampagne(c);
        }

    }
}
