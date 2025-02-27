namespace GsbCampagneGUI
{
    partial class FrmGererAgences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboAgence = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlModification = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.cboVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSiteWeb = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlModification.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAgence
            // 
            this.cboAgence.FormattingEnabled = true;
            this.cboAgence.Location = new System.Drawing.Point(260, 45);
            this.cboAgence.Name = "cboAgence";
            this.cboAgence.Size = new System.Drawing.Size(364, 21);
            this.cboAgence.TabIndex = 0;
            this.cboAgence.SelectionChangeCommitted += new System.EventHandler(this.cboAgence_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agence";
            // 
            // pnlModification
            // 
            this.pnlModification.Controls.Add(this.btnSupprimer);
            this.pnlModification.Controls.Add(this.cboType);
            this.pnlModification.Controls.Add(this.btnModifier);
            this.pnlModification.Controls.Add(this.txtNom);
            this.pnlModification.Controls.Add(this.txtAdresse);
            this.pnlModification.Controls.Add(this.txtTelephone);
            this.pnlModification.Controls.Add(this.txtEmail);
            this.pnlModification.Controls.Add(this.txtSiteWeb);
            this.pnlModification.Controls.Add(this.cboVille);
            this.pnlModification.Controls.Add(this.lblVille);
            this.pnlModification.Controls.Add(this.lblType);
            this.pnlModification.Controls.Add(this.lblSiteWeb);
            this.pnlModification.Controls.Add(this.lblEmail);
            this.pnlModification.Controls.Add(this.lblTelephone);
            this.pnlModification.Controls.Add(this.lblAdresse);
            this.pnlModification.Controls.Add(this.lblNom);
            this.pnlModification.Location = new System.Drawing.Point(223, 97);
            this.pnlModification.Name = "pnlModification";
            this.pnlModification.Size = new System.Drawing.Size(403, 401);
            this.pnlModification.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(232, 305);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 44);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(87, 208);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(243, 21);
            this.cboType.TabIndex = 11;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(49, 305);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 44);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(87, 17);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(243, 20);
            this.txtNom.TabIndex = 10;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(87, 52);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(243, 20);
            this.txtAdresse.TabIndex = 10;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(87, 91);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(243, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(87, 167);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(243, 20);
            this.txtSiteWeb.TabIndex = 10;
            // 
            // cboVille
            // 
            this.cboVille.FormattingEnabled = true;
            this.cboVille.Location = new System.Drawing.Point(87, 250);
            this.cboVille.Name = "cboVille";
            this.cboVille.Size = new System.Drawing.Size(243, 21);
            this.cboVille.TabIndex = 9;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(17, 253);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 211);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblSiteWeb
            // 
            this.lblSiteWeb.AutoSize = true;
            this.lblSiteWeb.Location = new System.Drawing.Point(17, 170);
            this.lblSiteWeb.Name = "lblSiteWeb";
            this.lblSiteWeb.Size = new System.Drawing.Size(48, 13);
            this.lblSiteWeb.TabIndex = 5;
            this.lblSiteWeb.Text = "Site web";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(17, 94);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(17, 55);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(17, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // FrmGererAgences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 532);
            this.Controls.Add(this.pnlModification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAgence);
            this.Name = "FrmGererAgences";
            this.Text = "Modification et suppression des agences";
            this.pnlModification.ResumeLayout(false);
            this.pnlModification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAgence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlModification;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSiteWeb;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cboVille;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSupprimer;
    }
}