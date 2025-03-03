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
    public partial class FrmSupprimerCourantArtistique : Form
    {
        public FrmSupprimerCourantArtistique()
        {
            InitializeComponent();

            #region Remplir la liste des catégories
            cboCourantArtistique.DataSource = CourantArtistiqueDAO.GetInstance().GetLesCourantArtistiques();
            cboCourantArtistique.DisplayMember = "libelle";
            cboCourantArtistique.ValueMember = "Id";
            cboCourantArtistique.SelectedIndex = -1;
            #endregion
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Enregistrement du produit dans la BDD
            CourantArtistique a = (CourantArtistique)cboCourantArtistique.SelectedItem;
            CourantArtistiqueManager.GetInstance().SupprimerUneCategArtiste(a);
            MessageBox.Show("Catégorie Artistique Supprimer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
