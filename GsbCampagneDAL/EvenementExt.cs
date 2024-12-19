using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public partial class Evenement
    {
        public string LibelleTheme
        {
            get { return Theme.Libelle; }
        }

        public string NomVille
        {
            get { return Ville.Nom; }
        }

        public string VIPCategorie
        {
            get { return CategorieVIP.Libelle; }
        }

        public string IntituleCampagne
        {
            get { return Campagne.Intitule; }
        }
    }
}
