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
    public partial class FrmAjoutVip : Form
    {
        public FrmAjoutVip()
        {
           
            InitializeComponent();
            #region Remplir la liste des catégories
            cboCategVip.DataSource = CategorieVipDAO.GetInstance().GetLesCategoriesVIP();
            cboCategVip.DisplayMember = "Libelle";
            cboCategVip.ValueMember = "Id";
            cboCategVip.SelectedIndex = -1;
            #endregion
            #region Remplir la liste des catégories
            cboVille.DataSource = VilleDAO.GetInstance().GetLesVilles();
            cboVille.DisplayMember = "Nom";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;
            #endregion

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtNom.Text) == true)
            {
                erreurs += "Le nom du vip doit être renseigné\n";
                txtNom.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtAdresse.Text) == true)
            {
                erreurs += "L'Adresses doit être renseigné\n";
                txtAdresse.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) == true)
            {
                erreurs += "L'Email doit être renseigné\n";
                txtEmail.Focus();
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                erreurs += "L'adresse email n'est pas valide\n";
                txtEmail.Focus();
            }

            if (cboCategVip.SelectedIndex == -1)
            {
                erreurs += "La catégorie du VIP doit être renseignée\n";
            }

            if (cboVille.SelectedIndex == -1)
            {
                erreurs += "La ville du VIP doit être renseignée\n";
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
                string adresses = txtAdresse.Text;
                string email = txtEmail.Text;
                int idCategorieVip = Convert.ToInt32(cboCategVip.SelectedValue.ToString());
                string CodeInseeVille = cboVille.SelectedValue.ToString();
                VipManager.GetInstance().AjouterUnVip(nom,adresses,email,idCategorieVip,CodeInseeVille);
                MessageBox.Show("Vip ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
