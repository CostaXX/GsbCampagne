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
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btnCampagnes_Click(object sender, EventArgs e)
        {
            FrmGestionCampagnes frmGestionCampagnes = new FrmGestionCampagnes();
            frmGestionCampagnes.Show();
        }

        private void btnGestionCategorieVIP_Click(object sender, EventArgs e)
        {
            FrmGestionCategorieVIP frmGestionCategorieVIP = new FrmGestionCategorieVIP();
            frmGestionCategorieVIP.Show();
        }
    }
}
