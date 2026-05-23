namespace Restaurant_IHEC
{
    partial class Annuler_reservation
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Annuler_reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodereservation = new System.Windows.Forms.TextBox();
            this.btnAnnulerReservation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 110);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(96)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(131, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Annuler Votre Réservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnAnnulerReservation);
            this.panel2.Controls.Add(this.txtCodereservation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 305);
            this.panel2.TabIndex = 1;
            // 
            // txtCodereservation
            // 
            this.txtCodereservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodereservation.Location = new System.Drawing.Point(302, 65);
            this.txtCodereservation.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodereservation.Name = "txtCodereservation";
            this.txtCodereservation.Size = new System.Drawing.Size(319, 30);
            this.txtCodereservation.TabIndex = 0;
            // 
            // btnAnnulerReservation
            // 
            this.btnAnnulerReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(96)))), ((int)(((byte)(153)))));
            this.btnAnnulerReservation.FlatAppearance.BorderSize = 0;
            this.btnAnnulerReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerReservation.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerReservation.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerReservation.Location = new System.Drawing.Point(340, 124);
            this.btnAnnulerReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulerReservation.Name = "btnAnnulerReservation";
            this.btnAnnulerReservation.Size = new System.Drawing.Size(149, 58);
            this.btnAnnulerReservation.TabIndex = 59;
            this.btnAnnulerReservation.Text = "Annuler Réservation";
            this.btnAnnulerReservation.UseVisualStyleBackColor = false;
            this.btnAnnulerReservation.Click += new System.EventHandler(this.btnAnnulerReservation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(61)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Code Réservation:";
            // 
            // Annuler_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Annuler_reservation";
            this.Size = new System.Drawing.Size(829, 415);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnulerReservation;
        private System.Windows.Forms.TextBox txtCodereservation;
    }
}
