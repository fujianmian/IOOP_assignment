namespace Assignment19_3
{
    partial class uiEdit
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
            this.dataTraining = new System.Windows.Forms.DataGridView();
            this.txtFe = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTraining
            // 
            this.dataTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTraining.Location = new System.Drawing.Point(15, 12);
            this.dataTraining.Name = "dataTraining";
            this.dataTraining.RowHeadersWidth = 51;
            this.dataTraining.RowTemplate.Height = 24;
            this.dataTraining.Size = new System.Drawing.Size(670, 258);
            this.dataTraining.TabIndex = 3;
            this.dataTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTraining_CellContentClick);
            // 
            // txtFe
            // 
            this.txtFe.Location = new System.Drawing.Point(264, 400);
            this.txtFe.Name = "txtFe";
            this.txtFe.Size = new System.Drawing.Size(100, 22);
            this.txtFe.TabIndex = 53;
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(140, 397);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(108, 36);
            this.txtFee.TabIndex = 52;
            this.txtFee.Text = "Training Fee";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(491, 289);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 22);
            this.txtStart.TabIndex = 51;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(491, 326);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 22);
            this.txtEnd.TabIndex = 50;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(491, 361);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 49;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(491, 400);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 48;
            // 
            // comboLevel
            // 
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.comboLevel.Location = new System.Drawing.Point(264, 361);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(100, 24);
            this.comboLevel.TabIndex = 47;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(264, 326);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 46;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(264, 289);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 45;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(402, 397);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(108, 36);
            this.lblLocation.TabIndex = 44;
            this.lblLocation.Text = "Location";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(402, 361);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 36);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date";
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(402, 326);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(83, 36);
            this.lblEnd.TabIndex = 42;
            this.lblEnd.Text = "Time End";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(402, 290);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(93, 36);
            this.lblStart.TabIndex = 41;
            this.lblStart.Text = "Time Start";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(140, 363);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(124, 37);
            this.lblLevel.TabIndex = 40;
            this.lblLevel.Text = "Training Level";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(140, 326);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 37);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Training Name";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(140, 289);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 36);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "Training ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(691, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 46);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // uiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFe);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "uiEdit";
            this.Text = "Edit Training Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTraining;
        private System.Windows.Forms.TextBox txtFe;
        private System.Windows.Forms.Label txtFee;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}