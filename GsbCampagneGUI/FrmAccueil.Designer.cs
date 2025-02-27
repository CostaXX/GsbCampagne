namespace GsbCampagneGUI
{
    partial class FrmAccueil
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
            this.btnGestionVIP = new System.Windows.Forms.Button();
            this.btnGestionEvenements = new System.Windows.Forms.Button();
            this.btnGestionCampagnes = new System.Windows.Forms.Button();
            this.btnGestionAgences = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionVIP
            // 
            this.btnGestionVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVIP.Location = new System.Drawing.Point(64, 246);
            this.btnGestionVIP.Name = "btnGestionVIP";
            this.btnGestionVIP.Size = new System.Drawing.Size(137, 76);
            this.btnGestionVIP.TabIndex = 0;
            this.btnGestionVIP.Text = "Gestion des VIP";
            this.btnGestionVIP.UseVisualStyleBackColor = true;
            // 
            // btnGestionEvenements
            // 
            this.btnGestionEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEvenements.Location = new System.Drawing.Point(64, 129);
            this.btnGestionEvenements.Name = "btnGestionEvenements";
            this.btnGestionEvenements.Size = new System.Drawing.Size(137, 76);
            this.btnGestionEvenements.TabIndex = 0;
            this.btnGestionEvenements.Text = "Gestion des évènements";
            this.btnGestionEvenements.UseVisualStyleBackColor = true;
            this.btnGestionEvenements.Click += new System.EventHandler(this.btnEvenements_Click);
            // 
            // btnGestionCampagnes
            // 
            this.btnGestionCampagnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCampagnes.Location = new System.Drawing.Point(251, 129);
            this.btnGestionCampagnes.Name = "btnGestionCampagnes";
            this.btnGestionCampagnes.Size = new System.Drawing.Size(137, 76);
            this.btnGestionCampagnes.TabIndex = 0;
            this.btnGestionCampagnes.Text = "Gestion des campagnes";
            this.btnGestionCampagnes.UseVisualStyleBackColor = true;
            this.btnGestionCampagnes.Click += new System.EventHandler(this.btnGestionCampagnes_Click);
            // 
            // btnGestionAgences
            // 
            this.btnGestionAgences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAgences.Location = new System.Drawing.Point(251, 246);
            this.btnGestionAgences.Name = "btnGestionAgences";
            this.btnGestionAgences.Size = new System.Drawing.Size(137, 76);
            this.btnGestionAgences.TabIndex = 0;
            this.btnGestionAgences.Text = "Gestion des agences";
            this.btnGestionAgences.UseVisualStyleBackColor = true;
            this.btnGestionAgences.Click += new System.EventHandler(this.btnGestionAgences_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(160, 344);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(137, 76);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 460);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnGestionVIP);
            this.Controls.Add(this.btnGestionAgences);
            this.Controls.Add(this.btnGestionCampagnes);
            this.Controls.Add(this.btnGestionEvenements);
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.Shown += new System.EventHandler(this.FrmAccueil_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGestionVIP;
        private System.Windows.Forms.Button btnGestionEvenements;
        private System.Windows.Forms.Button btnGestionCampagnes;
        private System.Windows.Forms.Button btnGestionAgences;
        private System.Windows.Forms.Button btnQuitter;
    }
}