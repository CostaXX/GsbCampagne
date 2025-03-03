using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneDAL
{
    public partial class Campagne
    {
     
        public string LibelleTypePublic
        {
            get { return TypePublic.Libelle; }
        }
        public string LibelleAgenceCommunication
        {
            get { return (IdAgenceCommunication != null) ? Agence?.Libelle : null ; }
        }

        public string LibelleAgenceEvenementiel
        {
            get { return (IdAgenceEvenementiel != null) ? Agence1?.Libelle : null; }
        }
        public string LibelleSalarie
        {
            get { return Salarie.Nom; }
        }



    }
}
