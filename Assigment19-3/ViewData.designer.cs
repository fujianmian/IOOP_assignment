namespace Assignment19_3
{
    partial class ViewData
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btnViewSuggestion = new System.Windows.Forms.Button();
            this.btnViewCoachSalary = new System.Windows.Forms.Button();
            this.ViewCompetitionM = new System.Windows.Forms.Button();
            this.btnViewMemberAndCoach = new System.Windows.Forms.Button();
            this.ViewUserInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(13, 49);
            this.dataView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(732, 282);
            this.dataView.TabIndex = 0;
            // 
            // btnViewSuggestion
            // 
            this.btnViewSuggestion.Location = new System.Drawing.Point(33, 435);
            this.btnViewSuggestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewSuggestion.Name = "btnViewSuggestion";
            this.btnViewSuggestion.Size = new System.Drawing.Size(163, 37);
            this.btnViewSuggestion.TabIndex = 1;
            this.btnViewSuggestion.Text = "View Suggestion";
            this.btnViewSuggestion.UseVisualStyleBackColor = true;
            this.btnViewSuggestion.Click += new System.EventHandler(this.btnViewSuggestion_Click);
            // 
            // btnViewCoachSalary
            // 
            this.btnViewCoachSalary.Location = new System.Drawing.Point(279, 367);
            this.btnViewCoachSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewCoachSalary.Name = "btnViewCoachSalary";
            this.btnViewCoachSalary.Size = new System.Drawing.Size(170, 37);
            this.btnViewCoachSalary.TabIndex = 2;
            this.btnViewCoachSalary.Text = "View Coach Salary";
            this.btnViewCoachSalary.UseVisualStyleBackColor = true;
            this.btnViewCoachSalary.Click += new System.EventHandler(this.btnViewCoachSalary_Click);
            // 
            // ViewCompetitionM
            // 
            this.ViewCompetitionM.Location = new System.Drawing.Point(538, 367);
            this.ViewCompetitionM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewCompetitionM.Name = "ViewCompetitionM";
            this.ViewCompetitionM.Size = new System.Drawing.Size(202, 37);
            this.ViewCompetitionM.TabIndex = 3;
            this.ViewCompetitionM.Text = "View Competition";
            this.ViewCompetitionM.UseVisualStyleBackColor = true;
            this.ViewCompetitionM.Click += new System.EventHandler(this.ViewCompetition_Click);
            // 
            // btnViewMemberAndCoach
            // 
            this.btnViewMemberAndCoach.Location = new System.Drawing.Point(263, 435);
            this.btnViewMemberAndCoach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewMemberAndCoach.Name = "btnViewMemberAndCoach";
            this.btnViewMemberAndCoach.Size = new System.Drawing.Size(212, 37);
            this.btnViewMemberAndCoach.TabIndex = 4;
            this.btnViewMemberAndCoach.Text = "View Member and Coach ";
            this.btnViewMemberAndCoach.UseVisualStyleBackColor = true;
            this.btnViewMemberAndCoach.Click += new System.EventHandler(this.btnViewMemberAndCoach_Click);
            // 
            // ViewUserInfo
            // 
            this.ViewUserInfo.Location = new System.Drawing.Point(33, 367);
            this.ViewUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewUserInfo.Name = "ViewUserInfo";
            this.ViewUserInfo.Size = new System.Drawing.Size(163, 37);
            this.ViewUserInfo.TabIndex = 5;
            this.ViewUserInfo.Text = "View User Info";
            this.ViewUserInfo.UseVisualStyleBackColor = true;
            this.ViewUserInfo.Click += new System.EventHandler(this.ViewUserInfo_Click);
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.ViewUserInfo);
            this.Controls.Add(this.btnViewMemberAndCoach);
            this.Controls.Add(this.ViewCompetitionM);
            this.Controls.Add(this.btnViewCoachSalary);
            this.Controls.Add(this.btnViewSuggestion);
            this.Controls.Add(this.dataView);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewData";
            this.Text = "View Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnViewSuggestion;
        private System.Windows.Forms.Button btnViewCoachSalary;
        private System.Windows.Forms.Button ViewCompetitionM;
        private System.Windows.Forms.Button btnViewMemberAndCoach;
        private System.Windows.Forms.Button ViewUserInfo;
    }
}