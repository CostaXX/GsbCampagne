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
using GsbCampagneBLL;
using System.Text.RegularExpressions;

namespace GsbCampagneGUI
{
    public partial class FrmModifSuppArtiste : Form
    {
        public FrmModifSuppArtiste()
        {
            InitializeComponent();
            panel.Visible = false;
            #region Remplir la liste des catégories
            cboArtiste.DataSource = ArtisteDAO.GetInstance().GetLesArtistes();
            cboArtiste.DisplayMember = "nom";
            cboArtiste.ValueMember = "Id";
            cboArtiste.SelectedIndex = -1;
            #endregion
            #region Remplir la liste des catégories
            cboCourantArtiste.DataSource = CourantArtistiqueDAO.GetInstance().GetLesCourantArtistiques();
            cboCourantArtiste.DisplayMember = "Libelle";
            cboCourantArtiste.ValueMember = "Id";
            cboCourantArtiste.SelectedIndex = -1;
            #endregion
        }

        private void cboArtiste_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboArtiste.SelectedIndex != -1)
            {
                Artiste lArtiste = (Artiste)cboArtiste.SelectedItem;
                txtNom.Text = lArtiste.Nom;
                txtSiteWeb.Text = lArtiste.SiteWeb;
                cboCourantArtiste.SelectedValue = lArtiste.IdCourantArtistique;
               
                panel.Visible = true;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
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
                try
                {

                    Artiste a = (Artiste)cboArtiste.SelectedItem;
                    a.Nom = txtNom.Text;
                    a.SiteWeb = txtSiteWeb.Text;
                    a.IdCourantArtistique = Convert.ToInt32(cboCourantArtiste.SelectedValue.ToString());
                    ArtisteManager.GetInstance().ModifierUnArtiste(a);
                    MessageBox.Show("Artiste Modifier", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour du Vip : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
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
                try
                {

                    Artiste a = (Artiste)cboArtiste.SelectedItem;
                    a.Nom = txtNom.Text;
                    a.SiteWeb = txtSiteWeb.Text;
                    a.IdCourantArtistique = Convert.ToInt32(cboCourantArtiste.SelectedValue.ToString());
                    ArtisteManager.GetInstance().SupprimerUnArtiste(a);
                    MessageBox.Show("Artiste Supprimer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
