namespace Assignment19_3
{
    partial class DeletePage
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
            this.dataUserForDelete = new System.Windows.Forms.DataGridView();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserForDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUserForDelete
            // 
            this.dataUserForDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUserForDelete.Location = new System.Drawing.Point(61, 45);
            this.dataUserForDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataUserForDelete.Name = "dataUserForDelete";
            this.dataUserForDelete.RowHeadersWidth = 51;
            this.dataUserForDelete.RowTemplate.Height = 24;
            this.dataUserForDelete.Size = new System.Drawing.Size(640, 251);
            this.dataUserForDelete.TabIndex = 0;
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(181, 339);
            this.txtDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(112, 27);
            this.txtDeleteUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(465, 333);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Confirm Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeletePage
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeleteUser);
            this.Controls.Add(this.dataUserForDelete);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeletePage";
            this.Text = "Delete User";
            this.Load += new System.EventHandler(this.DeletePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUserForDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUserForDelete;
        private System.Windows.Forms.TextBox txtDeleteUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}