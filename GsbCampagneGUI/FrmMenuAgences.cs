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
    public partial class FrmMenuAgences : Form
    {
        public FrmMenuAgences()
        {
            InitializeComponent();
        }

        

        private void btnAfficherAgences_Click(object sender, EventArgs e)
        {
            Form F = new FrmListeAgences();
            F.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterAgence_Click(object sender, EventArgs e)
        {
            Form F = new FrmAjouterAgences();
            F.Show();
        }

        private void btnModifierSupprimerAgence_Click(object sender, EventArgs e)
        {
            Form F = new FrmGererAgences();
            F.Show();
        }
    }
}
