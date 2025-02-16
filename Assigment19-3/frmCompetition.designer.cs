namespace Assignment19_3
{
    partial class frmCompetition
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
            this.lblCompetition = new System.Windows.Forms.Label();
            this.dgvComprtition = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprtition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetition.Location = new System.Drawing.Point(284, 65);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(201, 38);
            this.lblCompetition.TabIndex = 15;
            this.lblCompetition.Text = "Competition";
            // 
            // dgvComprtition
            // 
            this.dgvComprtition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprtition.Location = new System.Drawing.Point(125, 125);
            this.dgvComprtition.Name = "dgvComprtition";
            this.dgvComprtition.RowHeadersWidth = 51;
            this.dgvComprtition.RowTemplate.Height = 24;
            this.dgvComprtition.Size = new System.Drawing.Size(562, 251);
            this.dgvComprtition.TabIndex = 24;
            // 
            // frmCompetition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.dgvComprtition);
            this.Controls.Add(this.lblCompetition);
            this.Name = "frmCompetition";
            this.Text = "frmCompetition2";
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprtition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.DataGridView dgvComprtition;
    }
}