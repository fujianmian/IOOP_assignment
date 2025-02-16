namespace Assignment19_3
{
    partial class CompetitionForm
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
            this.btn_AddCompetition = new System.Windows.Forms.Button();
            this.btn_EditCompetition = new System.Windows.Forms.Button();
            this.btn_DeleteCompetition = new System.Windows.Forms.Button();
            this.LstCompetition = new System.Windows.Forms.DataGridView();
            this.lblCompetitionID = new System.Windows.Forms.TextBox();
            this.lblCompetitionName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateCompetition = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.Btn_UpdateResult = new System.Windows.Forms.Button();
            this.btn_MainPage = new System.Windows.Forms.Button();
            this.btn_RecommendedStudent = new System.Windows.Forms.Button();
            this.BtnFindStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LstCompetition)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddCompetition
            // 
            this.btn_AddCompetition.Location = new System.Drawing.Point(1206, 178);
            this.btn_AddCompetition.Name = "btn_AddCompetition";
            this.btn_AddCompetition.Size = new System.Drawing.Size(187, 69);
            this.btn_AddCompetition.TabIndex = 1;
            this.btn_AddCompetition.Text = "Add Competition";
            this.btn_AddCompetition.UseVisualStyleBackColor = true;
            this.btn_AddCompetition.Click += new System.EventHandler(this.btn_AddCompetition_Click);
            // 
            // btn_EditCompetition
            // 
            this.btn_EditCompetition.Location = new System.Drawing.Point(1206, 269);
            this.btn_EditCompetition.Name = "btn_EditCompetition";
            this.btn_EditCompetition.Size = new System.Drawing.Size(187, 69);
            this.btn_EditCompetition.TabIndex = 2;
            this.btn_EditCompetition.Text = "Edit Competition";
            this.btn_EditCompetition.UseVisualStyleBackColor = true;
            this.btn_EditCompetition.Click += new System.EventHandler(this.btn_EditCompetition_Click);
            // 
            // btn_DeleteCompetition
            // 
            this.btn_DeleteCompetition.Location = new System.Drawing.Point(1206, 373);
            this.btn_DeleteCompetition.Name = "btn_DeleteCompetition";
            this.btn_DeleteCompetition.Size = new System.Drawing.Size(187, 69);
            this.btn_DeleteCompetition.TabIndex = 3;
            this.btn_DeleteCompetition.Text = "Delete Competition";
            this.btn_DeleteCompetition.UseVisualStyleBackColor = true;
            this.btn_DeleteCompetition.Click += new System.EventHandler(this.btn_DeleteCompetition_Click);
            // 
            // LstCompetition
            // 
            this.LstCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LstCompetition.Location = new System.Drawing.Point(80, 178);
            this.LstCompetition.Name = "LstCompetition";
            this.LstCompetition.RowHeadersWidth = 72;
            this.LstCompetition.RowTemplate.Height = 31;
            this.LstCompetition.Size = new System.Drawing.Size(1061, 504);
            this.LstCompetition.TabIndex = 7;
            this.LstCompetition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstCompetition_CellContentClick);
            // 
            // lblCompetitionID
            // 
            this.lblCompetitionID.Location = new System.Drawing.Point(260, 725);
            this.lblCompetitionID.Name = "lblCompetitionID";
            this.lblCompetitionID.Size = new System.Drawing.Size(142, 29);
            this.lblCompetitionID.TabIndex = 8;
            this.lblCompetitionID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.Location = new System.Drawing.Point(260, 786);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(142, 29);
            this.lblCompetitionName.TabIndex = 9;
            this.lblCompetitionName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(1008, 732);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(315, 29);
            this.txtLocation.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(563, 790);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(315, 29);
            this.txtTime.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Competition ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 789);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Competition Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 728);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 794);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 732);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Location:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateCompetition
            // 
            this.dateCompetition.Location = new System.Drawing.Point(563, 728);
            this.dateCompetition.Name = "dateCompetition";
            this.dateCompetition.Size = new System.Drawing.Size(315, 29);
            this.dateCompetition.TabIndex = 23;
            this.dateCompetition.Value = new System.DateTime(2024, 3, 19, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1206, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 61);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.BtnUpdateProfile);
            this.panel1.Controls.Add(this.Btn_UpdateResult);
            this.panel1.Controls.Add(this.btn_MainPage);
            this.panel1.Controls.Add(this.btn_RecommendedStudent);
            this.panel1.Controls.Add(this.BtnFindStudent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 152);
            this.panel1.TabIndex = 25;
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
            // btn_MainPage
            // 
            this.btn_MainPage.BackColor = System.Drawing.Color.Lavender;
            this.btn_MainPage.Location = new System.Drawing.Point(51, 34);
            this.btn_MainPage.Name = "btn_MainPage";
            this.btn_MainPage.Size = new System.Drawing.Size(199, 89);
            this.btn_MainPage.TabIndex = 0;
            this.btn_MainPage.Text = "Main Page";
            this.btn_MainPage.UseVisualStyleBackColor = false;
            this.btn_MainPage.Click += new System.EventHandler(this.btn_MainPage_Click);
            // 
            // btn_RecommendedStudent
            // 
            this.btn_RecommendedStudent.Location = new System.Drawing.Point(412, 36);
            this.btn_RecommendedStudent.Name = "btn_RecommendedStudent";
            this.btn_RecommendedStudent.Size = new System.Drawing.Size(188, 87);
            this.btn_RecommendedStudent.TabIndex = 1;
            this.btn_RecommendedStudent.Text = "Assign Student";
            this.btn_RecommendedStudent.UseVisualStyleBackColor = true;
            this.btn_RecommendedStudent.Click += new System.EventHandler(this.btn_RecommendedStudent_Click);
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
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1446, 963);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dateCompetition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblCompetitionName);
            this.Controls.Add(this.lblCompetitionID);
            this.Controls.Add(this.LstCompetition);
            this.Controls.Add(this.btn_DeleteCompetition);
            this.Controls.Add(this.btn_EditCompetition);
            this.Controls.Add(this.btn_AddCompetition);
            this.Name = "CompetitionForm";
            this.Text = "Modify Competition";
            this.Load += new System.EventHandler(this.Competition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LstCompetition)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddCompetition;
        private System.Windows.Forms.Button btn_EditCompetition;
        private System.Windows.Forms.Button btn_DeleteCompetition;
        private System.Windows.Forms.DataGridView LstCompetition;
        private System.Windows.Forms.TextBox lblCompetitionID;
        private System.Windows.Forms.TextBox lblCompetitionName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateCompetition;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Button Btn_UpdateResult;
        private System.Windows.Forms.Button btn_MainPage;
        private System.Windows.Forms.Button btn_RecommendedStudent;
        private System.Windows.Forms.Button BtnFindStudent;
    }
}