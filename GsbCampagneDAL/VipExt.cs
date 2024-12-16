using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneDAL
{
    public partial class VIP
    {
        public string LibelleCategorieVip
        {
            get { return CategorieVIP.Libelle; }
        }

        public string NomVille
        {
            get { return Ville.Nom; }
        }
    }

}
