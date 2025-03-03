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
    public partial class FrmAjouterCategorieVIP : Form
    {
        public FrmAjouterCategorieVIP()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
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
                categorieVIP.Libelle = txtLibelle.Text;

                CategorieVIPManager.GetInstance().AjouterCategorieVIP(categorieVIP);
                MessageBox.Show("Categorie VIP ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
