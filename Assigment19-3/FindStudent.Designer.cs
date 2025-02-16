namespace Assignment19_3
{
    partial class FindStudentForm
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
            this.FindStudentGrid = new System.Windows.Forms.DataGridView();
            this.LblFIndStudent = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearchStudent = new System.Windows.Forms.Button();
            this.BtnClearSearchStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.Btn_UpdateResult = new System.Windows.Forms.Button();
            this.btn_Competition = new System.Windows.Forms.Button();
            this.btn_RecommendedStudent = new System.Windows.Forms.Button();
            this.BtnMainPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FindStudentGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindStudentGrid
            // 
            this.FindStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindStudentGrid.Location = new System.Drawing.Point(159, 240);
            this.FindStudentGrid.Name = "FindStudentGrid";
            this.FindStudentGrid.RowHeadersWidth = 72;
            this.FindStudentGrid.RowTemplate.Height = 31;
            this.FindStudentGrid.Size = new System.Drawing.Size(506, 577);
            this.FindStudentGrid.TabIndex = 0;
            this.FindStudentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindStudentGrid_CellContentClick);
            // 
            // LblFIndStudent
            // 
            this.LblFIndStudent.AutoSize = true;
            this.LblFIndStudent.Location = new System.Drawing.Point(865, 349);
            this.LblFIndStudent.Name = "LblFIndStudent";
            this.LblFIndStudent.Size = new System.Drawing.Size(345, 50);
            this.LblFIndStudent.TabIndex = 1;
            this.LblFIndStudent.Text = "Please enter competition id In below\r\nto search for student that participate in:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(870, 413);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(326, 29);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearchStudent
            // 
            this.BtnSearchStudent.Location = new System.Drawing.Point(870, 484);
            this.BtnSearchStudent.Name = "BtnSearchStudent";
            this.BtnSearchStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSearchStudent.Size = new System.Drawing.Size(106, 53);
            this.BtnSearchStudent.TabIndex = 3;
            this.BtnSearchStudent.Text = "Search";
            this.BtnSearchStudent.UseVisualStyleBackColor = true;
            this.BtnSearchStudent.Click += new System.EventHandler(this.BtnSearchStudent_Click);
            // 
            // BtnClearSearchStudent
            // 
            this.BtnClearSearchStudent.Location = new System.Drawing.Point(1090, 484);
            this.BtnClearSearchStudent.Name = "BtnClearSearchStudent";
            this.BtnClearSearchStudent.Size = new System.Drawing.Size(106, 53);
            this.BtnClearSearchStudent.TabIndex = 4;
            this.BtnClearSearchStudent.Text = "Clear";
            this.BtnClearSearchStudent.UseVisualStyleBackColor = true;
            this.BtnClearSearchStudent.Click += new System.EventHandler(this.BtnClearSearchStudent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.BtnUpdateProfile);
            this.panel1.Controls.Add(this.Btn_UpdateResult);
            this.panel1.Controls.Add(this.btn_Competition);
            this.panel1.Controls.Add(this.btn_RecommendedStudent);
            this.panel1.Controls.Add(this.BtnMainPage);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 154);
            this.panel1.TabIndex = 5;
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
            this.BtnUpdateProfile.Location = new System.Drawing.Point(890, 36);
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
            // BtnMainPage
            // 
            this.BtnMainPage.BackColor = System.Drawing.Color.Lavender;
            this.BtnMainPage.Location = new System.Drawing.Point(256, 36);
            this.BtnMainPage.Name = "BtnMainPage";
            this.BtnMainPage.Size = new System.Drawing.Size(150, 87);
            this.BtnMainPage.TabIndex = 2;
            this.BtnMainPage.Text = "Main Page";
            this.BtnMainPage.UseVisualStyleBackColor = false;
            this.BtnMainPage.Click += new System.EventHandler(this.BtnMainPage_Click);
            // 
            // FindStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1436, 936);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClearSearchStudent);
            this.Controls.Add(this.BtnSearchStudent);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblFIndStudent);
            this.Controls.Add(this.FindStudentGrid);
            this.Name = "FindStudentForm";
            this.Text = "FindStudent";
            ((System.ComponentModel.ISupportInitialize)(this.FindStudentGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FindStudentGrid;
        private System.Windows.Forms.Label LblFIndStudent;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearchStudent;
        private System.Windows.Forms.Button BtnClearSearchStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Button Btn_UpdateResult;
        private System.Windows.Forms.Button btn_Competition;
        private System.Windows.Forms.Button btn_RecommendedStudent;
        private System.Windows.Forms.Button BtnMainPage;
    }
}