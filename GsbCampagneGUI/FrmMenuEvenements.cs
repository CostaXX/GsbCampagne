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
    public partial class FrmMenuEvenements : Form
    {
        public FrmMenuEvenements()
        {
            InitializeComponent();

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterEvenement form = new FrmAjouterEvenement();
            form.Show();
        }

        private void btnAfficherEvenements_Click(object sender, EventArgs e)
        {
            FrmConsulterEvenement form = new FrmConsulterEvenement();
            form.Show();    
        }

        private void btnGererEvenement_Click(object sender, EventArgs e)
        {
            FrmGererEvenement form = new FrmGererEvenement();
            form.Show();
        }
    }
}
