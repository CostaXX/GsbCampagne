using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public class EvenementDAO
    {
        #region Instance
        private static EvenementDAO instance;
        public static EvenementDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new EvenementDAO();
            }
            return instance;
        }
        #endregion 

        public List<Evenement> GetLesEvenements()
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Evenements
                    .Include("Theme")
                    .Include("Ville")
                    .Include("CategorieVIP")
                    .Include("Campagne")
                    .ToList();
                return liste;
            }
        }

        public int AjouterEvenements(Evenement e)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_ajoutEvenement(e.DateDebut, e.DateFin, e.Intitule, e.IdTheme, e.IdVille, e.IdCategorieVIP, e.IdCampagne);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int ModifierEvenements(Evenement e)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_modifierEvenement(e.Id, e.DateDebut, e.DateFin, e.Intitule, e.IdTheme, e.IdVille, e.IdCategorieVIP, e.IdCampagne);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerEvenements(Evenement e)
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                try
                {
                    ctx.sp_supprimeEvenement(e.Id);
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
