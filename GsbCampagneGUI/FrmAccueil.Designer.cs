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
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnEvenements = new System.Windows.Forms.Button();
            this.btnCampagne = new System.Windows.Forms.Button();
            this.btnAgences = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVIP
            // 
            this.btnVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIP.Location = new System.Drawing.Point(64, 246);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(137, 76);
            this.btnVIP.TabIndex = 0;
            this.btnVIP.Text = "Gestion des VIP";
            this.btnVIP.UseVisualStyleBackColor = true;
            // 
            // btnEvenements
            // 
            this.btnEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenements.Location = new System.Drawing.Point(64, 129);
            this.btnEvenements.Name = "btnEvenements";
            this.btnEvenements.Size = new System.Drawing.Size(137, 76);
            this.btnEvenements.TabIndex = 0;
            this.btnEvenements.Text = "Gestion des évènements";
            this.btnEvenements.UseVisualStyleBackColor = true;
            this.btnEvenements.Click += new System.EventHandler(this.btnEvenements_Click);
            // 
            // btnCampagne
            // 
            this.btnCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampagne.Location = new System.Drawing.Point(251, 129);
            this.btnCampagne.Name = "btnCampagne";
            this.btnCampagne.Size = new System.Drawing.Size(137, 76);
            this.btnCampagne.TabIndex = 0;
            this.btnCampagne.Text = "Gestion des campagnes";
            this.btnCampagne.UseVisualStyleBackColor = true;
            // 
            // btnAgences
            // 
            this.btnAgences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgences.Location = new System.Drawing.Point(251, 246);
            this.btnAgences.Name = "btnAgences";
            this.btnAgences.Size = new System.Drawing.Size(137, 76);
            this.btnAgences.TabIndex = 0;
            this.btnAgences.Text = "Gestion des agences";
            this.btnAgences.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnVIP);
            this.Controls.Add(this.btnAgences);
            this.Controls.Add(this.btnCampagne);
            this.Controls.Add(this.btnEvenements);
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnEvenements;
        private System.Windows.Forms.Button btnCampagne;
        private System.Windows.Forms.Button btnAgences;
        private System.Windows.Forms.Button btnQuitter;
    }
}