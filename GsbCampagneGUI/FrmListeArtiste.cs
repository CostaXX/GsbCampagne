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
    public partial class FrmListeArtiste : Form
    {
        public FrmListeArtiste()
        {
            InitializeComponent();


            List<Artiste> list = ArtisteManager.GetInstance().GetLesArtistes();
            dgvArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();

            // Masquer les éléments non souhaités
            dgvArtiste.Columns["Id"].Visible = false;
            dgvArtiste.Columns["IdCourantArtistique"].Visible = false;
            
            dgvArtiste.Columns["Participers"].Visible = false;
            dgvArtiste.Columns["CourantArtistique"].Visible = false;
            // Modifier l’entête de certaines colonnes
            dgvArtiste.Columns["LibelleCourantArtistique"].HeaderText = "Courant Artistique";
            // sauf la colonne Nom qui occupera la place restante
            dgvArtiste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvArtiste.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Améliorer le rendu du datagridview (peut être fait en mode Design)
            dgvArtiste.RowHeadersVisible = false; // Entêtes de ligne masquées
            dgvArtiste.BackgroundColor = Color.White; // Couleur de fond
        }
    }
}
