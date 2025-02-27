namespace GsbCampagneGUI
{
    partial class FrmAjouterCourantArtiste
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
            this.txtCourantArtiste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCourantArtiste
            // 
            this.txtCourantArtiste.Location = new System.Drawing.Point(346, 168);
            this.txtCourantArtiste.Name = "txtCourantArtiste";
            this.txtCourantArtiste.Size = new System.Drawing.Size(185, 20);
            this.txtCourantArtiste.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CourantArtistique";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(431, 229);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(129, 40);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(206, 229);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 40);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmAjouterCourantArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCourantArtiste);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjouterCourantArtiste";
            this.Text = "Ajouter un artiste courant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourantArtiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
    }
}