namespace GsbCampagneGUI
{
    partial class FrmMenuVip
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
            this.btnConsulterVip = new System.Windows.Forms.Button();
            this.btnAjouterVip = new System.Windows.Forms.Button();
            this.btnGererVip = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsulterVip
            // 
            this.btnConsulterVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterVip.Location = new System.Drawing.Point(68, 146);
            this.btnConsulterVip.Name = "btnConsulterVip";
            this.btnConsulterVip.Size = new System.Drawing.Size(144, 86);
            this.btnConsulterVip.TabIndex = 0;
            this.btnConsulterVip.Text = "Afficher";
            this.btnConsulterVip.UseVisualStyleBackColor = true;
            this.btnConsulterVip.Click += new System.EventHandler(this.btnConsulterVip_Click);
            // 
            // btnAjouterVip
            // 
            this.btnAjouterVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterVip.Location = new System.Drawing.Point(302, 146);
            this.btnAjouterVip.Name = "btnAjouterVip";
            this.btnAjouterVip.Size = new System.Drawing.Size(144, 86);
            this.btnAjouterVip.TabIndex = 1;
            this.btnAjouterVip.Text = "Ajouter";
            this.btnAjouterVip.UseVisualStyleBackColor = true;
            this.btnAjouterVip.Click += new System.EventHandler(this.btnAjouterVip_Click);
            // 
            // btnGererVip
            // 
            this.btnGererVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererVip.Location = new System.Drawing.Point(535, 146);
            this.btnGererVip.Name = "btnGererVip";
            this.btnGererVip.Size = new System.Drawing.Size(144, 86);
            this.btnGererVip.TabIndex = 2;
            this.btnGererVip.Text = "Modifier / Supprimer";
            this.btnGererVip.UseVisualStyleBackColor = true;
            this.btnGererVip.Click += new System.EventHandler(this.btnGererVip_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(302, 337);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(144, 38);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Femer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmMenuVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnGererVip);
            this.Controls.Add(this.btnAjouterVip);
            this.Controls.Add(this.btnConsulterVip);
            this.Name = "FrmMenuVip";
            this.Text = "Menu VIP";
            this.Shown += new System.EventHandler(this.FrmMenuVip_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulterVip;
        private System.Windows.Forms.Button btnAjouterVip;
        private System.Windows.Forms.Button btnGererVip;
        private System.Windows.Forms.Button btnFermer;
    }
}