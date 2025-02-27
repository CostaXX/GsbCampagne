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
    public partial class FrmGererEvenement : Form
    {
        public FrmGererEvenement()
        {
            InitializeComponent();
            #region Remplir la liste des catégories
            cboVilles.DataSource = VilleManager.GetInstance().GetLesVilles();
            cboVilles.DisplayMember = "Nom";
            cboVilles.ValueMember = "CodeInsee";
            cboVilles.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des campagnes
            cboCampagnes.DataSource = CampagneManager.GetInstance().GetLesCampagnes();
            cboCampagnes.DisplayMember = "Intitule";
            cboCampagnes.ValueMember = "Id";
            cboCampagnes.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des themes
            cboThemes.DataSource = ThemeManager.GetInstance().GetLesThemes();
            cboThemes.DisplayMember = "Libelle";
            cboThemes.ValueMember = "Id";
            cboThemes.SelectedIndex = -1;
            #endregion

            #region Remplir les categories
            cboCategories.DataSource = CategorieDAO.GetInstance().GetLesCategoriesVIP();
            cboCategories.DisplayMember = "Libelle";
            cboCategories.ValueMember = "Id";
            cboCategories.SelectedIndex = -1;
            #endregion

            remplirListeEvenements();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGererEvenement_Load(object sender, EventArgs e)
        {
            panel.Visible = false;
        }

        public void remplirListeEvenements()
        {
            cboEvenements.DataSource = EvenementManager.GetInstance().GetLesEvenements();
            cboEvenements.DisplayMember = "Intitule";
            cboEvenements.ValueMember = "Id";
            cboEvenements.SelectedIndex = -1;

            cboCampagnes.SelectedIndex = -1;
            cboVilles.SelectedIndex = -1;
            cboThemes.SelectedIndex = -1;
            cboCategories.SelectedIndex = -1;
            panel.Visible = false;
        }

        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEvenements.SelectedIndex != -1)
            {
                Evenement evenement = (Evenement)cboEvenements.SelectedItem;
                panel.Visible = true;
                txtIntitule.Text = evenement.Intitule;
                cboCampagnes.SelectedValue = evenement.IdCampagne;
                cboVilles.SelectedValue = evenement.CodeInseeVille;
                cboThemes.SelectedValue = evenement.IdTheme;
                cboCategories.SelectedValue = evenement.IdCategorieVIP;
                dateTimeDebut.Value = evenement.DateDebut; 
                dateTimeFin.Value = evenement.DateFin;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Evenement evenement = (Evenement)cboEvenements.SelectedItem;
            panel.Visible = true;
            if (EvenementManager.GetInstance().SupprimerEvenements(evenement.Id) == 0)
            {
                MessageBox.Show("Evénement supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel.Visible = false;
                cboEvenements.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Problème lors de la mise à jour", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            #region Contrôle des données saisies
            string erreurs = "";
            if (dateTimeDebut.Value > dateTimeFin.Value)
            {
                erreurs += "La date du début ne peut être supérieur à la date de fin";
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtIntitule.Text) || cboCampagnes.SelectedIndex == -1 || cboThemes.SelectedIndex == -1 || cboVilles.SelectedIndex == -1 || cboCategories.SelectedIndex == -1)
            {
                erreurs += "Toutes les informations sont obligatoires";
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Evenement evt = (Evenement)cboEvenements.SelectedItem;
                panel.Visible = true;
                evt.Intitule = txtIntitule.Text;
                evt.IdCampagne = Convert.ToInt32(cboCampagnes.SelectedValue.ToString());
                evt.CodeInseeVille = cboVilles.SelectedValue.ToString();
                evt.IdTheme = Convert.ToInt32(cboThemes.SelectedValue.ToString());
                evt.IdCategorieVIP = Convert.ToInt32(cboCategories.SelectedValue.ToString());
                evt.DateDebut = Convert.ToDateTime(dateTimeDebut.Value);
                evt.DateFin = Convert.ToDateTime(dateTimeFin.Value);
                if (EvenementManager.GetInstance().ModifierEvenements(evt) == 0)
                {
                    MessageBox.Show("Evénement mis à jour", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    remplirListeEvenements();
                }
                else
                {
                    MessageBox.Show("Problème lors de la mise à jour", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
