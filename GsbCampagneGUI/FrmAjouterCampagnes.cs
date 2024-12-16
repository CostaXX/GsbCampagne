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
    public partial class FrmAjouterCampagnes : Form
    {
        public FrmAjouterCampagnes()
        {
            InitializeComponent();

            cboAgenceCommunication.DataSource =
            cboSalarie.SelectedIndex = -1;

            cboAgenceCommunication.DataSource =
            cboTypePublic.SelectedIndex = -1;

            cboAgenceCommunication.DataSource =
            cboAgenceCommunication.SelectedIndex = -1;

            cboAgenceCommunication.DataSource =
            cboAgenceEvenementiel.SelectedIndex = -1;
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
