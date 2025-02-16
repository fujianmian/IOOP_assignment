namespace Assignment19_3
{
    partial class AddMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAMAddManager = new System.Windows.Forms.Button();
            this.btnAMAddCoach = new System.Windows.Forms.Button();
            this.btnAMAddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a role you want to add:";
            // 
            // btnAMAddManager
            // 
            this.btnAMAddManager.Location = new System.Drawing.Point(317, 121);
            this.btnAMAddManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAMAddManager.Name = "btnAMAddManager";
            this.btnAMAddManager.Size = new System.Drawing.Size(138, 44);
            this.btnAMAddManager.TabIndex = 1;
            this.btnAMAddManager.Text = "Add Manager";
            this.btnAMAddManager.UseVisualStyleBackColor = true;
            this.btnAMAddManager.Click += new System.EventHandler(this.btnAMAddManager_Click);
            // 
            // btnAMAddCoach
            // 
            this.btnAMAddCoach.Location = new System.Drawing.Point(317, 192);
            this.btnAMAddCoach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAMAddCoach.Name = "btnAMAddCoach";
            this.btnAMAddCoach.Size = new System.Drawing.Size(138, 44);
            this.btnAMAddCoach.TabIndex = 2;
            this.btnAMAddCoach.Text = "Add Coach";
            this.btnAMAddCoach.UseVisualStyleBackColor = true;
            this.btnAMAddCoach.Click += new System.EventHandler(this.btnAMAddCoach_Click);
            // 
            // btnAMAddMember
            // 
            this.btnAMAddMember.Location = new System.Drawing.Point(317, 266);
            this.btnAMAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAMAddMember.Name = "btnAMAddMember";
            this.btnAMAddMember.Size = new System.Drawing.Size(138, 44);
            this.btnAMAddMember.TabIndex = 3;
            this.btnAMAddMember.Text = "Add Member";
            this.btnAMAddMember.UseVisualStyleBackColor = true;
            this.btnAMAddMember.Click += new System.EventHandler(this.btnAMAddMember_Click);
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnAMAddMember);
            this.Controls.Add(this.btnAMAddCoach);
            this.Controls.Add(this.btnAMAddManager);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddMenu";
            this.Text = "Add Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAMAddManager;
        private System.Windows.Forms.Button btnAMAddCoach;
        private System.Windows.Forms.Button btnAMAddMember;
    }
}