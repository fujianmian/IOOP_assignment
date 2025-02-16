namespace Assignment19_3
{
    partial class UpdateResultForm
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
            this.Btn_RecordCompetitionResult = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblUpdate_1 = new System.Windows.Forms.Label();
            this.LblUpdate_2 = new System.Windows.Forms.Label();
            this.LblUpdate_CompetitionID = new System.Windows.Forms.Label();
            this.LblUpdate_StudentID = new System.Windows.Forms.Label();
            this.RecodComboBox = new System.Windows.Forms.ComboBox();
            this.LblUpdate_3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.Btn_MainPage = new System.Windows.Forms.Button();
            this.btn_Competition = new System.Windows.Forms.Button();
            this.btn_RecommendedStudent = new System.Windows.Forms.Button();
            this.BtnFindStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_RecordCompetitionResult
            // 
            this.Btn_RecordCompetitionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RecordCompetitionResult.Location = new System.Drawing.Point(945, 592);
            this.Btn_RecordCompetitionResult.Name = "Btn_RecordCompetitionResult";
            this.Btn_RecordCompetitionResult.Size = new System.Drawing.Size(329, 89);
            this.Btn_RecordCompetitionResult.TabIndex = 0;
            this.Btn_RecordCompetitionResult.Text = "Update Result";
            this.Btn_RecordCompetitionResult.UseVisualStyleBackColor = true;
            this.Btn_RecordCompetitionResult.Click += new System.EventHandler(this.Btn_RecordCompetitionResult_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(688, 507);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblUpdate_1
            // 
            this.LblUpdate_1.AutoSize = true;
            this.LblUpdate_1.Location = new System.Drawing.Point(872, 380);
            this.LblUpdate_1.Name = "LblUpdate_1";
            this.LblUpdate_1.Size = new System.Drawing.Size(184, 25);
            this.LblUpdate_1.TabIndex = 2;
            this.LblUpdate_1.Text = "Competition Name: ";
            // 
            // LblUpdate_2
            // 
            this.LblUpdate_2.AutoSize = true;
            this.LblUpdate_2.Location = new System.Drawing.Point(908, 442);
            this.LblUpdate_2.Name = "LblUpdate_2";
            this.LblUpdate_2.Size = new System.Drawing.Size(148, 25);
            this.LblUpdate_2.TabIndex = 3;
            this.LblUpdate_2.Text = "Student Name: ";
            // 
            // LblUpdate_CompetitionID
            // 
            this.LblUpdate_CompetitionID.AutoSize = true;
            this.LblUpdate_CompetitionID.Location = new System.Drawing.Point(1079, 380);
            this.LblUpdate_CompetitionID.Name = "LblUpdate_CompetitionID";
            this.LblUpdate_CompetitionID.Size = new System.Drawing.Size(0, 25);
            this.LblUpdate_CompetitionID.TabIndex = 4;
            // 
            // LblUpdate_StudentID
            // 
            this.LblUpdate_StudentID.AutoSize = true;
            this.LblUpdate_StudentID.Location = new System.Drawing.Point(1079, 442);
            this.LblUpdate_StudentID.Name = "LblUpdate_StudentID";
            this.LblUpdate_StudentID.Size = new System.Drawing.Size(0, 25);
            this.LblUpdate_StudentID.TabIndex = 5;
            // 
            // RecodComboBox
            // 
            this.RecodComboBox.FormattingEnabled = true;
            this.RecodComboBox.Items.AddRange(new object[] {
            "havent started",
            "win",
            "lose",
            "Cancelled"});
            this.RecodComboBox.Location = new System.Drawing.Point(1084, 509);
            this.RecodComboBox.Name = "RecodComboBox";
            this.RecodComboBox.Size = new System.Drawing.Size(121, 32);
            this.RecodComboBox.TabIndex = 6;
            // 
            // LblUpdate_3
            // 
            this.LblUpdate_3.AutoSize = true;
            this.LblUpdate_3.Location = new System.Drawing.Point(977, 516);
            this.LblUpdate_3.Name = "LblUpdate_3";
            this.LblUpdate_3.Size = new System.Drawing.Size(79, 25);
            this.LblUpdate_3.TabIndex = 7;
            this.LblUpdate_3.Text = "Status: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.BtnUpdateProfile);
            this.panel1.Controls.Add(this.Btn_MainPage);
            this.panel1.Controls.Add(this.btn_Competition);
            this.panel1.Controls.Add(this.btn_RecommendedStudent);
            this.panel1.Controls.Add(this.BtnFindStudent);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 152);
            this.panel1.TabIndex = 8;
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
            this.BtnUpdateProfile.Location = new System.Drawing.Point(886, 36);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(192, 87);
            this.BtnUpdateProfile.TabIndex = 4;
            this.BtnUpdateProfile.Text = "Update Profile";
            this.BtnUpdateProfile.UseVisualStyleBackColor = true;
            this.BtnUpdateProfile.Click += new System.EventHandler(this.BtnUpdateProfile_Click);
            // 
            // Btn_MainPage
            // 
            this.Btn_MainPage.BackColor = System.Drawing.Color.Lavender;
            this.Btn_MainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MainPage.Location = new System.Drawing.Point(605, 36);
            this.Btn_MainPage.Name = "Btn_MainPage";
            this.Btn_MainPage.Size = new System.Drawing.Size(275, 87);
            this.Btn_MainPage.TabIndex = 3;
            this.Btn_MainPage.Text = "Main Page";
            this.Btn_MainPage.UseVisualStyleBackColor = false;
            this.Btn_MainPage.Click += new System.EventHandler(this.Btn_UpdateResult_Click);
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
            // btn_RecommendedStudent
            // 
            this.btn_RecommendedStudent.Location = new System.Drawing.Point(412, 36);
            this.btn_RecommendedStudent.Name = "btn_RecommendedStudent";
            this.btn_RecommendedStudent.Size = new System.Drawing.Size(188, 87);
            this.btn_RecommendedStudent.TabIndex = 1;
            this.btn_RecommendedStudent.Text = "Assign Student";
            this.btn_RecommendedStudent.UseVisualStyleBackColor = true;
            this.btn_RecommendedStudent.Click += new System.EventHandler(this.btn_RecommendedStudent_Click_1);
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
            // UpdateResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1436, 936);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblUpdate_3);
            this.Controls.Add(this.RecodComboBox);
            this.Controls.Add(this.LblUpdate_StudentID);
            this.Controls.Add(this.LblUpdate_CompetitionID);
            this.Controls.Add(this.LblUpdate_2);
            this.Controls.Add(this.LblUpdate_1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_RecordCompetitionResult);
            this.Name = "UpdateResultForm";
            this.Text = "UpdateResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_RecordCompetitionResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblUpdate_1;
        private System.Windows.Forms.Label LblUpdate_2;
        private System.Windows.Forms.Label LblUpdate_CompetitionID;
        private System.Windows.Forms.Label LblUpdate_StudentID;
        private System.Windows.Forms.ComboBox RecodComboBox;
        private System.Windows.Forms.Label LblUpdate_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Button Btn_MainPage;
        private System.Windows.Forms.Button btn_Competition;
        private System.Windows.Forms.Button btn_RecommendedStudent;
        private System.Windows.Forms.Button BtnFindStudent;
    }
}