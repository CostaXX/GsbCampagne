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
    public partial class FrmGererAgences : Form
    {
        public FrmGererAgences()
        {
            InitializeComponent();
            remplirListeAgences();
            remplirListeVille();
            pnlModification.Visible = false;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            cboType.SelectedIndex = -1;
            cboType.Items.Add("agence de communication");
            cboType.Items.Add("agence évenementiel artistique");
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgence.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVille.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void remplirListeAgences()
        {
            cboAgence.DataSource = AgenceManager.GetInstance().GetLesAgences();
            cboAgence.DisplayMember = "Libelle";
            cboAgence.ValueMember = "Id";
            cboAgence.SelectedIndex = -1;
        }

        public void remplirListeVille()
        {
            cboVille.DataSource = VilleDAO.GetInstance().GetLesVilles();
            cboVille.DisplayMember = "Nom";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            #region Controle de saisie
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtNom.Text) == true)
            {
                erreurs += "Le nom de l'agence doit être renseigné\n";
                txtNom.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtAdresse.Text) == true)
            {
                erreurs += "L'adresse doit être renseigné\n";
                txtAdresse.Focus();
            }

            int numero;
            bool ret = int.TryParse(txtTelephone.Text, out numero);
            if (txtTelephone.Text.Length < 10 || txtTelephone.Text.Length > 10)
            {
                erreurs += "Le numéro de téléphone doit contenir 10 chiffres\n";
            }
            if (string.IsNullOrWhiteSpace(txtTelephone.Text) == true)
            {
                erreurs += "Le numéro de téléphone doit être renseignée\n";
                txtTelephone.Focus();
            }
            else if (ret == false)
            {
                erreurs += "Le numéro de telephone doit étre numérique\n";
                txtTelephone.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) == true)
            {
                erreurs += "L'email doit être renseignée\n";
                txtEmail.Focus();
            }

            if (string.IsNullOrWhiteSpace(txtSiteWeb.Text) == true)
            {
                erreurs += "Un site web doit étre renseigné\n";
                txtSiteWeb.Focus();
            }

            if (cboType.SelectedIndex == -1)
            {
                erreurs += "Un type doivt être renseigné\n";
                cboType.Focus();
            }

            if (cboVille.SelectedIndex == -1)
            {
                erreurs += "Une ville doit être renseignée\n";
            }

            #endregion
            
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(cboAgence.SelectedValue.ToString());
                string libelle = txtNom.Text;
                string adresse = txtAdresse.Text;
                string numeroTelephone = txtTelephone.Text;
                string email = txtEmail.Text;
                string siteWeb = txtSiteWeb.Text;
                string typeAgence = "";
                string codeInseeVille = cboVille.SelectedValue.ToString();

                if (cboType.Text == "agence de communication")
                {
                    typeAgence = "C";
                }
                else
                {
                    typeAgence = "E";
                }
                int valRet = AgenceManager.GetInstance().ModifierUneAgence(id,libelle, adresse, numeroTelephone, 
                    email, siteWeb, typeAgence, codeInseeVille);
                if (valRet == 0)
                {
                    MessageBox.Show("Agence ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Probléme durant la mise a jour de la base de données", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboAgence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
                pnlModification.Visible = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
            int id = Convert.ToInt32(cboAgence.SelectedValue.ToString());
            Agence valRet = AgenceManager.GetInstance().GetLesAgencesById(id);
            txtNom.Text = valRet.Libelle;
            txtAdresse.Text = valRet.Adresse;
            txtTelephone.Text = valRet.Telephone;
            txtEmail.Text = valRet.Email;
            txtSiteWeb.Text = valRet.SiteWeb;
            if(valRet.TypeAgence == "C")
            {
                cboType.SelectedIndex = 0;
            }
            else
            {
                cboType.SelectedIndex = 1;
            }
            cboVille.SelectedValue = valRet.CodeInseeVille;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboAgence.SelectedValue.ToString());
            int valRet = AgenceManager.GetInstance().SupprimerUneAgence(id);
            if (valRet == 0)
            {
                MessageBox.Show("Agence supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Probléme durant la mise a jour de la base de données", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
