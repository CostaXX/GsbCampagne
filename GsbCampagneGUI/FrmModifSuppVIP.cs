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
    public partial class FrmModifSuppVIP : Form
    {
        public FrmModifSuppVIP()
        {

            InitializeComponent();
            panel.Visible = false;
            #region Remplir la liste des Vips
            cboVip.DataSource = VipManager.GetInstance().GetLesVips();
            cboVip.DisplayMember = "Nom";
            cboVip.ValueMember = "Id";
            cboVip.SelectedIndex = -1;
            #endregion
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



        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboVip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVip.SelectedIndex != -1)
            {
                VIP leVip = (VIP)cboVip.SelectedItem;
                txtNom.Text = leVip.Nom;
                txtAdresse.Text = leVip.AdressePostal;
                txtEmail.Text = leVip.Email;
                cboCategVip.SelectedValue = leVip.IdCategorieVIP;
                cboVille.SelectedValue = leVip.CodeInseeVille;

                panel.Visible = true;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
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
                try
                {

                    VIP v = (VIP)cboVip.SelectedItem;
                    v.Nom = txtNom.Text;
                    v.AdressePostal = txtAdresse.Text;
                    v.Email = txtEmail.Text;
                    v.IdCategorieVIP = Convert.ToInt32(cboCategVip.SelectedValue.ToString());
                    v.CodeInseeVille = cboVille.SelectedValue.ToString();
                    VipManager.GetInstance().ModifierUnVip(v);
                    MessageBox.Show("Vip Modifier", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour du Vip : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
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
                try
                {

                    VIP v = (VIP)cboVip.SelectedItem;
                    v.Nom = txtNom.Text;
                    v.AdressePostal = txtAdresse.Text;
                    v.Email = txtEmail.Text;
                    v.IdCategorieVIP = Convert.ToInt32(cboCategVip.SelectedValue.ToString());
                    v.CodeInseeVille = cboVille.SelectedValue.ToString();
                    VipManager.GetInstance().SupprimerUnVip(v);
                    MessageBox.Show("Vip Supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour du Vip : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


