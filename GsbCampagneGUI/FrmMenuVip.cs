using GsbCampagneBLL;
using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsbCampagneGUI
{
    public partial class FrmMenuVip : Form
    {
        public FrmMenuVip()
        {
            InitializeComponent();
        }


        private void btnConsulterVip_Click(object sender, EventArgs e)
        {
           FrmConsulterVip form = new FrmConsulterVip();
            form.ShowDialog();
        }

        private void btnAjouterVip_Click(object sender, EventArgs e)
        {
            FrmAjoutVip form = new FrmAjoutVip();
            form.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGererVip_Click(object sender, EventArgs e)
        {
            FrmModifSuppVIP form = new FrmModifSuppVIP();
            form.ShowDialog();
        }

        private void FrmMenuVip_Shown(object sender, EventArgs e)
        {
            if (SessionUtilisateur.UtilisateurConnecte.Role.Libelle == "Directeur commercial" || SessionUtilisateur.UtilisateurConnecte.Role.Libelle == "Directeur financier")
            {
                btnGererVip.Enabled = true;
                btnAjouterVip.Enabled = true;
            }
            else
            {
                btnGererVip.Enabled = false;
                btnAjouterVip.Enabled = false;
            }
        }
    }
}
