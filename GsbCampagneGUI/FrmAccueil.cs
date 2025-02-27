using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsbCampagneDAL;

namespace GsbCampagneGUI
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
            desactiveMenus();
        }

        private Salarie salarieAuthentifie;

        private void activeMenus() 
        {
            if (salarieAuthentifie.Role.Libelle == "Directeur commercial" || salarieAuthentifie.Role.Libelle == "Directeur financier")
            {
                btnGestionVIP.Enabled = true;
            }

            if(salarieAuthentifie.Role.Libelle == "Employé service de communication")
            {
                btnGestionAgences.Enabled = true;
                btnGestionCampagnes.Enabled = true;
                btnGestionEvenements.Enabled = true;
            }
        }
    
        public void desactiveMenus()
        {
            btnGestionAgences.Enabled = false;
            btnGestionVIP.Enabled = false;
            btnGestionCampagnes.Enabled = false;
            btnGestionEvenements.Enabled = false;
        }


        private void FrmAccueil_Shown(object sender, EventArgs e)
        {
            using (FrmAuthentification formLogin = new FrmAuthentification())
            {
                // Affiche le formulaire de connexion qui va se charger de récupérer les
                // les informations de l’utilisateur authentifié
                formLogin.ShowDialog();

                salarieAuthentifie = formLogin.Salarie;
            }

            if(salarieAuthentifie != null)
            {
                activeMenus();
            }
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            FrmMenuEvenements form = new FrmMenuEvenements();
            form.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionCampagnes_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionAgences_Click(object sender, EventArgs e)
        {
            FrmMenuAgences form = new FrmMenuAgences();
            form.Show();
        }
    }
}
