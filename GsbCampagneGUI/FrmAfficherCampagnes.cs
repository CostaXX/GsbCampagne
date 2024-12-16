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
using GsbCampagneDAL;

namespace GsbCampagneGUI
{
    public partial class FrmAfficherCampagnes : Form
    {
        public FrmAfficherCampagnes()
        {
            InitializeComponent();
            dgvAfficheCampagne.DataSource = CampagneManager.GetInstance().GetLesCampagnes();

            dgvAfficheCampagne.Columns["IdTypePublic"].Visible = false;
            dgvAfficheCampagne.Columns["IdAgenceCommunication"].Visible = false;
            dgvAfficheCampagne.Columns["IdAgenceEvenementiel"].Visible = false;
            dgvAfficheCampagne.Columns["Agence"].Visible = false;
            dgvAfficheCampagne.Columns["Agence1"].Visible = false;
            dgvAfficheCampagne.Columns["TypePublic"].Visible = false;
            dgvAfficheCampagne.Columns["Salarie"].Visible = false;
            dgvAfficheCampagne.Columns["IdSalarie"].Visible = false;

            dgvAfficheCampagne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAfficheCampagne.RowHeadersVisible = false;
            dgvAfficheCampagne.BackgroundColor = Color.White;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
