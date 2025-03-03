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
    public partial class FrmConsulterVip : Form
    {
        public FrmConsulterVip()
        {
            InitializeComponent();

            List<VIP> list = VipManager.GetInstance().GetLesVips();
            dgvVip.DataSource = VipManager.GetInstance().GetLesVips();

            // Masquer les éléments non souhaités
            dgvVip.Columns["Id"].Visible = false;
            dgvVip.Columns["IdCategorieVip"].Visible = false;
            dgvVip.Columns["CodeInseeVille"].Visible = false;
            dgvVip.Columns["Ville"].Visible = false;
            dgvVip.Columns["CategorieVip"].Visible = false;
            // Modifier l’entête de certaines colonnes
            dgvVip.Columns["LibelleCategorieVip"].HeaderText = "Catégorie Vip";
            dgvVip.Columns["NomVille"].HeaderText = "Ville";
            // Gérer la largeur des colonnes : elles s’adaptent à leur contenu
            // sauf la colonne Nom qui occupera la place restante
            dgvVip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVip.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Améliorer le rendu du datagridview (peut être fait en mode Design)
            dgvVip.RowHeadersVisible = false; // Entêtes de ligne masquées
            dgvVip.BackgroundColor = Color.White; // Couleur de fond
        }
    }
}
