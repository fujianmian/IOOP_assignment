namespace Assignment19_3
{
    partial class frmSuggestion
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
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.txtSuggestion = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(12, 60);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(351, 46);
            this.lblSuggestion.TabIndex = 13;
            this.lblSuggestion.Text = "Send Suggestion:";
            // 
            // txtSuggestion
            // 
            this.txtSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuggestion.Location = new System.Drawing.Point(54, 119);
            this.txtSuggestion.Multiline = true;
            this.txtSuggestion.Name = "txtSuggestion";
            this.txtSuggestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSuggestion.Size = new System.Drawing.Size(664, 260);
            this.txtSuggestion.TabIndex = 14;
            this.txtSuggestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuggestion_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(318, 407);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 47);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmSuggestion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSuggestion);
            this.Controls.Add(this.lblSuggestion);
            this.Name = "frmSuggestion";
            this.Text = "label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.TextBox txtSuggestion;
        private System.Windows.Forms.Button btnSend;
    }
}