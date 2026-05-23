namespace Restaurant_IHEC
{
    partial class P1_acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1_acceuil));
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEtudiant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbackground = new System.Windows.Forms.Panel();
            this.panelinscription = new System.Windows.Forms.Panel();
            this.txtCIN = new System.Windows.Forms.MaskedTextBox();
            this.labelMdpoublié = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_connx = new System.Windows.Forms.Button();
            this.btn_creer_compte = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbackground.SuspendLayout();
            this.panelinscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1360, 26);
            this.panel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Page d\'acceuil";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1316, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnChef);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnEtudiant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 695);
            this.panel1.TabIndex = 6;
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.Silver;
            this.btnChef.FlatAppearance.BorderSize = 0;
            this.btnChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChef.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChef.ForeColor = System.Drawing.Color.Black;
            this.btnChef.Location = new System.Drawing.Point(63, 389);
            this.btnChef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(149, 57);
            this.btnChef.TabIndex = 2;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(63, 294);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(149, 57);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEtudiant
            // 
            this.btnEtudiant.BackColor = System.Drawing.Color.Silver;
            this.btnEtudiant.FlatAppearance.BorderSize = 0;
            this.btnEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtudiant.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiant.ForeColor = System.Drawing.Color.Black;
            this.btnEtudiant.Location = new System.Drawing.Point(63, 206);
            this.btnEtudiant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtudiant.Name = "btnEtudiant";
            this.btnEtudiant.Size = new System.Drawing.Size(149, 58);
            this.btnEtudiant.TabIndex = 0;
            this.btnEtudiant.Text = "Etudiant";
            this.btnEtudiant.UseVisualStyleBackColor = false;
            this.btnEtudiant.Click += new System.EventHandler(this.btnEtudiant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelbackground
            // 
            this.panelbackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelbackground.BackgroundImage")));
            this.panelbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbackground.Controls.Add(this.panelinscription);
            this.panelbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbackground.Location = new System.Drawing.Point(265, 26);
            this.panelbackground.Margin = new System.Windows.Forms.Padding(4);
            this.panelbackground.Name = "panelbackground";
            this.panelbackground.Size = new System.Drawing.Size(1095, 695);
            this.panelbackground.TabIndex = 7;
            // 
            // panelinscription
            // 
            this.panelinscription.Controls.Add(this.txtCIN);
            this.panelinscription.Controls.Add(this.labelMdpoublié);
            this.panelinscription.Controls.Add(this.label4);
            this.panelinscription.Controls.Add(this.btn_connx);
            this.panelinscription.Controls.Add(this.btn_creer_compte);
            this.panelinscription.Controls.Add(this.txtMdp);
            this.panelinscription.Controls.Add(this.label5);
            this.panelinscription.Controls.Add(this.label6);
            this.panelinscription.Controls.Add(this.label7);
            this.panelinscription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinscription.Location = new System.Drawing.Point(0, 0);
            this.panelinscription.Margin = new System.Windows.Forms.Padding(4);
            this.panelinscription.Name = "panelinscription";
            this.panelinscription.Size = new System.Drawing.Size(1095, 695);
            this.panelinscription.TabIndex = 1;
            this.panelinscription.Visible = false;
            // 
            // txtCIN
            // 
            this.txtCIN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIN.Location = new System.Drawing.Point(309, 135);
            this.txtCIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCIN.Mask = "99999999";
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(393, 32);
            this.txtCIN.TabIndex = 0;
            // 
            // labelMdpoublié
            // 
            this.labelMdpoublié.AutoSize = true;
            this.labelMdpoublié.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdpoublié.ForeColor = System.Drawing.Color.Navy;
            this.labelMdpoublié.Location = new System.Drawing.Point(405, 255);
            this.labelMdpoublié.Name = "labelMdpoublié";
            this.labelMdpoublié.Size = new System.Drawing.Size(203, 25);
            this.labelMdpoublié.TabIndex = 2;
            this.labelMdpoublié.Text = "Mot de passe oublié ?";
            this.labelMdpoublié.Click += new System.EventHandler(this.labelMdpoublié_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 80);
            this.label4.TabIndex = 83;
            this.label4.Text = "Vous n\'avez pas encore de compte?\r\nCréez-en un afin d\'accéder à l\'application.";
            // 
            // btn_connx
            // 
            this.btn_connx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_connx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connx.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connx.ForeColor = System.Drawing.Color.White;
            this.btn_connx.Location = new System.Drawing.Point(389, 309);
            this.btn_connx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connx.Name = "btn_connx";
            this.btn_connx.Size = new System.Drawing.Size(173, 54);
            this.btn_connx.TabIndex = 3;
            this.btn_connx.Text = "Se connecter";
            this.btn_connx.UseVisualStyleBackColor = false;
            this.btn_connx.Click += new System.EventHandler(this.btn_connx_Click);
            // 
            // btn_creer_compte
            // 
            this.btn_creer_compte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_creer_compte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_creer_compte.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer_compte.ForeColor = System.Drawing.Color.White;
            this.btn_creer_compte.Location = new System.Drawing.Point(700, 455);
            this.btn_creer_compte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_creer_compte.Name = "btn_creer_compte";
            this.btn_creer_compte.Size = new System.Drawing.Size(197, 54);
            this.btn_creer_compte.TabIndex = 4;
            this.btn_creer_compte.Text = "Crèer un compte";
            this.btn_creer_compte.UseVisualStyleBackColor = false;
            this.btn_creer_compte.Click += new System.EventHandler(this.btn_creer_compte_Click);
            // 
            // txtMdp
            // 
            this.txtMdp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(309, 206);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(393, 34);
            this.txtMdp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(125, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Mot de Passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(175, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "CIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(200, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 38);
            this.label7.TabIndex = 76;
            this.label7.Text = "Se connecter à votre compte";
            // 
            // P1_acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1360, 721);
            this.Controls.Add(this.panelbackground);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "P1_acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant IHEC";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbackground.ResumeLayout(false);
            this.panelinscription.ResumeLayout(false);
            this.panelinscription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelbackground;
        private System.Windows.Forms.Panel panelinscription;
        private System.Windows.Forms.Label labelMdpoublié;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_connx;
        private System.Windows.Forms.Button btn_creer_compte;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCIN;
    }
}

