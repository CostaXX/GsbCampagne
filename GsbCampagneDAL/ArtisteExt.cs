using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public partial class Artiste
    {
        public string LibelleCourantArtistique
        {
            get { return CourantArtistique.Libelle; }
        }
    }
}
