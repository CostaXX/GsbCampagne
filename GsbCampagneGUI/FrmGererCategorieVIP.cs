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
    public partial class FrmGererCategorieVIP : Form
    {
        public FrmGererCategorieVIP()
        {
            InitializeComponent();
            cboCategorieVIP.DataSource = CategorieVIPManager.GetInstance().GetLesCategoriesVIP();
            cboCategorieVIP.DisplayMember = "Libelle";
            cboCategorieVIP.ValueMember = "Id";
            cboCategorieVIP.SelectedIndex = -1;

            panel1.Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            #region Contrôle de saisie
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) == true)
            {
                erreurs += "Le libelle de la categorie VIP doit être renseigné\n";
                txtLibelle.Focus();
            }

            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategorieVIP categorieVIP = new CategorieVIP();
                categorieVIP.Id = Convert.ToInt32(cboCategorieVIP.SelectedValue.ToString());
                categorieVIP.Libelle = txtLibelle.Text;

                CategorieVIPManager.GetInstance().ModifierCategorieVIP(categorieVIP);
                MessageBox.Show("Categorie VIP modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cboCategorieVIP.SelectedIndex = -1;
            panel1.Visible = false;

        

    }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            #region Contrôle de saisie
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) == true)
            {
                erreurs += "Le libelle de la categorie VIP doit être renseigné\n";
                txtLibelle.Focus();
            }

            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategorieVIP categorieVIP = new CategorieVIP();
                categorieVIP.Id = Convert.ToInt32(cboCategorieVIP.SelectedValue.ToString());

                CategorieVIPManager.GetInstance().SupprimerCategorieVIP(categorieVIP);
                MessageBox.Show("Categorie VIP supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cboCategorieVIP.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void cboCampagne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCategorieVIP.SelectedIndex != -1)
            {
                CategorieVIP laCategorieVIP = (CategorieVIP)cboCategorieVIP.SelectedItem;
                txtLibelle.Text = laCategorieVIP.Libelle;
                panel1.Visible = true;

            }
        }
    }
}
