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
    public partial class FrmAjouterAgences : Form
    {
        public FrmAjouterAgences()
        {
            InitializeComponent();
            remplirListeVille();
            cboType.SelectedIndex = -1;
            cboType.Items.Add("agence de communication");
            cboType.Items.Add("agence évenementiel artistique");
        }

        public void remplirListeVille()
        {
            cboVille.DataSource = VilleDAO.GetInstance().GetLesVilles();
            cboVille.DisplayMember = "Nom";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVille.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            #region Controle de saisie
            string erreurs = "";
            if(string.IsNullOrWhiteSpace(txtNom.Text) == true)
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
            if(txtTelephone.Text.Length < 10 || txtTelephone.Text.Length > 10)
            {
                erreurs += "Le numéro de téléphone doit contenir 10 chiffres\n";
            }
            if (string.IsNullOrWhiteSpace(txtTelephone.Text) == true)
            {
                erreurs += "Le numéro de téléphone doit être renseignée\n";
                txtTelephone.Focus();
            }else if(ret == false)
            {
                erreurs += "Le numéro de telephone doit étre numérique\n";
                txtTelephone.Focus();
            }

            if(string.IsNullOrWhiteSpace(txtEmail.Text) == true)
            {
                erreurs += "L'email doit être renseignée\n";
                txtEmail.Focus();
            }

            if(string.IsNullOrWhiteSpace(txtSiteWeb.Text) == true)
            {
                erreurs += "Un site web doit étre renseigné\n";
                txtSiteWeb.Focus();
            }

            if(cboType.SelectedIndex == -1)
            {
                erreurs += "Un type doivt être renseigné\n";
                cboType.Focus();
            }

            if(cboVille.SelectedIndex == -1)
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
                string libelle = txtNom.Text;
                string adresse = txtAdresse.Text;
                string numeroTelephone = txtTelephone.Text;
                string email = txtEmail.Text;
                string siteWeb = txtSiteWeb.Text;
                string typeAgence = "";
                string CodeInseeVille = cboVille.SelectedValue.ToString();

                if (cboType.Text == "agence de communication")
                {
                    typeAgence = "C";
                }
                else
                {
                    typeAgence = "E";
                }
                int valRet = AgenceManager.GetInstance().AjouterUneAgence(libelle, adresse, numeroTelephone, email, 
                    siteWeb, typeAgence,CodeInseeVille);
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
    }
}
