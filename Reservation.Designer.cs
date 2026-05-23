namespace Restaurant_IHEC
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatereservation = new System.Windows.Forms.DateTimePicker();
            this.btnReserver = new System.Windows.Forms.Button();
            this.rbMenu2 = new System.Windows.Forms.RadioButton();
            this.rbMenu1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(70)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(139, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Réservez votre repas du jour";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpDatereservation);
            this.panel2.Controls.Add(this.btnReserver);
            this.panel2.Controls.Add(this.rbMenu2);
            this.panel2.Controls.Add(this.rbMenu1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 364);
            this.panel2.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(127, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Date de Résevation:";
            // 
            // dtpDatereservation
            // 
            this.dtpDatereservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatereservation.Location = new System.Drawing.Point(431, 82);
            this.dtpDatereservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatereservation.Name = "dtpDatereservation";
            this.dtpDatereservation.Size = new System.Drawing.Size(200, 22);
            this.dtpDatereservation.TabIndex = 0;
            // 
            // btnReserver
            // 
            this.btnReserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(70)))), ((int)(((byte)(53)))));
            this.btnReserver.FlatAppearance.BorderSize = 0;
            this.btnReserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserver.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserver.ForeColor = System.Drawing.Color.White;
            this.btnReserver.Location = new System.Drawing.Point(284, 205);
            this.btnReserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(149, 58);
            this.btnReserver.TabIndex = 55;
            this.btnReserver.Text = "Réserver";
            this.btnReserver.UseVisualStyleBackColor = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // rbMenu2
            // 
            this.rbMenu2.AutoSize = true;
            this.rbMenu2.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenu2.Location = new System.Drawing.Point(377, 129);
            this.rbMenu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMenu2.Name = "rbMenu2";
            this.rbMenu2.Size = new System.Drawing.Size(79, 21);
            this.rbMenu2.TabIndex = 54;
            this.rbMenu2.TabStop = true;
            this.rbMenu2.Text = "Menu2";
            this.rbMenu2.UseVisualStyleBackColor = true;
            // 
            // rbMenu1
            // 
            this.rbMenu1.AutoSize = true;
            this.rbMenu1.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenu1.Location = new System.Drawing.Point(275, 129);
            this.rbMenu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMenu1.Name = "rbMenu1";
            this.rbMenu1.Size = new System.Drawing.Size(79, 21);
            this.rbMenu1.TabIndex = 53;
            this.rbMenu1.TabStop = true;
            this.rbMenu1.Text = "Menu1";
            this.rbMenu1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(127, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Menu:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(737, 459);
            this.Load += new System.EventHandler(this.Reservation_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMenu2;
        private System.Windows.Forms.RadioButton rbMenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatereservation;
    }
}
