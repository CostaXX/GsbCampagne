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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAfficherAgences = new System.Windows.Forms.Button();
            this.btnAjouterAgence = new System.Windows.Forms.Button();
            this.btnModifierSupprimerAgence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAfficherAgences
            // 
            this.btnAfficherAgences.Location = new System.Drawing.Point(107, 169);
            this.btnAfficherAgences.Name = "btnAfficherAgences";
            this.btnAfficherAgences.Size = new System.Drawing.Size(122, 65);
            this.btnAfficherAgences.TabIndex = 1;
            this.btnAfficherAgences.Text = "Afficher les agences";
            this.btnAfficherAgences.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAgence
            // 
            this.btnAjouterAgence.Location = new System.Drawing.Point(322, 169);
            this.btnAjouterAgence.Name = "btnAjouterAgence";
            this.btnAjouterAgence.Size = new System.Drawing.Size(122, 65);
            this.btnAjouterAgence.TabIndex = 1;
            this.btnAjouterAgence.Text = "Ajouter une agence";
            this.btnAjouterAgence.UseVisualStyleBackColor = true;
            this.btnAjouterAgence.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModifierSupprimerAgence
            // 
            this.btnModifierSupprimerAgence.Location = new System.Drawing.Point(534, 169);
            this.btnModifierSupprimerAgence.Name = "btnModifierSupprimerAgence";
            this.btnModifierSupprimerAgence.Size = new System.Drawing.Size(122, 65);
            this.btnModifierSupprimerAgence.TabIndex = 1;
            this.btnModifierSupprimerAgence.Text = "Modifier / Supprimer une agence";
            this.btnModifierSupprimerAgence.UseVisualStyleBackColor = true;
            this.btnModifierSupprimerAgence.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGestionAgences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnModifierSupprimerAgence);
            this.Controls.Add(this.btnAjouterAgence);
            this.Controls.Add(this.btnAfficherAgences);
            this.Controls.Add(this.button1);
            this.Name = "FrmGestionAgences";
            this.Text = "FrmGestionAgences";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAfficherAgences;
        private System.Windows.Forms.Button btnAjouterAgence;
        private System.Windows.Forms.Button btnModifierSupprimerAgence;
    }
}