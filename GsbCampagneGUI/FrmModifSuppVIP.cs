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
    public partial class FrmModifSuppVIP : Form
    {
        public FrmModifSuppVIP()
        {

            InitializeComponent();

            #region Remplir la liste des Vips
            cboCategVip.DataSource = VipManager.GetInstance().GetLesVips();
            cboCategVip.DisplayMember = "Libelle";
            cboCategVip.ValueMember = "Id";
            cboCategVip.SelectedIndex = -1;
            #endregion
            #region Remplir la liste des catégories
            cboCategVip.DataSource = CategorieVipDAO.GetInstance().GetLesCategoriesVip();
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
    }
}
