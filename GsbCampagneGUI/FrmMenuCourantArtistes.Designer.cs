namespace GsbCampagneGUI
{
    partial class FrmMenuCourantArtistes
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
            this.btnGererCategArtistes = new System.Windows.Forms.Button();
            this.btnAjouterCourantArtistes = new System.Windows.Forms.Button();
            this.btnConsuterCourantArtistes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(306, 338);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(144, 38);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Femer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnGererCategArtistes
            // 
            this.btnGererCategArtistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererCategArtistes.Location = new System.Drawing.Point(539, 147);
            this.btnGererCategArtistes.Name = "btnGererCategArtistes";
            this.btnGererCategArtistes.Size = new System.Drawing.Size(144, 86);
            this.btnGererCategArtistes.TabIndex = 10;
            this.btnGererCategArtistes.Text = "Supprimer";
            this.btnGererCategArtistes.UseVisualStyleBackColor = true;
            this.btnGererCategArtistes.Click += new System.EventHandler(this.btnGererCategArtistes_Click);
            // 
            // btnAjouterCourantArtistes
            // 
            this.btnAjouterCourantArtistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCourantArtistes.Location = new System.Drawing.Point(306, 147);
            this.btnAjouterCourantArtistes.Name = "btnAjouterCourantArtistes";
            this.btnAjouterCourantArtistes.Size = new System.Drawing.Size(144, 86);
            this.btnAjouterCourantArtistes.TabIndex = 9;
            this.btnAjouterCourantArtistes.Text = "Ajouter";
            this.btnAjouterCourantArtistes.UseVisualStyleBackColor = true;
            this.btnAjouterCourantArtistes.Click += new System.EventHandler(this.btnAjouterCourantArtistes_Click);
            // 
            // btnConsuterCourantArtistes
            // 
            this.btnConsuterCourantArtistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsuterCourantArtistes.Location = new System.Drawing.Point(72, 147);
            this.btnConsuterCourantArtistes.Name = "btnConsuterCourantArtistes";
            this.btnConsuterCourantArtistes.Size = new System.Drawing.Size(144, 86);
            this.btnConsuterCourantArtistes.TabIndex = 8;
            this.btnConsuterCourantArtistes.Text = "Afficher";
            this.btnConsuterCourantArtistes.UseVisualStyleBackColor = true;
            this.btnConsuterCourantArtistes.Click += new System.EventHandler(this.btnConsuterCategArtistes_Click);
            // 
            // FrmGestionsCourantArtistes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnGererCategArtistes);
            this.Controls.Add(this.btnAjouterCourantArtistes);
            this.Controls.Add(this.btnConsuterCourantArtistes);
            this.Name = "FrmGestionsCourantArtistes";
            this.Text = "Gestions des categories artistes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnGererCategArtistes;
        private System.Windows.Forms.Button btnAjouterCourantArtistes;
        private System.Windows.Forms.Button btnConsuterCourantArtistes;
    }
}