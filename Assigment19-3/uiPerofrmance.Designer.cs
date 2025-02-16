namespace Assignment19_3
{
    partial class uiPerformance
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.labTraining = new System.Windows.Forms.Label();
            this.comboRating = new System.Windows.Forms.ComboBox();
            this.comboEvaluation = new System.Windows.Forms.ComboBox();
            this.comboAssessment = new System.Windows.Forms.ComboBox();
            this.lblTechnique = new System.Windows.Forms.Label();
            this.lblAssessment = new System.Windows.Forms.Label();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPerformance
            // 
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Location = new System.Drawing.Point(12, 12);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.Size = new System.Drawing.Size(667, 230);
            this.dataPerformance.TabIndex = 0;
            this.dataPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPerformance_CellContentClick);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(140, 294);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 27;
            // 
            // lblMember
            // 
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(13, 295);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(85, 36);
            this.lblMember.TabIndex = 26;
            this.lblMember.Text = "Member ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 336);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 29;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(11, 336);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(118, 36);
            this.labName.TabIndex = 28;
            this.labName.Text = "Member Name";
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(140, 371);
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(100, 22);
            this.txtTraining.TabIndex = 31;
            // 
            // labTraining
            // 
            this.labTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTraining.Location = new System.Drawing.Point(13, 370);
            this.labTraining.Name = "labTraining";
            this.labTraining.Size = new System.Drawing.Size(144, 36);
            this.labTraining.TabIndex = 30;
            this.labTraining.Text = "Training ID";
            // 
            // comboRating
            // 
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRating.Location = new System.Drawing.Point(431, 289);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(104, 24);
            this.comboRating.TabIndex = 32;
            // 
            // comboEvaluation
            // 
            this.comboEvaluation.FormattingEnabled = true;
            this.comboEvaluation.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboEvaluation.Location = new System.Drawing.Point(431, 407);
            this.comboEvaluation.Name = "comboEvaluation";
            this.comboEvaluation.Size = new System.Drawing.Size(104, 24);
            this.comboEvaluation.TabIndex = 33;
            // 
            // comboAssessment
            // 
            this.comboAssessment.FormattingEnabled = true;
            this.comboAssessment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboAssessment.Location = new System.Drawing.Point(431, 348);
            this.comboAssessment.Name = "comboAssessment";
            this.comboAssessment.Size = new System.Drawing.Size(104, 24);
            this.comboAssessment.TabIndex = 34;
            // 
            // lblTechnique
            // 
            this.lblTechnique.AutoSize = true;
            this.lblTechnique.Location = new System.Drawing.Point(260, 297);
            this.lblTechnique.Name = "lblTechnique";
            this.lblTechnique.Size = new System.Drawing.Size(113, 16);
            this.lblTechnique.TabIndex = 35;
            this.lblTechnique.Text = "Technique Rating";
            // 
            // lblAssessment
            // 
            this.lblAssessment.AutoSize = true;
            this.lblAssessment.Location = new System.Drawing.Point(260, 351);
            this.lblAssessment.Name = "lblAssessment";
            this.lblAssessment.Size = new System.Drawing.Size(139, 16);
            this.lblAssessment.TabIndex = 36;
            this.lblAssessment.Text = "Flexibility Assessment";
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(260, 407);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(121, 16);
            this.lblEvaluation.TabIndex = 37;
            this.lblEvaluation.Text = "Tactical Evaluation";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 37);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(14, 32);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(164, 16);
            this.lblDelete.TabIndex = 43;
            this.lblDelete.Text = "Enter Member ID to Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(44, 62);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(96, 22);
            this.txtDelete.TabIndex = 42;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(140, 409);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(100, 22);
            this.txtTrainName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Training Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(687, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 46;
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
            this.panel1.Location = new System.Drawing.Point(541, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 178);
            this.panel1.TabIndex = 47;
            // 
            // uiPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.lblAssessment);
            this.Controls.Add(this.lblTechnique);
            this.Controls.Add(this.comboAssessment);
            this.Controls.Add(this.comboEvaluation);
            this.Controls.Add(this.comboRating);
            this.Controls.Add(this.txtTraining);
            this.Controls.Add(this.labTraining);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dataPerformance);
            this.Name = "uiPerformance";
            this.Text = " Record Member\'s Performance";
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtTraining;
        private System.Windows.Forms.Label labTraining;
        private System.Windows.Forms.ComboBox comboRating;
        private System.Windows.Forms.ComboBox comboEvaluation;
        private System.Windows.Forms.ComboBox comboAssessment;
        private System.Windows.Forms.Label lblTechnique;
        private System.Windows.Forms.Label lblAssessment;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}