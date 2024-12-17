using GsbCampagneBLL;
using GsbCampagneDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsbCampagneGUI
{
    public partial class FrmAjoutArtiste : Form
    {
        public FrmAjoutArtiste()
        {
            InitializeComponent();
            #region Remplir la liste des catégories
            cboCourantArtiste.DataSource = CourantArtistiqueDAO.GetInstance().GetLesCourantArtistiques();
            cboCourantArtiste.DisplayMember = "Libelle";
            cboCourantArtiste.ValueMember = "Id";
            cboCourantArtiste.SelectedIndex = -1;
            #endregion
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtNom.Text) == true)
            {
                erreurs += "Le nom de l'artiste doit être renseigné\n";
                txtNom.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtSiteWeb.Text) == true)
            {
                erreurs += "Le site web doit être renseigné\n";
                txtSiteWeb.Focus();
            }


            if (cboCourantArtiste.SelectedIndex == -1)
            {
                erreurs += "La catégorieArtistique de l'artiste doit être renseignée\n";
            }

            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Enregistrement du produit dans la BDD
                string nom = txtNom.Text;
                string siteweb = txtSiteWeb.Text;
                int idCategorieVip = Convert.ToInt32(cboCourantArtiste.SelectedValue.ToString());
                ArtisteManager.GetInstance().AjouterUnArtiste(nom, siteweb, idCategorieVip);
                MessageBox.Show("Artiste ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
