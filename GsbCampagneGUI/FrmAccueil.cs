using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsbCampagneBLL;
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
            if (salarieAuthentifie.Role.Libelle == "Directeur service communication" || salarieAuthentifie.Role.Libelle == "Directeur financier")
            {
                btnGestionCategorieVIP.Enabled = true;
            }
            btnGestionAgences.Enabled = true;
            btnCampagnes.Enabled = true;
            btnGestionEvenements.Enabled = true;
            btnGestionArtistes.Enabled = true;
            btnGestionCourantArtistiques.Enabled = true;
            btnGestionVIP.Enabled = true;
            if (salarieAuthentifie.Role.Libelle == "Employé service de communication")
            {
                btnGestionCategorieVIP.Enabled = false;
            }
        }
    
        public void desactiveMenus()
        {
            btnGestionCategorieVIP.Enabled = false;
        }


        private void FrmAccueil_Shown(object sender, EventArgs e)
        {
            using (FrmAuthentification formLogin = new FrmAuthentification())
            {
                // Affiche le formulaire de connexion qui va se charger de récupérer les
                // les informations de l’utilisateur authentifié
                formLogin.ShowDialog();

                SessionUtilisateur.UtilisateurConnecte = formLogin.Salarie;
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

        private void btnGestionAgences_Click(object sender, EventArgs e)
        {
            FrmMenuAgences form = new FrmMenuAgences();
            form.Show();
        }

        private void btnGestionVIP_Click(object sender, EventArgs e)
        {
            FrmMenuVip form = new FrmMenuVip();
            form.Show();
        }

        private void btnGestionArtistes_Click(object sender, EventArgs e)
        {
            FrmMenuArtiste form = new FrmMenuArtiste();
            form.Show();

        }

        private void btnGestionCourantArtistiques_Click(object sender, EventArgs e)
        {
            FrmMenuCourantArtistes form = new FrmMenuCourantArtistes();
            form.Show();
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
