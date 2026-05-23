namespace Restaurant_IHEC
{
    partial class Historique_resevation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique_resevation));
            this.dgvHistorique = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorique
            // 
            this.dgvHistorique.AllowUserToAddRows = false;
            this.dgvHistorique.AllowUserToDeleteRows = false;
            this.dgvHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorique.Location = new System.Drawing.Point(14, 124);
            this.dgvHistorique.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistorique.Name = "dgvHistorique";
            this.dgvHistorique.ReadOnly = true;
            this.dgvHistorique.RowHeadersWidth = 51;
            this.dgvHistorique.Size = new System.Drawing.Size(743, 293);
            this.dgvHistorique.TabIndex = 0;
            this.dgvHistorique.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHistorique_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Historique Réservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(144, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 97);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Historique_resevation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorique);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historique_resevation";
            this.Size = new System.Drawing.Size(779, 495);
            this.Load += new System.EventHandler(this.Historique_resevation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorique;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
