namespace GsbCampagneGUI
{
    partial class FrmMenuArtiste
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
            this.btnGererArtiste = new System.Windows.Forms.Button();
            this.btnAjouterArtiste = new System.Windows.Forms.Button();
            this.btnConsulterArtiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(311, 336);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(144, 38);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Femer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnGererArtiste
            // 
            this.btnGererArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererArtiste.Location = new System.Drawing.Point(544, 145);
            this.btnGererArtiste.Name = "btnGererArtiste";
            this.btnGererArtiste.Size = new System.Drawing.Size(144, 86);
            this.btnGererArtiste.TabIndex = 6;
            this.btnGererArtiste.Text = "Modifier / Supprimer";
            this.btnGererArtiste.UseVisualStyleBackColor = true;
            this.btnGererArtiste.Click += new System.EventHandler(this.btnGererArtiste_Click);
            // 
            // btnAjouterArtiste
            // 
            this.btnAjouterArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterArtiste.Location = new System.Drawing.Point(311, 145);
            this.btnAjouterArtiste.Name = "btnAjouterArtiste";
            this.btnAjouterArtiste.Size = new System.Drawing.Size(144, 86);
            this.btnAjouterArtiste.TabIndex = 5;
            this.btnAjouterArtiste.Text = "Ajouter";
            this.btnAjouterArtiste.UseVisualStyleBackColor = true;
            this.btnAjouterArtiste.Click += new System.EventHandler(this.btnAjouterArtiste_Click);
            // 
            // btnConsulterArtiste
            // 
            this.btnConsulterArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterArtiste.Location = new System.Drawing.Point(77, 145);
            this.btnConsulterArtiste.Name = "btnConsulterArtiste";
            this.btnConsulterArtiste.Size = new System.Drawing.Size(144, 86);
            this.btnConsulterArtiste.TabIndex = 4;
            this.btnConsulterArtiste.Text = "Afficher";
            this.btnConsulterArtiste.UseVisualStyleBackColor = true;
            this.btnConsulterArtiste.Click += new System.EventHandler(this.btnConsulterArtiste_Click);
            // 
            // FrmGestionsArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnGererArtiste);
            this.Controls.Add(this.btnAjouterArtiste);
            this.Controls.Add(this.btnConsulterArtiste);
            this.Name = "FrmGestionsArtiste";
            this.Text = "Menu artistes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnGererArtiste;
        private System.Windows.Forms.Button btnAjouterArtiste;
        private System.Windows.Forms.Button btnConsulterArtiste;
    }
}