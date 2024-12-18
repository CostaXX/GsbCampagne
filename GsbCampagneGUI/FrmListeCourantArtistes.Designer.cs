namespace GsbCampagneGUI
{
    partial class FrmListeCourantArtistes
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
            this.dgvCourantArtistes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourantArtistes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourantArtistes
            // 
            this.dgvCourantArtistes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourantArtistes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourantArtistes.Location = new System.Drawing.Point(0, 0);
            this.dgvCourantArtistes.Name = "dgvCourantArtistes";
            this.dgvCourantArtistes.Size = new System.Drawing.Size(800, 450);
            this.dgvCourantArtistes.TabIndex = 0;
            // 
            // FrmListeCourantArtistes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCourantArtistes);
            this.Name = "FrmListeCourantArtistes";
            this.Text = "Liste Courant Artistes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourantArtistes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourantArtistes;
    }
}