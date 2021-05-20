
namespace BlackjackIA
{
    partial class VueParametres
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
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.nud_paquet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_envoyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_paquet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nom
            // 
            this.tbx_nom.Location = new System.Drawing.Point(79, 12);
            this.tbx_nom.MaxLength = 15;
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(140, 20);
            this.tbx_nom.TabIndex = 0;
            this.tbx_nom.TextChanged += new System.EventHandler(this.tbx_nom_TextChanged);
            // 
            // nud_paquet
            // 
            this.nud_paquet.Location = new System.Drawing.Point(184, 45);
            this.nud_paquet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_paquet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_paquet.Name = "nud_paquet";
            this.nud_paquet.Size = new System.Drawing.Size(35, 20);
            this.nud_paquet.TabIndex = 1;
            this.nud_paquet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de paquet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Votre nom :";
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.Enabled = false;
            this.btn_envoyer.Location = new System.Drawing.Point(12, 68);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(75, 23);
            this.btn_envoyer.TabIndex = 4;
            this.btn_envoyer.Text = "OK";
            this.btn_envoyer.UseVisualStyleBackColor = true;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // VueParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(238, 103);
            this.Controls.Add(this.btn_envoyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_paquet);
            this.Controls.Add(this.tbx_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VueParametres";
            this.Text = "Parametres";
            this.Load += new System.EventHandler(this.VueParametres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_paquet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.NumericUpDown nud_paquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_envoyer;
    }
}