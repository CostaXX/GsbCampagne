using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GsbCampagneBLL
{
    public class EvenementManager
    {
        #region Instance
        private static EvenementManager instance;
        public static EvenementManager GetInstance()
        {
            if (instance == null)
            {
                instance = new EvenementManager();
            }
            return instance;
        }
        #endregion
        public List<Evenement> GetLesEvenements()
        {
            return EvenementDAO.GetInstance().GetLesEvenements();
        }

        public int AjouterEvenements(DateTime dateDebut, DateTime dateFin, string intitule, int IdTheme, string CodeInseeVille, int IdCategorieVIP, int IdCampagne)
        {
            Evenement e = new Evenement();
            e.DateDebut = dateDebut;
            e.DateFin = dateFin;
            e.Intitule = intitule;
            e.IdTheme = IdTheme;
            e.CodeInseeVille = CodeInseeVille;
            e.IdCategorieVIP = IdCategorieVIP;
            e.IdCampagne = IdCampagne;
            return EvenementDAO.GetInstance().AjouterEvenements(e);
        }
        public int ModifierEvenements(Evenement e)
        {
            return EvenementDAO.GetInstance().ModifierEvenements(e);
        }

        public int SupprimerEvenements(int Id)
        {
            Evenement e = new Evenement();
            e.Id = Id;
            return EvenementDAO.GetInstance().SupprimerEvenements(e);
        }

    }
}
