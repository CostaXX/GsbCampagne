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
    public partial class FrmListeCourantArtistes : Form
    {
        public FrmListeCourantArtistes()
        {
            
            InitializeComponent();

            List<CourantArtistique> list = CourantArtistiqueManager.GetInstance().GetLesCourantArtistiques();
            dgvCourantArtistes.DataSource = CourantArtistiqueManager.GetInstance().GetLesCourantArtistiques();


            // Masquer les éléments non souhaités
            dgvCourantArtistes.Columns["Id"].Visible = false;
            dgvCourantArtistes.Columns["Artistes"].Visible = false;
            // Gérer la largeur des colonnes : elles s’adaptent à leur contenu
            // sauf la colonne Nom qui occupera la place restante
            dgvCourantArtistes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCourantArtistes.Columns["Libelle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Améliorer le rendu du datagridview (peut être fait en mode Design)
            dgvCourantArtistes.RowHeadersVisible = false; // Entêtes de ligne masquées
            dgvCourantArtistes.BackgroundColor = Color.White; // Couleur de fond

        }
    }
}
