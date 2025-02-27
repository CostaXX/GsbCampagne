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
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        public Salarie Salarie;

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string erreurs = "";
            if(txtLogin.Text != null && txtMdp.Text != null)
            {
                Salarie = SalarieManager.GetInstance().GetInfosSalarie(txtLogin.Text, txtMdp.Text);
                if (Salarie == null)
                {
                    erreurs += "Vos informations de connexion sont erronées";
                    MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
