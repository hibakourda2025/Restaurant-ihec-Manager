namespace Restaurant_IHEC
{
    partial class Voir_compte_etudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voir_compte_etudiant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changer_mdp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpInscription = new System.Windows.Forms.DateTimePicker();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtCIN = new System.Windows.Forms.MaskedTextBox();
            this.txtFiliere = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumEtudiant = new System.Windows.Forms.MaskedTextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 96);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mon Compte";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(63, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changer_mdp);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpInscription);
            this.panel2.Controls.Add(this.dtpNaissance);
            this.panel2.Controls.Add(this.txtCIN);
            this.panel2.Controls.Add(this.txtFiliere);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNumEtudiant);
            this.panel2.Controls.Add(this.btnEnregistrer);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 622);
            this.panel2.TabIndex = 0;
            // 
            // changer_mdp
            // 
            this.changer_mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changer_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changer_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changer_mdp.ForeColor = System.Drawing.Color.White;
            this.changer_mdp.Location = new System.Drawing.Point(135, 490);
            this.changer_mdp.Name = "changer_mdp";
            this.changer_mdp.Size = new System.Drawing.Size(346, 37);
            this.changer_mdp.TabIndex = 9;
            this.changer_mdp.Text = "Changer le mot de passe";
            this.changer_mdp.UseVisualStyleBackColor = false;
            this.changer_mdp.Click += new System.EventHandler(this.changer_mdp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(162, 266);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(319, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Mot de passe";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(162, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(75, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "Cin";
            // 
            // dtpInscription
            // 
            this.dtpInscription.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpInscription.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpInscription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpInscription.Enabled = false;
            this.dtpInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInscription.Location = new System.Drawing.Point(354, 409);
            this.dtpInscription.Name = "dtpInscription";
            this.dtpInscription.Size = new System.Drawing.Size(237, 30);
            this.dtpInscription.TabIndex = 8;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpNaissance.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpNaissance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpNaissance.Enabled = false;
            this.dtpNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaissance.Location = new System.Drawing.Point(41, 409);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(237, 30);
            this.dtpNaissance.TabIndex = 7;
            // 
            // txtCIN
            // 
            this.txtCIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCIN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCIN.Enabled = false;
            this.txtCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIN.Location = new System.Drawing.Point(162, 121);
            this.txtCIN.Mask = "99999999";
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(319, 30);
            this.txtCIN.TabIndex = 2;
            // 
            // txtFiliere
            // 
            this.txtFiliere.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFiliere.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiliere.FormattingEnabled = true;
            this.txtFiliere.Items.AddRange(new object[] {
            "1BI",
            "1LSG",
            "2BI",
            "2LSG",
            "2Comptabilité",
            "3BI",
            "3Finance",
            "3Marketing",
            "3Managment",
            "3Comptabilité",
            "M1 Big Data",
            "M1 Analyste Fiancier",
            "M1 Comptabilité",
            "M1 Marketing",
            "M1 Managment",
            "M1 Entrepreunariat",
            "M2 Big Data",
            "M2 Analyste Fiancier",
            "M2 Comptabilité",
            "M2 Marketing",
            "M2 Managment",
            "M2 Entrepreunariat"});
            this.txtFiliere.Location = new System.Drawing.Point(162, 319);
            this.txtFiliere.Name = "txtFiliere";
            this.txtFiliere.Size = new System.Drawing.Size(319, 33);
            this.txtFiliere.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(349, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 68;
            this.label10.Text = "Date d\'Inscription";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(58, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(80, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Filiére";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(36, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Date de Naissance";
            // 
            // txtNumEtudiant
            // 
            this.txtNumEtudiant.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumEtudiant.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEtudiant.Location = new System.Drawing.Point(162, 167);
            this.txtNumEtudiant.Mask = "99999999";
            this.txtNumEtudiant.Name = "txtNumEtudiant";
            this.txtNumEtudiant.Size = new System.Drawing.Size(319, 30);
            this.txtNumEtudiant.TabIndex = 3;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(135, 548);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(346, 37);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(38, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Téléphone";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(162, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(319, 30);
            this.txtNom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(49, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(162, 69);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(319, 30);
            this.txtPrenom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Prenom";
            // 
            // Voir_compte_etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Voir_compte_etudiant";
            this.Size = new System.Drawing.Size(624, 718);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumEtudiant;
        private System.Windows.Forms.DateTimePicker dtpInscription;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.MaskedTextBox txtCIN;
        private System.Windows.Forms.ComboBox txtFiliere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changer_mdp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
    }
}
