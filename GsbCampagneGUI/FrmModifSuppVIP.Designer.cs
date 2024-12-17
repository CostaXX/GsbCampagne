namespace GsbCampagneGUI
{
    partial class FrmModifSuppVIP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVip = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.cboVille = new System.Windows.Forms.ComboBox();
            this.cboCategVip = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Catégorie vip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nom";
            // 
            // cboVip
            // 
            this.cboVip.FormattingEnabled = true;
            this.cboVip.Location = new System.Drawing.Point(267, 44);
            this.cboVip.Name = "cboVip";
            this.cboVip.Size = new System.Drawing.Size(224, 21);
            this.cboVip.TabIndex = 10;
            this.cboVip.SelectionChangeCommitted += new System.EventHandler(this.cboVip_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.cboVille);
            this.panel.Controls.Add(this.cboCategVip);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtAdresse);
            this.panel.Controls.Add(this.txtNom);
            this.panel.Controls.Add(this.btnSuppr);
            this.panel.Controls.Add(this.btnModif);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(138, 93);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(489, 296);
            this.panel.TabIndex = 11;
            this.panel.Visible = false;
            // 
            // cboVille
            // 
            this.cboVille.FormattingEnabled = true;
            this.cboVille.Location = new System.Drawing.Point(132, 169);
            this.cboVille.Name = "cboVille";
            this.cboVille.Size = new System.Drawing.Size(224, 21);
            this.cboVille.TabIndex = 15;
            // 
            // cboCategVip
            // 
            this.cboCategVip.FormattingEnabled = true;
            this.cboCategVip.Location = new System.Drawing.Point(132, 134);
            this.cboCategVip.Name = "cboCategVip";
            this.cboCategVip.Size = new System.Drawing.Size(224, 21);
            this.cboCategVip.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(132, 53);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(224, 20);
            this.txtAdresse.TabIndex = 13;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 10);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(224, 20);
            this.txtNom.TabIndex = 12;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.Location = new System.Drawing.Point(287, 227);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(129, 56);
            this.btnSuppr.TabIndex = 11;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(48, 227);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(129, 56);
            this.btnModif.TabIndex = 10;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(301, 395);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(129, 56);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmModifSuppVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 471);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cboVip);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifSuppVIP";
            this.Text = "Modifier / supprimer un vip";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVip;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ComboBox cboVille;
        private System.Windows.Forms.ComboBox cboCategVip;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
    }
}