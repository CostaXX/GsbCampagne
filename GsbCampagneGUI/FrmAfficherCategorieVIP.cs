using GsbCampagneBLL;
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
    public partial class FrmAfficherCategorieVIP : Form
    {
        public FrmAfficherCategorieVIP()
        {
            InitializeComponent();
            dgvCategorieVIP.DataSource = CategorieVIPManager.GetInstance().GetLesCategoriesVIP();
            dgvCategorieVIP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategorieVIP.RowHeadersVisible = false;
            dgvCategorieVIP.BackgroundColor = Color.White;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
