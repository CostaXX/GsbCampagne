namespace GsbCampagneGUI
{
    partial class FrmGestionAgences
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAfficherAgences = new System.Windows.Forms.Button();
            this.btnAjouterAgence = new System.Windows.Forms.Button();
            this.btnModifierSupprimerAgence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(342, 366);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAfficherAgences
            // 
            this.btnAfficherAgences.Location = new System.Drawing.Point(107, 169);
            this.btnAfficherAgences.Name = "btnAfficherAgences";
            this.btnAfficherAgences.Size = new System.Drawing.Size(122, 65);
            this.btnAfficherAgences.TabIndex = 1;
            this.btnAfficherAgences.Text = "Afficher les agences";
            this.btnAfficherAgences.UseVisualStyleBackColor = true;
            this.btnAfficherAgences.Click += new System.EventHandler(this.btnAfficherAgences_Click);
            // 
            // btnAjouterAgence
            // 
            this.btnAjouterAgence.Location = new System.Drawing.Point(322, 169);
            this.btnAjouterAgence.Name = "btnAjouterAgence";
            this.btnAjouterAgence.Size = new System.Drawing.Size(122, 65);
            this.btnAjouterAgence.TabIndex = 1;
            this.btnAjouterAgence.Text = "Ajouter une agence";
            this.btnAjouterAgence.UseVisualStyleBackColor = true;
            this.btnAjouterAgence.Click += new System.EventHandler(this.btnAjouterAgence_Click);
            // 
            // btnModifierSupprimerAgence
            // 
            this.btnModifierSupprimerAgence.Location = new System.Drawing.Point(534, 169);
            this.btnModifierSupprimerAgence.Name = "btnModifierSupprimerAgence";
            this.btnModifierSupprimerAgence.Size = new System.Drawing.Size(122, 65);
            this.btnModifierSupprimerAgence.TabIndex = 1;
            this.btnModifierSupprimerAgence.Text = "Modifier / Supprimer une agence";
            this.btnModifierSupprimerAgence.UseVisualStyleBackColor = true;
            this.btnModifierSupprimerAgence.Click += new System.EventHandler(this.btnModifierSupprimerAgence_Click);
            // 
            // FrmGestionAgences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnModifierSupprimerAgence);
            this.Controls.Add(this.btnAjouterAgence);
            this.Controls.Add(this.btnAfficherAgences);
            this.Controls.Add(this.btnQuitter);
            this.Name = "FrmGestionAgences";
            this.Text = "FrmGestionAgences";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAfficherAgences;
        private System.Windows.Forms.Button btnAjouterAgence;
        private System.Windows.Forms.Button btnModifierSupprimerAgence;
    }
}