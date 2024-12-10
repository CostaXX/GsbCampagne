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
            desactiveMenus();
        }


        public void desactiveMenus()
        {
            btnGestionAgences.Enabled = false;
            btnGestionVIP.Enabled = false;
            btnGestionCampagnes.Enabled = false;
            btnGestionEvenements.Enabled = false;
        }
        private void btnGestionAgences_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmAccueil_Shown(object sender, EventArgs e)
        {
            using (FrmAuthentification formLogin = new FrmAuthentification())
            {
                // Affiche le formulaire de connexion qui va se charger de récupérer les
                // les informations de l’utilisateur authentifié
                formLogin.ShowDialog();
            }
        }
    }
}
