namespace GsbCampagneGUI
{
    partial class FrmAfficherCampagnes
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
            this.dgvAfficheCampagne = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficheCampagne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfficheCampagne
            // 
            this.dgvAfficheCampagne.AllowUserToAddRows = false;
            this.dgvAfficheCampagne.AllowUserToDeleteRows = false;
            this.dgvAfficheCampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfficheCampagne.Location = new System.Drawing.Point(0, 0);
            this.dgvAfficheCampagne.Name = "dgvAfficheCampagne";
            this.dgvAfficheCampagne.ReadOnly = true;
            this.dgvAfficheCampagne.Size = new System.Drawing.Size(800, 450);
            this.dgvAfficheCampagne.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(359, 456);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(83, 32);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmAfficherCampagnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dgvAfficheCampagne);
            this.Name = "FrmAfficherCampagnes";
            this.Text = "FrmAfficherCampagnes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficheCampagne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfficheCampagne;
        private System.Windows.Forms.Button btnFermer;
    }
}