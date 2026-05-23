namespace Restaurant_IHEC
{
    partial class info_users
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info_users));
            this.comboBoxOccupation = new System.Windows.Forms.ComboBox();
            this.comboBoxFiliere = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployèes = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrenomPersonnel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomPersonnel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEtudiant = new System.Windows.Forms.TabPage();
            this.dgvEtudiant = new System.Windows.Forms.DataGridView();
            this.labelFiliere = new System.Windows.Forms.Label();
            this.textnomEtudiant = new System.Windows.Forms.TextBox();
            this.txtprenomEtudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployèes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabPageEtudiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOccupation
            // 
            this.comboBoxOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOccupation.FormattingEnabled = true;
            this.comboBoxOccupation.Items.AddRange(new object[] {
            "Tous",
            "chef",
            "sous-chef",
            "serveur"});
            this.comboBoxOccupation.Location = new System.Drawing.Point(944, 125);
            this.comboBoxOccupation.Name = "comboBoxOccupation";
            this.comboBoxOccupation.Size = new System.Drawing.Size(184, 28);
            this.comboBoxOccupation.TabIndex = 2;
            this.comboBoxOccupation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOccupation_SelectedIndexChanged);
            // 
            // comboBoxFiliere
            // 
            this.comboBoxFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiliere.FormattingEnabled = true;
            this.comboBoxFiliere.Items.AddRange(new object[] {
            "Tous",
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
            this.comboBoxFiliere.Location = new System.Drawing.Point(909, 127);
            this.comboBoxFiliere.Name = "comboBoxFiliere";
            this.comboBoxFiliere.Size = new System.Drawing.Size(239, 28);
            this.comboBoxFiliere.TabIndex = 55;
            this.comboBoxFiliere.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiliere_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployèes);
            this.tabControl1.Controls.Add(this.tabPageEtudiant);
            this.tabControl1.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmployèes
            // 
            this.tabPageEmployèes.BackColor = System.Drawing.Color.Transparent;
            this.tabPageEmployèes.Controls.Add(this.dgvEmployees);
            this.tabPageEmployèes.Controls.Add(this.comboBoxOccupation);
            this.tabPageEmployèes.Controls.Add(this.label9);
            this.tabPageEmployèes.Controls.Add(this.txtPrenomPersonnel);
            this.tabPageEmployèes.Controls.Add(this.label4);
            this.tabPageEmployèes.Controls.Add(this.txtNomPersonnel);
            this.tabPageEmployèes.Controls.Add(this.label3);
            this.tabPageEmployèes.Controls.Add(this.label1);
            this.tabPageEmployèes.ForeColor = System.Drawing.Color.Black;
            this.tabPageEmployèes.Location = new System.Drawing.Point(4, 27);
            this.tabPageEmployèes.Name = "tabPageEmployèes";
            this.tabPageEmployèes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployèes.Size = new System.Drawing.Size(1196, 468);
            this.tabPageEmployèes.TabIndex = 0;
            this.tabPageEmployèes.Text = "Employèes";
            this.tabPageEmployèes.Enter += new System.EventHandler(this.tabPageEmployèes_Enter);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(30, 188);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1114, 254);
            this.dgvEmployees.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(769, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Occupation:";
            // 
            // txtPrenomPersonnel
            // 
            this.txtPrenomPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomPersonnel.Location = new System.Drawing.Point(133, 125);
            this.txtPrenomPersonnel.Name = "txtPrenomPersonnel";
            this.txtPrenomPersonnel.Size = new System.Drawing.Size(239, 26);
            this.txtPrenomPersonnel.TabIndex = 0;
            this.txtPrenomPersonnel.TextChanged += new System.EventHandler(this.txtPrenomPersonnel_TextChanged);
            this.txtPrenomPersonnel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenomPersonnel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "PRENOM:";
            // 
            // txtNomPersonnel
            // 
            this.txtNomPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPersonnel.Location = new System.Drawing.Point(483, 125);
            this.txtNomPersonnel.Name = "txtNomPersonnel";
            this.txtNomPersonnel.Size = new System.Drawing.Size(239, 26);
            this.txtNomPersonnel.TabIndex = 1;
            this.txtNomPersonnel.TextChanged += new System.EventHandler(this.txtNomPersonnel_TextChanged);
            this.txtNomPersonnel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPersonnel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(405, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "NOM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "Information Employé";
            // 
            // tabPageEtudiant
            // 
            this.tabPageEtudiant.Controls.Add(this.dgvEtudiant);
            this.tabPageEtudiant.Controls.Add(this.comboBoxFiliere);
            this.tabPageEtudiant.Controls.Add(this.labelFiliere);
            this.tabPageEtudiant.Controls.Add(this.textnomEtudiant);
            this.tabPageEtudiant.Controls.Add(this.txtprenomEtudiant);
            this.tabPageEtudiant.Controls.Add(this.label2);
            this.tabPageEtudiant.Controls.Add(this.label5);
            this.tabPageEtudiant.Controls.Add(this.label10);
            this.tabPageEtudiant.Location = new System.Drawing.Point(4, 27);
            this.tabPageEtudiant.Name = "tabPageEtudiant";
            this.tabPageEtudiant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEtudiant.Size = new System.Drawing.Size(1196, 468);
            this.tabPageEtudiant.TabIndex = 1;
            this.tabPageEtudiant.Text = "Etudiants";
            this.tabPageEtudiant.UseVisualStyleBackColor = true;
            this.tabPageEtudiant.Enter += new System.EventHandler(this.tabPageEtudiant_Enter);
            // 
            // dgvEtudiant
            // 
            this.dgvEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiant.Location = new System.Drawing.Point(47, 173);
            this.dgvEtudiant.Name = "dgvEtudiant";
            this.dgvEtudiant.RowHeadersWidth = 51;
            this.dgvEtudiant.RowTemplate.Height = 24;
            this.dgvEtudiant.Size = new System.Drawing.Size(1101, 258);
            this.dgvEtudiant.TabIndex = 56;
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiliere.ForeColor = System.Drawing.Color.Sienna;
            this.labelFiliere.Location = new System.Drawing.Point(789, 127);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(114, 23);
            this.labelFiliere.TabIndex = 54;
            this.labelFiliere.Text = "FILIERE:";
            // 
            // textnomEtudiant
            // 
            this.textnomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomEtudiant.Location = new System.Drawing.Point(528, 122);
            this.textnomEtudiant.Name = "textnomEtudiant";
            this.textnomEtudiant.Size = new System.Drawing.Size(239, 26);
            this.textnomEtudiant.TabIndex = 53;
            this.textnomEtudiant.TextChanged += new System.EventHandler(this.textnomEtudiant_TextChanged);
            this.textnomEtudiant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnomEtudiant_KeyPress);
            // 
            // txtprenomEtudiant
            // 
            this.txtprenomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprenomEtudiant.Location = new System.Drawing.Point(176, 118);
            this.txtprenomEtudiant.Name = "txtprenomEtudiant";
            this.txtprenomEtudiant.Size = new System.Drawing.Size(239, 26);
            this.txtprenomEtudiant.TabIndex = 52;
            this.txtprenomEtudiant.TextChanged += new System.EventHandler(this.txtprenomEtudiant_TextChanged);
            this.txtprenomEtudiant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprenomEtudiant_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "PRENOM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(448, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "NOM:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(346, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 45);
            this.label10.TabIndex = 49;
            this.label10.Text = "Information Etudiant";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(1095, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 83);
            this.btnSave.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnSave, "Enregistrer les changement");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.ForeColor = System.Drawing.Color.Red;
            this.btnQueue.Location = new System.Drawing.Point(422, 507);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(114, 27);
            this.btnQueue.TabIndex = 8;
            this.btnQueue.Text = ">>";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(197, 507);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 27);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.ForeColor = System.Drawing.Color.Red;
            this.btnSuivant.Location = new System.Drawing.Point(309, 507);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(107, 27);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnTop
            // 
            this.btnTop.ForeColor = System.Drawing.Color.Red;
            this.btnTop.Location = new System.Drawing.Point(75, 507);
            this.btnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(116, 27);
            this.btnTop.TabIndex = 5;
            this.btnTop.Text = "<<";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // info_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.tabControl1);
            this.Name = "info_users";
            this.Size = new System.Drawing.Size(1207, 615);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployèes.ResumeLayout(false);
            this.tabPageEmployèes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabPageEtudiant.ResumeLayout(false);
            this.tabPageEtudiant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployèes;
        private System.Windows.Forms.TabPage tabPageEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomPersonnel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenomPersonnel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textnomEtudiant;
        private System.Windows.Forms.TextBox txtprenomEtudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.DataGridView dgvEtudiant;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.ComboBox comboBoxOccupation;
        private System.Windows.Forms.ComboBox comboBoxFiliere;
    }
}
