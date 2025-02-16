namespace Assignment19_3
{
    partial class Manager_UI
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
            this.btn_Competition = new System.Windows.Forms.Button();
            this.btn_RecommendedStudent = new System.Windows.Forms.Button();
            this.BtnFindStudent = new System.Windows.Forms.Button();
            this.Btn_UpdateResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Competition
            // 
            this.btn_Competition.Location = new System.Drawing.Point(51, 34);
            this.btn_Competition.Name = "btn_Competition";
            this.btn_Competition.Size = new System.Drawing.Size(199, 89);
            this.btn_Competition.TabIndex = 0;
            this.btn_Competition.Text = "Modify Competition";
            this.btn_Competition.UseVisualStyleBackColor = true;
            this.btn_Competition.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RecommendedStudent
            // 
            this.btn_RecommendedStudent.Location = new System.Drawing.Point(412, 36);
            this.btn_RecommendedStudent.Name = "btn_RecommendedStudent";
            this.btn_RecommendedStudent.Size = new System.Drawing.Size(188, 87);
            this.btn_RecommendedStudent.TabIndex = 1;
            this.btn_RecommendedStudent.Text = "Assign Student";
            this.btn_RecommendedStudent.UseVisualStyleBackColor = true;
            this.btn_RecommendedStudent.Click += new System.EventHandler(this.button2_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.BtnUpdateProfile);
            this.panel1.Controls.Add(this.Btn_UpdateResult);
            this.panel1.Controls.Add(this.btn_Competition);
            this.panel1.Controls.Add(this.btn_RecommendedStudent);
            this.panel1.Controls.Add(this.BtnFindStudent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 152);
            this.panel1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(429, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 148);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!\r\nMy Dear Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Manager_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1436, 936);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Manager_UI";
            this.Text = "Manager UI";
            this.Load += new System.EventHandler(this.Manager_UI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Competition;
        private System.Windows.Forms.Button btn_RecommendedStudent;
        private System.Windows.Forms.Button BtnFindStudent;
        private System.Windows.Forms.Button Btn_UpdateResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Label label1;
    }
}

