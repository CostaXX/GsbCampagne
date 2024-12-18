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
    public partial class FrmGererCampagnes : Form
    {
        public FrmGererCampagnes()
        {
            InitializeComponent();

            cboCampagne.DataSource = CampagneManager.GetInstance().GetLesCampagnes();
            cboCampagne.DisplayMember = "Intitule";
            cboCampagne.ValueMember = "Id";
            cboCampagne.SelectedIndex = -1;

            cboSalarie.DataSource = SalarieManager.GetInstance().GetLesSalaries();
            cboSalarie.DisplayMember = "Nom";
            cboSalarie.ValueMember = "Id";
            cboSalarie.SelectedIndex = -1;

            cboTypePublic.DataSource = TypePublicManager.GetInstance().GetLesTypesPublic();
            cboTypePublic.DisplayMember = "Libelle";
            cboTypePublic.ValueMember = "Id";
            cboTypePublic.SelectedIndex = -1;

            cboAgenceCommunication.DataSource = AgenceManager.GetInstance().GetLesAgencesCommunication();
            cboAgenceCommunication.DisplayMember = "Libelle";
            cboAgenceCommunication.ValueMember = "Id";
            cboAgenceCommunication.SelectedIndex = -1;

            cboAgenceEvenementiel.DataSource = AgenceManager.GetInstance().GetLesAgencesEvenementiel();
            cboAgenceEvenementiel.DisplayMember = "Libelle";
            cboAgenceEvenementiel.ValueMember = "Id";
            cboAgenceEvenementiel.SelectedIndex = -1;

            panel1.Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtIntitule.Text) == true)
            {
                erreurs += "L'intitule de la campagne doit être renseigné\n";
                txtIntitule.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtObjectif.Text) == true)
            {
                erreurs += "L'objectif de la campagne doit être renseigné\n";
                txtObjectif.Focus();
            }
            if (cboSalarie.SelectedIndex == -1)
            {
                erreurs += "Le salarié doit être renseignée\n";
            }
            if (cboTypePublic.SelectedIndex == -1)
            {
                erreurs += "Le type de public doit être renseignée\n";
            }
            if (dtpDateDebut.Value > dtpDateFin.Value)
            {
                erreurs += "La date de debut ne peut pas être supèrieur à la date de fin\n";
            }
            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idCampagne = Convert.ToInt32(cboCampagne.SelectedValue.ToString()) ;
                string intitule = txtIntitule.Text;
                string objectif = txtObjectif.Text;
                DateTime dateDebut = Convert.ToDateTime(dtpDateDebut.Value);
                DateTime dateFin = Convert.ToDateTime(dtpDateFin.Value);
                int idSalarie = Convert.ToInt32(cboSalarie.SelectedValue.ToString());
                int idTypePublic = Convert.ToInt32(cboTypePublic.SelectedValue.ToString());
                int? idAgenceCommunication = null;
                int? idAgenceEvenementiel = null;

                if (cboAgenceCommunication.SelectedIndex != -1)
                {
                    idAgenceCommunication = Convert.ToInt32(cboAgenceCommunication.SelectedValue.ToString());
                }

                if (cboAgenceEvenementiel.SelectedIndex != -1)
                {
                    idAgenceEvenementiel = Convert.ToInt32(cboAgenceEvenementiel.SelectedValue.ToString());
                }

                Campagne campagne = new Campagne();
                campagne.Id = idCampagne;
                campagne.Intitule = intitule;
                campagne.Objectif = objectif;
                campagne.DateDebut = dateDebut;
                campagne.DateFin = dateFin;
                campagne.IdSalarie = idSalarie;
                campagne.IdTypePublic = idSalarie;
                campagne.IdAgenceCommunication = idAgenceCommunication;
                campagne.IdAgenceEvenementiel = idAgenceEvenementiel;

                CampagneManager.GetInstance().ModifierCampagne(campagne);
                MessageBox.Show("Campagne modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cboCampagne.SelectedIndex = -1;
            panel1.Visible = false;
                
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtIntitule.Text) == true)
            {
                erreurs += "L'intitule de la campagne doit être renseigné\n";
                txtIntitule.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtObjectif.Text) == true)
            {
                erreurs += "L'objectif de la campagne doit être renseigné\n";
                txtObjectif.Focus();
            }
            if (cboSalarie.SelectedIndex == -1)
            {
                erreurs += "Le salarié doit être renseignée\n";
            }
            if (cboTypePublic.SelectedIndex == -1)
            {
                erreurs += "Le type de public doit être renseignée\n";
            }
            if (dtpDateDebut.Value > dtpDateFin.Value)
            {
                erreurs += "La date de debut ne peut pas être supèrieur à la date de fin\n";
            }
            #endregion
            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idCampagne = Convert.ToInt32(cboCampagne.SelectedValue.ToString());
                Campagne campagne = new Campagne();
                campagne.Id = idCampagne;
                CampagneDAO.GetInstance().SupprimerCampagne(campagne);
                MessageBox.Show("Campagne supprimé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cboCampagne.SelectedIndex = -1;
            panel1.Visible = false;

        }

        private void cboCampagne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCampagne.SelectedIndex != -1)
            {
                Campagne laCampagne = (Campagne)cboCampagne.SelectedItem;
                txtIntitule.Text = laCampagne.Intitule;
                txtObjectif.Text = laCampagne.Objectif;
                dtpDateDebut.Value = Convert.ToDateTime(laCampagne.DateDebut);
                dtpDateFin.Value = Convert.ToDateTime(laCampagne.DateFin);
                cboSalarie.SelectedValue = laCampagne.IdSalarie;
                cboTypePublic.SelectedValue = laCampagne.IdTypePublic;
                if (laCampagne.IdAgenceCommunication == null)
                {
                    cboAgenceCommunication.SelectedIndex = -1;
                }
                else
                {
                    cboAgenceCommunication.SelectedValue = laCampagne.IdAgenceCommunication;
                }

                if (laCampagne.IdAgenceEvenementiel == null)
                {
                    cboAgenceEvenementiel.SelectedIndex = -1;
                }
                else
                {
                    cboAgenceEvenementiel.SelectedValue = laCampagne.IdAgenceEvenementiel;
                }
                panel1.Visible = true;

            }
        }
    }
}
