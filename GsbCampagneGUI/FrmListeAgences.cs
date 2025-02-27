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
    public partial class FrmListeAgences : Form
    {
        public FrmListeAgences()
        {
            InitializeComponent();
            dgvAgences.DataSource = AgenceManager.GetInstance().GetLesAgences();
            dgvAgences.Columns["NomVille"].HeaderText = "Ville";
            dgvAgences.Columns["Id"].Visible = false;
            dgvAgences.Columns["CodeInseeVille"].Visible = false;
            dgvAgences.Columns["Campagnes"].Visible = false;
            dgvAgences.Columns["Campagnes1"].Visible = false;
            dgvAgences.Columns["Ville"].Visible = false;
            dgvAgences.RowHeadersVisible = false;
            dgvAgences.BorderStyle = BorderStyle.None;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
