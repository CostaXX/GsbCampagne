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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionVIP
            // 
            this.btnGestionVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVIP.Location = new System.Drawing.Point(64, 166);
            this.btnGestionVIP.Name = "btnGestionVIP";
            this.btnGestionVIP.Size = new System.Drawing.Size(137, 76);
            this.btnGestionVIP.TabIndex = 0;
            this.btnGestionVIP.Text = "Gestion des VIP";
            this.btnGestionVIP.UseVisualStyleBackColor = true;
            this.btnGestionVIP.Click += new System.EventHandler(this.btnGestionVIP_Click);
            // 
            // btnGestionEvenements
            // 
            this.btnGestionEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEvenements.Location = new System.Drawing.Point(64, 51);
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
            this.btnGestionCampagnes.Location = new System.Drawing.Point(261, 51);
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
            this.btnGestionAgences.Location = new System.Drawing.Point(261, 166);
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
            this.btnQuitter.Location = new System.Drawing.Point(179, 359);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(137, 76);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion des Artistes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gestion des Courants Artistique";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}