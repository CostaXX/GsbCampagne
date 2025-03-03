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
    public partial class FrmMenuArtiste : Form
    {
        public FrmMenuArtiste()
        {
            InitializeComponent();
        }

        private void btnConsulterArtiste_Click(object sender, EventArgs e)
        {
            FrmListeArtiste form = new FrmListeArtiste();
            form.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterArtiste_Click(object sender, EventArgs e)
        {
            FrmAjoutArtiste form = new FrmAjoutArtiste();
            form.ShowDialog();
        }

        private void btnGererArtiste_Click(object sender, EventArgs e)
        {
            FrmModifSuppArtiste form = new FrmModifSuppArtiste();
            form.ShowDialog();
        }
    }
}
