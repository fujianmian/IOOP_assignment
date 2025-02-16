namespace Assignment19_3
{
    partial class frmTraining
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
            this.btnEnroll = new System.Windows.Forms.Button();
            this.lblTrain = new System.Windows.Forms.Label();
            this.clbTraining = new System.Windows.Forms.CheckedListBox();
            this.lblTrainList = new System.Windows.Forms.Label();
            this.dgvTrainList = new System.Windows.Forms.DataGridView();
            this.btnUnenroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnroll
            // 
            this.btnEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnroll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(476, 356);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(117, 37);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(172, 50);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(437, 46);
            this.lblTrain.TabIndex = 3;
            this.lblTrain.Text = "To Enroll Any Training";
            // 
            // clbTraining
            // 
            this.clbTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTraining.CheckOnClick = true;
            this.clbTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTraining.FormattingEnabled = true;
            this.clbTraining.Items.AddRange(new object[] {
            ""});
            this.clbTraining.Location = new System.Drawing.Point(68, 340);
            this.clbTraining.Name = "clbTraining";
            this.clbTraining.Size = new System.Drawing.Size(386, 79);
            this.clbTraining.TabIndex = 8;
            this.clbTraining.SelectedIndexChanged += new System.EventHandler(this.clbTraining_SelectedIndexChanged);
            // 
            // lblTrainList
            // 
            this.lblTrainList.AutoSize = true;
            this.lblTrainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainList.Location = new System.Drawing.Point(7, 115);
            this.lblTrainList.Name = "lblTrainList";
            this.lblTrainList.Size = new System.Drawing.Size(198, 32);
            this.lblTrainList.TabIndex = 15;
            this.lblTrainList.Text = "Training Lists";
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Location = new System.Drawing.Point(68, 150);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.Size = new System.Drawing.Size(680, 150);
            this.dgvTrainList.TabIndex = 18;
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnenroll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUnenroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnenroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnenroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenroll.Location = new System.Drawing.Point(613, 356);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(117, 37);
            this.btnUnenroll.TabIndex = 19;
            this.btnUnenroll.Text = "UnEnroll";
            this.btnUnenroll.UseVisualStyleBackColor = false;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // frmTraining
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.dgvTrainList);
            this.Controls.Add(this.lblTrainList);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.clbTraining);
            this.Name = "frmTraining";
            this.Text = "frmTraining";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.CheckedListBox clbTraining;
        private System.Windows.Forms.Label lblTrainList;
        private System.Windows.Forms.DataGridView dgvTrainList;
        private System.Windows.Forms.Button btnUnenroll;
    }
}