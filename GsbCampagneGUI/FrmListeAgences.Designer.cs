namespace GsbCampagneGUI
{
    partial class FrmListeAgences
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
            this.dgvAgences = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgences
            // 
            this.dgvAgences.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAgences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgences.Location = new System.Drawing.Point(12, 12);
            this.dgvAgences.Name = "dgvAgences";
            this.dgvAgences.Size = new System.Drawing.Size(764, 380);
            this.dgvAgences.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(342, 427);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmListeAgences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 477);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.dgvAgences);
            this.Name = "FrmListeAgences";
            this.Text = "Liste des agences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgences;
        private System.Windows.Forms.Button btnQuitter;
    }
}