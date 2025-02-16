namespace Assignment19_3
{
    partial class ManagementPage
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
            this.btnMPAdd = new System.Windows.Forms.Button();
            this.btnMPEdit = new System.Windows.Forms.Button();
            this.btnMPDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a function:";
            // 
            // btnMPAdd
            // 
            this.btnMPAdd.Location = new System.Drawing.Point(313, 120);
            this.btnMPAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMPAdd.Name = "btnMPAdd";
            this.btnMPAdd.Size = new System.Drawing.Size(122, 52);
            this.btnMPAdd.TabIndex = 1;
            this.btnMPAdd.Text = "Add";
            this.btnMPAdd.UseVisualStyleBackColor = true;
            this.btnMPAdd.Click += new System.EventHandler(this.btnMPAdd_Click);
            // 
            // btnMPEdit
            // 
            this.btnMPEdit.Location = new System.Drawing.Point(313, 185);
            this.btnMPEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMPEdit.Name = "btnMPEdit";
            this.btnMPEdit.Size = new System.Drawing.Size(122, 52);
            this.btnMPEdit.TabIndex = 2;
            this.btnMPEdit.Text = "Edit";
            this.btnMPEdit.UseVisualStyleBackColor = true;
            this.btnMPEdit.Click += new System.EventHandler(this.btnMPEdit_Click);
            // 
            // btnMPDelete
            // 
            this.btnMPDelete.Location = new System.Drawing.Point(313, 248);
            this.btnMPDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMPDelete.Name = "btnMPDelete";
            this.btnMPDelete.Size = new System.Drawing.Size(122, 52);
            this.btnMPDelete.TabIndex = 3;
            this.btnMPDelete.Text = "Delete";
            this.btnMPDelete.UseVisualStyleBackColor = true;
            this.btnMPDelete.Click += new System.EventHandler(this.btnMPDelete_Click);
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnMPDelete);
            this.Controls.Add(this.btnMPEdit);
            this.Controls.Add(this.btnMPAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagementPage";
            this.Text = "Management Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMPAdd;
        private System.Windows.Forms.Button btnMPEdit;
        private System.Windows.Forms.Button btnMPDelete;
    }
}