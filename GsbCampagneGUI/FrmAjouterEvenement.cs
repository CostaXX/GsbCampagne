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
    public partial class FrmAjouterEvenement : Form
    {
        public FrmAjouterEvenement()
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
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string erreurs = "";
            if (dateTimeDebut.Value > dateTimeFin.Value)
            {
                erreurs += "La date du début ne peut être supérieur à la date de fin";
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (String.IsNullOrWhiteSpace(txtIntitule.Text) ||cboCampagnes.SelectedIndex == -1 || cboThemes.SelectedIndex == -1 || cboVilles.SelectedIndex == -1 || cboCategories.SelectedIndex == -1)
            {
                erreurs += "Toutes les informations sont obligatoires";
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            { //dateDebut, dateFin, intitule, Themes, IdCategorieVIP, Campagnes, Villes
                // Enregistrement du produit dans la BDD
                string intitule = txtIntitule.Text;
                int Campagnes = Convert.ToInt32(cboCampagnes.SelectedValue.ToString());
                int Themes = Convert.ToInt32(cboThemes.SelectedValue.ToString());
                string Villes = cboVilles.SelectedValue.ToString(); 
                int IdCategorieVIP = Convert.ToInt32(cboCategories.SelectedValue.ToString());
                DateTime dateDebut = Convert.ToDateTime(dateTimeDebut.Value);
                DateTime dateFin = Convert.ToDateTime(dateTimeFin.Value);
                if (EvenementManager.GetInstance().AjouterEvenements(dateDebut, dateFin, intitule, Themes, Villes, IdCategorieVIP, Campagnes) == 0)
                {
                    MessageBox.Show("Evénement ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problème durant l'insertion, contacter le service informatique", "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
