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
    public partial class FrmMenuCourantArtistes : Form
    {
        public FrmMenuCourantArtistes()
        {
            InitializeComponent();
        }

        private void btnConsuterCategArtistes_Click(object sender, EventArgs e)
        {
            FrmListeCourantArtistes form = new FrmListeCourantArtistes();
            form.ShowDialog();
        }

        private void btnAjouterCourantArtistes_Click(object sender, EventArgs e)
        {
            FrmAjouterCourantArtiste form = new FrmAjouterCourantArtiste();
            form.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGererCategArtistes_Click(object sender, EventArgs e)
        {
            FrmSupprimerCourantArtistique form = new FrmSupprimerCourantArtistique();
            form.ShowDialog();
        }
    }
}
