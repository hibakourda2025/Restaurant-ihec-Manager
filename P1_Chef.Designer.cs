namespace Restaurant_IHEC
{
    partial class P1_Chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1_Chef));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoirAvis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGeerermenus = new System.Windows.Forms.Button();
            this.labelChef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 42);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bienvenue Chef";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(1470, 9);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.btnVoirAvis);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnGeerermenus);
            this.panel2.Controls.Add(this.labelChef);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 671);
            this.panel2.TabIndex = 1;
            // 
            // btnVoirAvis
            // 
            this.btnVoirAvis.BackColor = System.Drawing.Color.Silver;
            this.btnVoirAvis.FlatAppearance.BorderSize = 0;
            this.btnVoirAvis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirAvis.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirAvis.ForeColor = System.Drawing.Color.Black;
            this.btnVoirAvis.Location = new System.Drawing.Point(52, 420);
            this.btnVoirAvis.Name = "btnVoirAvis";
            this.btnVoirAvis.Size = new System.Drawing.Size(150, 58);
            this.btnVoirAvis.TabIndex = 15;
            this.btnVoirAvis.Text = "Voir Avis Etudiants";
            this.btnVoirAvis.UseVisualStyleBackColor = false;
            this.btnVoirAvis.Click += new System.EventHandler(this.btnVoirAvis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(52, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Mon compte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(52, 557);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 63);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Se déconnecter";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnGeerermenus
            // 
            this.btnGeerermenus.BackColor = System.Drawing.Color.Silver;
            this.btnGeerermenus.FlatAppearance.BorderSize = 0;
            this.btnGeerermenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeerermenus.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeerermenus.ForeColor = System.Drawing.Color.Black;
            this.btnGeerermenus.Location = new System.Drawing.Point(52, 325);
            this.btnGeerermenus.Name = "btnGeerermenus";
            this.btnGeerermenus.Size = new System.Drawing.Size(150, 58);
            this.btnGeerermenus.TabIndex = 11;
            this.btnGeerermenus.Text = "Gérer les Menus";
            this.btnGeerermenus.UseVisualStyleBackColor = false;
            this.btnGeerermenus.Click += new System.EventHandler(this.btnGeerermenus_Click);
            // 
            // labelChef
            // 
            this.labelChef.AutoSize = true;
            this.labelChef.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelChef.Location = new System.Drawing.Point(127, 148);
            this.labelChef.Name = "labelChef";
            this.labelChef.Size = new System.Drawing.Size(75, 21);
            this.labelChef.TabIndex = 10;
            this.labelChef.Text = "chef name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chef";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.pictureBox2);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(274, 42);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1231, 671);
            this.panelmain.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurant_IHEC.Properties.Resources.ihec_carthage_hero_DldPL_Jo;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1221, 661);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // P1_Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 713);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P1_Chef";
            this.Text = "P1_Chef";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGeerermenus;
        private System.Windows.Forms.Label labelChef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoirAvis;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}