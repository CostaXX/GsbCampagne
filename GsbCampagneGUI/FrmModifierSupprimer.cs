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
    public partial class FrmModifierSupprimer : Form
    {
        public FrmModifierSupprimer()
        {
            InitializeComponent();
            remplirListeAgences();
            remplirListeVille();
            pnlModification.Visible = false;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
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
                string leLibelle = txtNom.Text;
                string adresse = txtAdresse.Text;
                int numeroTelephone = Convert.ToInt32(txtTelephone.Text);
                string leemail = txtEmail.Text;
                string leSiteWeb = txtSiteWeb.Text;
                string AgenceCommunication = null;
                string AgenceEvenementiel = null;
                int inseeVille = Convert.ToInt32(cboVille.SelectedValue.ToString());

                if (cboType.Text == "agence de communication")
                {
                    AgenceCommunication = "agence de communication";
                }

                if (cboType.Text == "agence évenementiel artistique")
                {
                    AgenceEvenementiel = "agence évenementiel artistique";
                }
                int valRet = AgenceManager.GetInstance().ModifierUneAgence(leLibelle, adresse, numeroTelephone, leemail, leSiteWeb, AgenceCommunication, AgenceEvenementiel, inseeVille);
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
        }
    }
}
