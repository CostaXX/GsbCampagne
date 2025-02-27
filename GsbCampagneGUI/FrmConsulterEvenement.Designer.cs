namespace GsbCampagneGUI
{
    partial class FrmConsulterEvenement
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
            this.dgvEvenement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvenement
            // 
            this.dgvEvenement.AllowUserToAddRows = false;
            this.dgvEvenement.AllowUserToDeleteRows = false;
            this.dgvEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvenement.Location = new System.Drawing.Point(0, 0);
            this.dgvEvenement.Name = "dgvEvenement";
            this.dgvEvenement.ReadOnly = true;
            this.dgvEvenement.Size = new System.Drawing.Size(800, 450);
            this.dgvEvenement.TabIndex = 0;
            // 
            // FrmConsulterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEvenement);
            this.Name = "FrmConsulterEvenement";
            this.Text = "Liste des événements";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvenement;
    }
}