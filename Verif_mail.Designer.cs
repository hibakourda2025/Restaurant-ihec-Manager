namespace Restaurant_IHEC
{
    partial class Verif_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verif_mail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklabel_renvoyer = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValide = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirmation d’identité";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(765, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 142);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linklabel_renvoyer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnValide);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 258);
            this.panel2.TabIndex = 2;
            // 
            // linklabel_renvoyer
            // 
            this.linklabel_renvoyer.AutoSize = true;
            this.linklabel_renvoyer.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_renvoyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.linklabel_renvoyer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.linklabel_renvoyer.Location = new System.Drawing.Point(403, 154);
            this.linklabel_renvoyer.Name = "linklabel_renvoyer";
            this.linklabel_renvoyer.Size = new System.Drawing.Size(228, 17);
            this.linklabel_renvoyer.TabIndex = 76;
            this.linklabel_renvoyer.TabStop = true;
            this.linklabel_renvoyer.Text = "appuyez pour renvoyer.";
            this.linklabel_renvoyer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_renvoyer_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(108, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "vous n’avez pas reçu un code? ";
            // 
            // btnValide
            // 
            this.btnValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.btnValide.FlatAppearance.BorderSize = 0;
            this.btnValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValide.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValide.ForeColor = System.Drawing.Color.White;
            this.btnValide.Location = new System.Drawing.Point(344, 74);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(163, 49);
            this.btnValide.TabIndex = 73;
            this.btnValide.Text = "Vérifier";
            this.btnValide.UseVisualStyleBackColor = false;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(449, 23);
            this.txtCode.Mask = "99999";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(254, 30);
            this.txtCode.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(141, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "Code de vérification";
            // 
            // Verif_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verif_mail";
            this.Text = "E2formMailVerif";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklabel_renvoyer;
    }
}