namespace GsbCampagneGUI
{
    partial class FrmMenuEvenements
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnGererEvenement = new System.Windows.Forms.Button();
            this.btnAfficherEvenements = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(222, 232);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 37);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(357, 116);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 69);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter un événement";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnGererEvenement
            // 
            this.btnGererEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererEvenement.Location = new System.Drawing.Point(207, 116);
            this.btnGererEvenement.Name = "btnGererEvenement";
            this.btnGererEvenement.Size = new System.Drawing.Size(121, 69);
            this.btnGererEvenement.TabIndex = 9;
            this.btnGererEvenement.Text = "Modifier ou supprimer un événement";
            this.btnGererEvenement.UseVisualStyleBackColor = true;
            this.btnGererEvenement.Click += new System.EventHandler(this.btnGererEvenement_Click);
            // 
            // btnAfficherEvenements
            // 
            this.btnAfficherEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherEvenements.Location = new System.Drawing.Point(56, 116);
            this.btnAfficherEvenements.Name = "btnAfficherEvenements";
            this.btnAfficherEvenements.Size = new System.Drawing.Size(121, 69);
            this.btnAfficherEvenements.TabIndex = 11;
            this.btnAfficherEvenements.Text = "Afficher les évènements";
            this.btnAfficherEvenements.UseVisualStyleBackColor = true;
            this.btnAfficherEvenements.Click += new System.EventHandler(this.btnAfficherEvenements_Click);
            // 
            // FrmMenuEvenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 341);
            this.Controls.Add(this.btnAfficherEvenements);
            this.Controls.Add(this.btnGererEvenement);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnFermer);
            this.Name = "FrmMenuEvenements";
            this.Text = "Gestion des événements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnGererEvenement;
        private System.Windows.Forms.Button btnAfficherEvenements;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}