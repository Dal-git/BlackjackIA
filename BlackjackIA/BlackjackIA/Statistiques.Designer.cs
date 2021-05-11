namespace BlackjackIA
{
    partial class Statistiques
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
            this.pnl_statistiques = new System.Windows.Forms.Panel();
            this.lbl_Probabilites = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_statistiques
            // 
            this.pnl_statistiques.AutoScroll = true;
            this.pnl_statistiques.BackColor = System.Drawing.Color.Transparent;
            this.pnl_statistiques.Location = new System.Drawing.Point(19, 51);
            this.pnl_statistiques.Name = "pnl_statistiques";
            this.pnl_statistiques.Size = new System.Drawing.Size(200, 234);
            this.pnl_statistiques.TabIndex = 33;
            // 
            // lbl_Probabilites
            // 
            this.lbl_Probabilites.AutoSize = true;
            this.lbl_Probabilites.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Probabilites.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Probabilites.Location = new System.Drawing.Point(22, 51);
            this.lbl_Probabilites.Name = "lbl_Probabilites";
            this.lbl_Probabilites.Size = new System.Drawing.Size(0, 31);
            this.lbl_Probabilites.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 39);
            this.label10.TabIndex = 34;
            this.label10.Text = "Statistiques détaillées:";
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(376, 610);
            this.Controls.Add(this.lbl_Probabilites);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnl_statistiques);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_statistiques;
        private System.Windows.Forms.Label lbl_Probabilites;
        private System.Windows.Forms.Label label10;
    }
}