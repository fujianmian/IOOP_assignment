namespace Assignment19_3
{
    partial class uiAdd
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
            this.dataTrainingShow = new System.Windows.Forms.DataGridView();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.Label();
            this.txtFe = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTrainingShow
            // 
            this.dataTrainingShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrainingShow.Location = new System.Drawing.Point(12, 12);
            this.dataTrainingShow.Name = "dataTrainingShow";
            this.dataTrainingShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataTrainingShow.RowHeadersWidth = 51;
            this.dataTrainingShow.RowTemplate.Height = 24;
            this.dataTrainingShow.Size = new System.Drawing.Size(670, 258);
            this.dataTrainingShow.TabIndex = 0;
            this.dataTrainingShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTrainingShow_CellContentClick);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(358, 398);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 31;
            // 
            // comboLevel
            // 
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.comboLevel.Location = new System.Drawing.Point(130, 359);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(100, 24);
            this.comboLevel.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 324);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 287);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 25;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(269, 395);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(108, 36);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "Location";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(269, 359);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 36);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(269, 324);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(83, 36);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "Time End";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(269, 288);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(93, 36);
            this.lblStart.TabIndex = 21;
            this.lblStart.Text = "Time Start";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(6, 361);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(124, 37);
            this.lblLevel.TabIndex = 20;
            this.lblLevel.Text = "Training Level";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 324);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 37);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Training Name";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 287);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 36);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Training ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 37);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(358, 359);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 33;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(358, 324);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 22);
            this.txtEnd.TabIndex = 34;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(358, 287);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 22);
            this.txtStart.TabIndex = 35;
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(6, 395);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(108, 36);
            this.txtFee.TabIndex = 36;
            this.txtFee.Text = "Training Fee";
            // 
            // txtFe
            // 
            this.txtFe.Location = new System.Drawing.Point(130, 398);
            this.txtFe.Name = "txtFe";
            this.txtFe.Size = new System.Drawing.Size(100, 22);
            this.txtFe.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(45, 64);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(96, 22);
            this.txtDelete.TabIndex = 39;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(15, 26);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(163, 16);
            this.lblDelete.TabIndex = 40;
            this.lblDelete.Text = "Enter Training ID to Delete";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(236, 477);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 37);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 46);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.lblDelete);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(536, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 178);
            this.panel1.TabIndex = 43;
            // 
            // uiAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtFe);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.dataTrainingShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "uiAdd";
            this.Text = "UiAdd";
            this.Load += new System.EventHandler(this.uiAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTrainingShow;
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label txtFee;
        private System.Windows.Forms.TextBox txtFe;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}