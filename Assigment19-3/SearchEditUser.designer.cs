namespace Assignment19_3
{
    partial class SearchEditUser
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
            this.txtSearchEditID = new System.Windows.Forms.TextBox();
            this.btnSearchEditID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchEditID
            // 
            this.txtSearchEditID.Location = new System.Drawing.Point(268, 143);
            this.txtSearchEditID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEditID.Name = "txtSearchEditID";
            this.txtSearchEditID.Size = new System.Drawing.Size(155, 27);
            this.txtSearchEditID.TabIndex = 0;
            // 
            // btnSearchEditID
            // 
            this.btnSearchEditID.Location = new System.Drawing.Point(305, 219);
            this.btnSearchEditID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchEditID.Name = "btnSearchEditID";
            this.btnSearchEditID.Size = new System.Drawing.Size(84, 27);
            this.btnSearchEditID.TabIndex = 1;
            this.btnSearchEditID.Text = "Search";
            this.btnSearchEditID.UseVisualStyleBackColor = true;
            this.btnSearchEditID.Click += new System.EventHandler(this.btnSearchEditID_Click);
            // 
            // SearchEditUser
            // 
            this.AcceptButton = this.btnSearchEditID;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnSearchEditID);
            this.Controls.Add(this.txtSearchEditID);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchEditUser";
            this.Text = "Search Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchEditID;
        private System.Windows.Forms.Button btnSearchEditID;
    }
}