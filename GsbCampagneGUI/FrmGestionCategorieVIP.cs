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
    public partial class FrmGestionCategorieVIP : Form
    {
        public FrmGestionCategorieVIP()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FrmAfficherCategorieVIP frmAfficherCategorieVIP = new FrmAfficherCategorieVIP();
            frmAfficherCategorieVIP.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterCategorieVIP frmAjouterCategorieVIP = new FrmAjouterCategorieVIP();
            frmAjouterCategorieVIP.Show();
        }

        private void btnGerer_Click(object sender, EventArgs e)
        {
            FrmGererCategorieVIP frmGererCategorieVIP = new FrmGererCategorieVIP();
            frmGererCategorieVIP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
