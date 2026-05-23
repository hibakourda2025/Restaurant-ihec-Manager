namespace Restaurant_IHEC
{
    partial class MiseAjourReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiseAjourReservation));
            this.maskedTextCode = new System.Windows.Forms.MaskedTextBox();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextCode
            // 
            this.maskedTextCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextCode.Location = new System.Drawing.Point(141, 120);
            this.maskedTextCode.Mask = "9999";
            this.maskedTextCode.Name = "maskedTextCode";
            this.maskedTextCode.Size = new System.Drawing.Size(302, 30);
            this.maskedTextCode.TabIndex = 0;
            this.maskedTextCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextCode_MaskInputRejected);
            this.maskedTextCode.TextChanged += new System.EventHandler(this.maskedTextCode_TextChanged);
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(39, 196);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(973, 340);
            this.dgvReservation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(300, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mise À Jour Réservation ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(35, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Code Réservation:";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(942, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 83);
            this.btnSave.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btnSave, "Enregistrer les modifications");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MiseAjourReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.maskedTextCode);
            this.Name = "MiseAjourReservation";
            this.Size = new System.Drawing.Size(1043, 566);
            this.Load += new System.EventHandler(this.MiseAjourReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextCode;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
