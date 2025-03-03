namespace GsbCampagneGUI
{
    partial class FrmConsulterVip
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
            this.dgvVip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVip
            // 
            this.dgvVip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVip.Location = new System.Drawing.Point(0, 0);
            this.dgvVip.Name = "dgvVip";
            this.dgvVip.Size = new System.Drawing.Size(800, 450);
            this.dgvVip.TabIndex = 0;
            // 
            // FrmConsulterVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVip);
            this.Name = "FrmConsulterVip";
            this.Text = "Consultation des vip";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVip;
    }
}