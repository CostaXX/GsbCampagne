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
                    .Include("CategorieVIP")
                    .Include("Campagne")
                    .Include("Ville")
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
                    ctx.sp_evenement_add(e.DateDebut, e.DateFin, e.Intitule, e.IdTheme, e.CodeInseeVille , e.IdCategorieVIP, e.IdCampagne);
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
                    ctx.sp_evenement_update(e.Id, e.DateDebut, e.DateFin, e.Intitule, e.IdTheme, e.CodeInseeVille, e.IdCategorieVIP, e.IdCampagne);
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
                    ctx.sp_evenement_delete(e.Id);
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
