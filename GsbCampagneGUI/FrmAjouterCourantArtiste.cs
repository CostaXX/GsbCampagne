using GsbCampagneBLL;
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
    public partial class FrmAjouterCourantArtiste : Form
    {
        public FrmAjouterCourantArtiste()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtCourantArtiste.Text) == true)
            {
                erreurs += "Le libelle du courant artistique doit être renseigné\n";
                txtCourantArtiste.Focus();
            }

            else
            {
                // Enregistrement du produit dans la BDD
                string libelle = txtCourantArtiste.Text;
                CourantArtistiqueManager.GetInstance().AjouterUneCategArtiste(libelle);
                MessageBox.Show("Catégorie Artistique ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            #endregion
        }
    }
}
