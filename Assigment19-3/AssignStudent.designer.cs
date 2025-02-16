namespace Assignment19_3
{
    partial class AssignStudentForm
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
            this.DataGridViewRecommended = new System.Windows.Forms.DataGridView();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.Btn_UpdateResult = new System.Windows.Forms.Button();
            this.btn_Competition = new System.Windows.Forms.Button();
            this.btn_MainPage = new System.Windows.Forms.Button();
            this.BtnFindStudent = new System.Windows.Forms.Button();
            this.LblStudentID = new System.Windows.Forms.Label();
            this.LblStudentName = new System.Windows.Forms.Label();
            this.LblCompetitionID = new System.Windows.Forms.Label();
            this.LblCompetitionName = new System.Windows.Forms.Label();
            this.LblCoachID = new System.Windows.Forms.Label();
            this.LblCoachName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecommended)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewRecommended
            // 
            this.DataGridViewRecommended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRecommended.Location = new System.Drawing.Point(71, 203);
            this.DataGridViewRecommended.Name = "DataGridViewRecommended";
            this.DataGridViewRecommended.RowHeadersWidth = 72;
            this.DataGridViewRecommended.RowTemplate.Height = 31;
            this.DataGridViewRecommended.Size = new System.Drawing.Size(1239, 544);
            this.DataGridViewRecommended.TabIndex = 0;
            this.DataGridViewRecommended.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRecommended_CellContentClick);
            // 
            // BtnAssign
            // 
            this.BtnAssign.Location = new System.Drawing.Point(1052, 792);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(258, 83);
            this.BtnAssign.TabIndex = 1;
            this.BtnAssign.Text = "Assign";
            this.BtnAssign.UseVisualStyleBackColor = true;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 792);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 843);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 792);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coach ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 846);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coach Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 792);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Competition ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 846);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Competition Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(1254, 36);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(144, 87);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.BtnUpdateProfile);
            this.panel1.Controls.Add(this.Btn_UpdateResult);
            this.panel1.Controls.Add(this.btn_Competition);
            this.panel1.Controls.Add(this.btn_MainPage);
            this.panel1.Controls.Add(this.BtnFindStudent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 152);
            this.panel1.TabIndex = 14;
            // 
            // BtnUpdateProfile
            // 
            this.BtnUpdateProfile.Location = new System.Drawing.Point(887, 36);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(192, 87);
            this.BtnUpdateProfile.TabIndex = 4;
            this.BtnUpdateProfile.Text = "Update Profile";
            this.BtnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // Btn_UpdateResult
            // 
            this.Btn_UpdateResult.Location = new System.Drawing.Point(606, 36);
            this.Btn_UpdateResult.Name = "Btn_UpdateResult";
            this.Btn_UpdateResult.Size = new System.Drawing.Size(275, 87);
            this.Btn_UpdateResult.TabIndex = 3;
            this.Btn_UpdateResult.Text = "Update Result of Competition";
            this.Btn_UpdateResult.UseVisualStyleBackColor = true;
            this.Btn_UpdateResult.Click += new System.EventHandler(this.Btn_UpdateResult_Click);
            // 
            // btn_Competition
            // 
            this.btn_Competition.Location = new System.Drawing.Point(51, 34);
            this.btn_Competition.Name = "btn_Competition";
            this.btn_Competition.Size = new System.Drawing.Size(199, 89);
            this.btn_Competition.TabIndex = 0;
            this.btn_Competition.Text = "Modify Competition";
            this.btn_Competition.UseVisualStyleBackColor = true;
            this.btn_Competition.Click += new System.EventHandler(this.btn_Competition_Click);
            // 
            // btn_MainPage
            // 
            this.btn_MainPage.BackColor = System.Drawing.Color.Lavender;
            this.btn_MainPage.Location = new System.Drawing.Point(412, 36);
            this.btn_MainPage.Name = "btn_MainPage";
            this.btn_MainPage.Size = new System.Drawing.Size(188, 87);
            this.btn_MainPage.TabIndex = 1;
            this.btn_MainPage.Text = "Main Page";
            this.btn_MainPage.UseVisualStyleBackColor = false;
            this.btn_MainPage.Click += new System.EventHandler(this.btn_MainPage_Click);
            // 
            // BtnFindStudent
            // 
            this.BtnFindStudent.Location = new System.Drawing.Point(256, 36);
            this.BtnFindStudent.Name = "BtnFindStudent";
            this.BtnFindStudent.Size = new System.Drawing.Size(150, 87);
            this.BtnFindStudent.TabIndex = 2;
            this.BtnFindStudent.Text = "Find Student";
            this.BtnFindStudent.UseVisualStyleBackColor = true;
            this.BtnFindStudent.Click += new System.EventHandler(this.BtnFindStudent_Click);
            // 
            // LblStudentID
            // 
            this.LblStudentID.AutoSize = true;
            this.LblStudentID.Location = new System.Drawing.Point(229, 792);
            this.LblStudentID.Name = "LblStudentID";
            this.LblStudentID.Size = new System.Drawing.Size(0, 25);
            this.LblStudentID.TabIndex = 15;
            // 
            // LblStudentName
            // 
            this.LblStudentName.AutoSize = true;
            this.LblStudentName.Location = new System.Drawing.Point(229, 843);
            this.LblStudentName.Name = "LblStudentName";
            this.LblStudentName.Size = new System.Drawing.Size(0, 25);
            this.LblStudentName.TabIndex = 17;
            // 
            // LblCompetitionID
            // 
            this.LblCompetitionID.AutoSize = true;
            this.LblCompetitionID.Location = new System.Drawing.Point(601, 792);
            this.LblCompetitionID.Name = "LblCompetitionID";
            this.LblCompetitionID.Size = new System.Drawing.Size(0, 25);
            this.LblCompetitionID.TabIndex = 19;
            // 
            // LblCompetitionName
            // 
            this.LblCompetitionName.AutoSize = true;
            this.LblCompetitionName.Location = new System.Drawing.Point(601, 850);
            this.LblCompetitionName.Name = "LblCompetitionName";
            this.LblCompetitionName.Size = new System.Drawing.Size(0, 25);
            this.LblCompetitionName.TabIndex = 20;
            // 
            // LblCoachID
            // 
            this.LblCoachID.AutoSize = true;
            this.LblCoachID.Location = new System.Drawing.Point(929, 792);
            this.LblCoachID.Name = "LblCoachID";
            this.LblCoachID.Size = new System.Drawing.Size(0, 25);
            this.LblCoachID.TabIndex = 21;
            // 
            // LblCoachName
            // 
            this.LblCoachName.AutoSize = true;
            this.LblCoachName.Location = new System.Drawing.Point(929, 843);
            this.LblCoachName.Name = "LblCoachName";
            this.LblCoachName.Size = new System.Drawing.Size(0, 25);
            this.LblCoachName.TabIndex = 22;
            // 
            // AssignStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1436, 936);
            this.Controls.Add(this.LblCoachName);
            this.Controls.Add(this.LblCoachID);
            this.Controls.Add(this.LblCompetitionName);
            this.Controls.Add(this.LblCompetitionID);
            this.Controls.Add(this.LblStudentName);
            this.Controls.Add(this.LblStudentID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAssign);
            this.Controls.Add(this.DataGridViewRecommended);
            this.Name = "AssignStudentForm";
            this.Text = "AssignStudent";
            this.Load += new System.EventHandler(this.AssignStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecommended)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewRecommended;
        private System.Windows.Forms.Button BtnAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Button Btn_UpdateResult;
        private System.Windows.Forms.Button btn_Competition;
        private System.Windows.Forms.Button btn_MainPage;
        private System.Windows.Forms.Button BtnFindStudent;
        private System.Windows.Forms.Label LblStudentID;
        private System.Windows.Forms.Label LblStudentName;
        private System.Windows.Forms.Label LblCompetitionID;
        private System.Windows.Forms.Label LblCompetitionName;
        private System.Windows.Forms.Label LblCoachID;
        private System.Windows.Forms.Label LblCoachName;
    }
}