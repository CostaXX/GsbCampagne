using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
>>>>>>> d79df52da9902ed14a28e3e199a74ac852949cef
namespace GsbCampagneDAL
{
    public class VilleDAO
    {
<<<<<<< HEAD
        #region Instance
=======
        #region Singleton
>>>>>>> d79df52da9902ed14a28e3e199a74ac852949cef
        private static VilleDAO instance;
        public static VilleDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new VilleDAO();
            }
            return instance;
        }
        #endregion

<<<<<<< HEAD
        #region Listes des villes
        public List<Ville> GetLesVilles()
=======
        public List<Ville> GetLesVilles() 
>>>>>>> d79df52da9902ed14a28e3e199a74ac852949cef
        {
            using (var ctx = new GsbCampagnesEntities())
            {
                var liste = ctx.Villes
                    .ToList();
                return liste;
            }
        }
<<<<<<< HEAD
        #endregion



=======
>>>>>>> d79df52da9902ed14a28e3e199a74ac852949cef
    }
}
