namespace GsbCampagneGUI
{
    partial class FrmListeArtiste
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
            this.dgvArtiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtiste.Location = new System.Drawing.Point(0, 0);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(800, 450);
            this.dgvArtiste.TabIndex = 0;
            // 
            // FrmListeArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArtiste);
            this.Name = "FrmListeArtiste";
            this.Text = "Consultation des Artistes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtiste;
    }
}