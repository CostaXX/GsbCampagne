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
    public partial class FrmGestionCampagnes : Form
    {
        public FrmGestionCampagnes()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FrmAfficherCampagnes frmAfficherCampagnes = new FrmAfficherCampagnes();
            frmAfficherCampagnes.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterCampagnes frmAjouterCampagnes = new FrmAjouterCampagnes();
            frmAjouterCampagnes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGererCampagnes frmGererCampagnes = new FrmGererCampagnes();
            frmGererCampagnes.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
