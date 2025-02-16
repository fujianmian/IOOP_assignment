namespace Assignment19_3
{
    partial class uiSendRecomm
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
            this.dataViewRecomme = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCompetition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoach = new System.Windows.Forms.TextBox();
            this.labTraining = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecomme)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewRecomme
            // 
            this.dataViewRecomme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRecomme.Location = new System.Drawing.Point(12, 12);
            this.dataViewRecomme.Name = "dataViewRecomme";
            this.dataViewRecomme.RowHeadersWidth = 51;
            this.dataViewRecomme.RowTemplate.Height = 24;
            this.dataViewRecomme.Size = new System.Drawing.Size(667, 230);
            this.dataViewRecomme.TabIndex = 0;
            this.dataViewRecomme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewRecomme_CellContentClick);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 399);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 41);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCompetition
            // 
            this.txtCompetition.Location = new System.Drawing.Point(352, 351);
            this.txtCompetition.Name = "txtCompetition";
            this.txtCompetition.Size = new System.Drawing.Size(100, 22);
            this.txtCompetition.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Competition ID";
            // 
            // txtCoach
            // 
            this.txtCoach.Location = new System.Drawing.Point(352, 312);
            this.txtCoach.Name = "txtCoach";
            this.txtCoach.Size = new System.Drawing.Size(100, 22);
            this.txtCoach.TabIndex = 49;
            // 
            // labTraining
            // 
            this.labTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTraining.Location = new System.Drawing.Point(228, 298);
            this.labTraining.Name = "labTraining";
            this.labTraining.Size = new System.Drawing.Size(118, 36);
            this.labTraining.TabIndex = 48;
            this.labTraining.Text = "Coach ID";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(352, 262);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(100, 22);
            this.txtMember.TabIndex = 47;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(228, 262);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(118, 36);
            this.labName.TabIndex = 46;
            this.labName.Text = "Member ID";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(17, 19);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(164, 16);
            this.lblDelete.TabIndex = 54;
            this.lblDelete.Text = "Enter Member ID to Delete";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(47, 49);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(96, 22);
            this.txtDelete.TabIndex = 53;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(51, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(685, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.lblDelete);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(543, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 178);
            this.panel1.TabIndex = 56;
            // 
            // uiSendRecomm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCompetition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoach);
            this.Controls.Add(this.labTraining);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dataViewRecomme);
            this.Name = "uiSendRecomm";
            this.Text = "Send Recommendation";
            this.Load += new System.EventHandler(this.uiSendRecomm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecomme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewRecomme;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCompetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoach;
        private System.Windows.Forms.Label labTraining;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}