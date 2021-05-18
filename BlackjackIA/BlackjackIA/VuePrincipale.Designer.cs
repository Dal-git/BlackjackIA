
namespace BlackjackIA
{
    partial class VuePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VuePrincipale));
            this.lbl_NomDuJoueur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalCroupier = new System.Windows.Forms.Label();
            this.lbl_TotalJoueur = new System.Windows.Forms.Label();
            this.gbx_Croupier = new System.Windows.Forms.GroupBox();
            this.gbx_Joueur = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_stats = new System.Windows.Forms.Panel();
            this.lbl_Probabilites = new System.Windows.Forms.Label();
            this.btn_Piocher = new System.Windows.Forms.Button();
            this.btn_Rester = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_etatPartie = new System.Windows.Forms.Label();
            this.lbl_CartesJouees = new System.Windows.Forms.Label();
            this.lbl_CartesRestantes = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_statsDetails = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_statsDetails = new System.Windows.Forms.Panel();
            this.pnl_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_statsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomDuJoueur
            // 
            this.lbl_NomDuJoueur.AutoSize = true;
            this.lbl_NomDuJoueur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomDuJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomDuJoueur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_NomDuJoueur.Location = new System.Drawing.Point(774, 993);
            this.lbl_NomDuJoueur.Name = "lbl_NomDuJoueur";
            this.lbl_NomDuJoueur.Size = new System.Drawing.Size(241, 39);
            this.lbl_NomDuJoueur.TabIndex = 5;
            this.lbl_NomDuJoueur.Text = "NomDuJoueur";
            this.lbl_NomDuJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(830, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Croupier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(830, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(830, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total :";
            // 
            // lbl_TotalCroupier
            // 
            this.lbl_TotalCroupier.AutoSize = true;
            this.lbl_TotalCroupier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalCroupier.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCroupier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalCroupier.Location = new System.Drawing.Point(932, 381);
            this.lbl_TotalCroupier.Name = "lbl_TotalCroupier";
            this.lbl_TotalCroupier.Size = new System.Drawing.Size(55, 39);
            this.lbl_TotalCroupier.TabIndex = 9;
            this.lbl_TotalCroupier.Text = "00";
            // 
            // lbl_TotalJoueur
            // 
            this.lbl_TotalJoueur.AutoSize = true;
            this.lbl_TotalJoueur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalJoueur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalJoueur.Location = new System.Drawing.Point(932, 615);
            this.lbl_TotalJoueur.Name = "lbl_TotalJoueur";
            this.lbl_TotalJoueur.Size = new System.Drawing.Size(55, 39);
            this.lbl_TotalJoueur.TabIndex = 10;
            this.lbl_TotalJoueur.Text = "00";
            // 
            // gbx_Croupier
            // 
            this.gbx_Croupier.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Croupier.Location = new System.Drawing.Point(234, 44);
            this.gbx_Croupier.Name = "gbx_Croupier";
            this.gbx_Croupier.Size = new System.Drawing.Size(1297, 334);
            this.gbx_Croupier.TabIndex = 11;
            this.gbx_Croupier.TabStop = false;
            // 
            // gbx_Joueur
            // 
            this.gbx_Joueur.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Joueur.ForeColor = System.Drawing.Color.Transparent;
            this.gbx_Joueur.Location = new System.Drawing.Point(234, 656);
            this.gbx_Joueur.Name = "gbx_Joueur";
            this.gbx_Joueur.Size = new System.Drawing.Size(1297, 334);
            this.gbx_Joueur.TabIndex = 21;
            this.gbx_Joueur.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(240, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 39);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cartes jouées:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(240, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 39);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cartes restantes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(1537, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(373, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "Valeurs probables <21:";
            // 
            // pnl_stats
            // 
            this.pnl_stats.AutoScroll = true;
            this.pnl_stats.BackColor = System.Drawing.Color.Transparent;
            this.pnl_stats.Controls.Add(this.lbl_Probabilites);
            this.pnl_stats.Location = new System.Drawing.Point(1656, 96);
            this.pnl_stats.Name = "pnl_stats";
            this.pnl_stats.Size = new System.Drawing.Size(165, 282);
            this.pnl_stats.TabIndex = 32;
            // 
            // lbl_Probabilites
            // 
            this.lbl_Probabilites.AutoSize = true;
            this.lbl_Probabilites.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Probabilites.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Probabilites.Location = new System.Drawing.Point(3, 0);
            this.lbl_Probabilites.Name = "lbl_Probabilites";
            this.lbl_Probabilites.Size = new System.Drawing.Size(86, 31);
            this.lbl_Probabilites.TabIndex = 33;
            this.lbl_Probabilites.Text = "Proba";
            // 
            // btn_Piocher
            // 
            this.btn_Piocher.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Piocher.Location = new System.Drawing.Point(734, 488);
            this.btn_Piocher.Name = "btn_Piocher";
            this.btn_Piocher.Size = new System.Drawing.Size(178, 65);
            this.btn_Piocher.TabIndex = 33;
            this.btn_Piocher.Text = "Piocher";
            this.btn_Piocher.UseVisualStyleBackColor = true;
            this.btn_Piocher.Click += new System.EventHandler(this.btn_Piocher_Click);
            // 
            // btn_Rester
            // 
            this.btn_Rester.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rester.Location = new System.Drawing.Point(918, 488);
            this.btn_Rester.Name = "btn_Rester";
            this.btn_Rester.Size = new System.Drawing.Size(178, 65);
            this.btn_Rester.TabIndex = 34;
            this.btn_Rester.Text = "Rester";
            this.btn_Rester.UseVisualStyleBackColor = true;
            this.btn_Rester.Click += new System.EventHandler(this.btn_Rester_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(678, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(478, 39);
            this.label12.TabIndex = 35;
            this.label12.Text = "Tips :       conseillé       a éviter";
            // 
            // lbl_etatPartie
            // 
            this.lbl_etatPartie.AutoSize = true;
            this.lbl_etatPartie.BackColor = System.Drawing.Color.Transparent;
            this.lbl_etatPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etatPartie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_etatPartie.Location = new System.Drawing.Point(808, 420);
            this.lbl_etatPartie.Name = "lbl_etatPartie";
            this.lbl_etatPartie.Size = new System.Drawing.Size(240, 26);
            this.lbl_etatPartie.TabIndex = 36;
            this.lbl_etatPartie.Text = "Que voulez vous faire ?";
            this.lbl_etatPartie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CartesJouees
            // 
            this.lbl_CartesJouees.AutoSize = true;
            this.lbl_CartesJouees.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartesJouees.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartesJouees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CartesJouees.Location = new System.Drawing.Point(523, 465);
            this.lbl_CartesJouees.Name = "lbl_CartesJouees";
            this.lbl_CartesJouees.Size = new System.Drawing.Size(55, 39);
            this.lbl_CartesJouees.TabIndex = 39;
            this.lbl_CartesJouees.Text = "00";
            // 
            // lbl_CartesRestantes
            // 
            this.lbl_CartesRestantes.AutoSize = true;
            this.lbl_CartesRestantes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartesRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartesRestantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CartesRestantes.Location = new System.Drawing.Point(523, 504);
            this.lbl_CartesRestantes.Name = "lbl_CartesRestantes";
            this.lbl_CartesRestantes.Size = new System.Drawing.Size(55, 39);
            this.lbl_CartesRestantes.TabIndex = 40;
            this.lbl_CartesRestantes.Text = "00";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Red;
            this.pictureBox15.Location = new System.Drawing.Point(977, 556);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(48, 45);
            this.pictureBox15.TabIndex = 38;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Lime;
            this.pictureBox8.Location = new System.Drawing.Point(781, 556);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 45);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackjackIA.Properties.Resources.dos;
            this.pictureBox1.Location = new System.Drawing.Point(19, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(716, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "Que voulez vous faire ?";
            // 
            // lbl_statsDetails
            // 
            this.lbl_statsDetails.AutoSize = true;
            this.lbl_statsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statsDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_statsDetails.Location = new System.Drawing.Point(3, 0);
            this.lbl_statsDetails.Name = "lbl_statsDetails";
            this.lbl_statsDetails.Size = new System.Drawing.Size(93, 31);
            this.lbl_statsDetails.TabIndex = 43;
            this.lbl_statsDetails.Text = "details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1542, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 39);
            this.label6.TabIndex = 45;
            this.label6.Text = "Statistiques détaillées:";
            // 
            // pnl_statsDetails
            // 
            this.pnl_statsDetails.AutoScroll = true;
            this.pnl_statsDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnl_statsDetails.Controls.Add(this.lbl_statsDetails);
            this.pnl_statsDetails.Location = new System.Drawing.Point(1624, 675);
            this.pnl_statsDetails.Name = "pnl_statsDetails";
            this.pnl_statsDetails.Size = new System.Drawing.Size(223, 315);
            this.pnl_statsDetails.TabIndex = 44;
            // 
            // VuePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1918, 1041);
            this.Controls.Add(this.pnl_statsDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_CartesRestantes);
            this.Controls.Add(this.lbl_CartesJouees);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lbl_etatPartie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Rester);
            this.Controls.Add(this.btn_Piocher);
            this.Controls.Add(this.pnl_stats);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbx_Joueur);
            this.Controls.Add(this.gbx_Croupier);
            this.Controls.Add(this.lbl_TotalJoueur);
            this.Controls.Add(this.lbl_TotalCroupier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NomDuJoueur);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VuePrincipale";
            this.Text = "BlackjackIA";
            this.Load += new System.EventHandler(this.VuePrincipale_Load);
            this.pnl_stats.ResumeLayout(false);
            this.pnl_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_statsDetails.ResumeLayout(false);
            this.pnl_statsDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_NomDuJoueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TotalCroupier;
        private System.Windows.Forms.Label lbl_TotalJoueur;
        private System.Windows.Forms.GroupBox gbx_Croupier;
        private System.Windows.Forms.GroupBox gbx_Joueur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_stats;
        private System.Windows.Forms.Label lbl_Probabilites;
        private System.Windows.Forms.Button btn_Piocher;
        private System.Windows.Forms.Button btn_Rester;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_etatPartie;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label lbl_CartesJouees;
        private System.Windows.Forms.Label lbl_CartesRestantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_statsDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_statsDetails;
    }
}

