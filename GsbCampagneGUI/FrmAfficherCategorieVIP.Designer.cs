namespace GsbCampagneGUI
{
    partial class FrmAfficherCategorieVIP
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
            this.dgvCategorieVIP = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorieVIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorieVIP
            // 
            this.dgvCategorieVIP.AllowUserToAddRows = false;
            this.dgvCategorieVIP.AllowUserToDeleteRows = false;
            this.dgvCategorieVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorieVIP.Location = new System.Drawing.Point(1, 0);
            this.dgvCategorieVIP.Name = "dgvCategorieVIP";
            this.dgvCategorieVIP.ReadOnly = true;
            this.dgvCategorieVIP.Size = new System.Drawing.Size(439, 350);
            this.dgvCategorieVIP.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(186, 356);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmAfficherCategorieVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 383);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dgvCategorieVIP);
            this.Name = "FrmAfficherCategorieVIP";
            this.Text = "Afficher les categories de VIP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorieVIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorieVIP;
        private System.Windows.Forms.Button btnFermer;
    }
}