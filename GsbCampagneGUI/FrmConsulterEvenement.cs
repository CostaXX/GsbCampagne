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
    public partial class FrmConsulterEvenement : Form
    {
        public FrmConsulterEvenement()
        {
            InitializeComponent();

            dgvEvenement.DataSource = EvenementManager.GetInstance().GetLesEvenements();

            // Masquer les éléments non souhaités
            dgvEvenement.Columns["Id"].Visible = false;
            dgvEvenement.Columns["Campagne"].Visible = false;
            dgvEvenement.Columns["CategorieVIP"].Visible = false;
            dgvEvenement.Columns["Convier"].Visible = false;
            dgvEvenement.Columns["Theme"].Visible = false;
            dgvEvenement.Columns["Ville"].Visible = false;
            dgvEvenement.Columns["Participer"].Visible = false;
            dgvEvenement.Columns["IdTheme"].Visible = false;
            dgvEvenement.Columns["CodeInseeVille"].Visible = false;
            dgvEvenement.Columns["IdCategorieVIP"].Visible = false;
            dgvEvenement.Columns["Idcampagne"].Visible = false;


            // Modifier l’entête de certaines colonnes
            dgvEvenement.Columns["LibelleTheme"].HeaderText = "Thème";
            dgvEvenement.Columns["NomVille"].HeaderText = "Ville";
            dgvEvenement.Columns["VIPCategorie"].HeaderText = "VIP";
            dgvEvenement.Columns["IntituleCampagne"].HeaderText = "Campagne";
            dgvEvenement.Columns["DateDebut"].HeaderText = "Date de début";
            dgvEvenement.Columns["DateFin"].HeaderText = "Date de la fin";

            // Changer l’alignement du contenu des cellules
            dgvEvenement.Columns["DateDebut"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEvenement.Columns["DateFin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Gérer la largeur des colonnes : elles s’adaptent à leur contenu
            // sauf la colonne Intitule qui occupera la place restante
            dgvEvenement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEvenement.Columns["Intitule"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEvenement.Columns["NomVille"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEvenement.Columns["IntituleCampagne"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            // Améliorer le rendu du datagridview (peut être fait en mode Design)
            dgvEvenement.RowHeadersVisible = false; // Entêtes de ligne masquées
            dgvEvenement.BackgroundColor = Color.White; // Couleur de fond

        }
    }
}
