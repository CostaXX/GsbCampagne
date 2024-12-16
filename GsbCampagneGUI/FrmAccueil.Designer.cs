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
            this.btnEvenements = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvenements
            // 
            this.btnEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenements.Location = new System.Drawing.Point(64, 129);
            this.btnEvenements.Name = "btnEvenements";
            this.btnEvenements.Size = new System.Drawing.Size(137, 76);
            this.btnEvenements.TabIndex = 0;
            this.btnEvenements.Text = "Gestion des évènements";
            this.btnEvenements.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion des campagnes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 76);
            this.button2.TabIndex = 0;
            this.button2.Text = "Gestion des agences";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVip
            // 
            this.btnVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVip.Location = new System.Drawing.Point(64, 246);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(137, 76);
            this.btnVip.TabIndex = 0;
            this.btnVip.Text = "Gestion des Vip";
            this.btnVip.UseVisualStyleBackColor = true;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnVip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvenements);
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvenements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVip;
    }
}