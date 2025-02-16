namespace Assignment19_3
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            this.btnTraning = new System.Windows.Forms.Button();
            this.lblSche = new System.Windows.Forms.Label();
            this.pnlMain1 = new System.Windows.Forms.Panel();
            this.pnlPerformance = new System.Windows.Forms.Panel();
            this.lstPerformance = new System.Windows.Forms.ListBox();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlMain1.SuspendLayout();
            this.pnlPerformance.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTraning
            // 
            this.btnTraning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraning.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraning.FlatAppearance.BorderSize = 0;
            this.btnTraning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraning.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraning.Location = new System.Drawing.Point(12, 12);
            this.btnTraning.Name = "btnTraning";
            this.btnTraning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTraning.Size = new System.Drawing.Size(95, 40);
            this.btnTraning.TabIndex = 1;
            this.btnTraning.Text = "Training";
            this.btnTraning.UseVisualStyleBackColor = false;
            this.btnTraning.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSche
            // 
            this.lblSche.AutoSize = true;
            this.lblSche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSche.Location = new System.Drawing.Point(196, 176);
            this.lblSche.Name = "lblSche";
            this.lblSche.Size = new System.Drawing.Size(249, 44);
            this.lblSche.TabIndex = 7;
            this.lblSche.Text = "My Schedule";
            // 
            // pnlMain1
            // 
            this.pnlMain1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMain1.Controls.Add(this.pnlPerformance);
            this.pnlMain1.Controls.Add(this.lstSchedule);
            this.pnlMain1.Controls.Add(this.panel1);
            this.pnlMain1.Controls.Add(this.lblWelcome);
            this.pnlMain1.Controls.Add(this.panelControl);
            this.pnlMain1.Controls.Add(this.lblSche);
            this.pnlMain1.Location = new System.Drawing.Point(0, 0);
            this.pnlMain1.Name = "pnlMain1";
            this.pnlMain1.Size = new System.Drawing.Size(765, 538);
            this.pnlMain1.TabIndex = 8;
            // 
            // pnlPerformance
            // 
            this.pnlPerformance.Controls.Add(this.lstPerformance);
            this.pnlPerformance.Controls.Add(this.lblPerformance);
            this.pnlPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPerformance.Location = new System.Drawing.Point(193, 176);
            this.pnlPerformance.Name = "pnlPerformance";
            this.pnlPerformance.Size = new System.Drawing.Size(572, 362);
            this.pnlPerformance.TabIndex = 16;
            this.pnlPerformance.Visible = false;
            // 
            // lstPerformance
            // 
            this.lstPerformance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPerformance.FormattingEnabled = true;
            this.lstPerformance.ItemHeight = 32;
            this.lstPerformance.Location = new System.Drawing.Point(37, 42);
            this.lstPerformance.Name = "lstPerformance";
            this.lstPerformance.Size = new System.Drawing.Size(488, 224);
            this.lstPerformance.TabIndex = 1;
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformance.Location = new System.Drawing.Point(3, 7);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(313, 44);
            this.lblPerformance.TabIndex = 0;
            this.lblPerformance.Text = "My Performance";
            // 
            // lstSchedule
            // 
            this.lstSchedule.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.ItemHeight = 37;
            this.lstSchedule.Location = new System.Drawing.Point(230, 211);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSchedule.Size = new System.Drawing.Size(488, 222);
            this.lstSchedule.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnPerformance);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.ptbPhoto);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 474);
            this.panel1.TabIndex = 14;
            // 
            // btnPerformance
            // 
            this.btnPerformance.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformance.Location = new System.Drawing.Point(25, 403);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(137, 41);
            this.btnPerformance.TabIndex = 16;
            this.btnPerformance.Text = "Performance";
            this.btnPerformance.UseVisualStyleBackColor = false;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(43, 338);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 38);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "label4";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 218);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 44);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "label3";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(43, 278);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(121, 44);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "label2";
            this.lblLevel.Click += new System.EventHandler(this.lblLevel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 44);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbPhoto.Image")));
            this.ptbPhoto.Location = new System.Drawing.Point(35, 27);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(100, 85);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPhoto.TabIndex = 0;
            this.ptbPhoto.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(186, 67);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 132);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "hi";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.Controls.Add(this.btnSuggestion);
            this.panelControl.Controls.Add(this.btnLogout);
            this.panelControl.Controls.Add(this.btnCompetition);
            this.panelControl.Controls.Add(this.btnPayment);
            this.panelControl.Controls.Add(this.btnProfile);
            this.panelControl.Controls.Add(this.btnTraning);
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(765, 64);
            this.panelControl.TabIndex = 10;
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuggestion.Location = new System.Drawing.Point(388, 12);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(124, 40);
            this.btnSuggestion.TabIndex = 10;
            this.btnSuggestion.Text = "Sugesstion";
            this.btnSuggestion.UseVisualStyleBackColor = true;
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(656, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCompetition
            // 
            this.btnCompetition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompetition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompetition.Location = new System.Drawing.Point(254, 12);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Size = new System.Drawing.Size(122, 40);
            this.btnCompetition.TabIndex = 8;
            this.btnCompetition.Text = "Competiton";
            this.btnCompetition.UseVisualStyleBackColor = false;
            this.btnCompetition.Click += new System.EventHandler(this.btnCompetition_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(120, 16);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPayment.Size = new System.Drawing.Size(110, 33);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfile.Location = new System.Drawing.Point(522, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(117, 40);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Edit Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // frmMember
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.pnlMain1);
            this.Name = "frmMember";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain1.ResumeLayout(false);
            this.pnlMain1.PerformLayout();
            this.pnlPerformance.ResumeLayout(false);
            this.pnlPerformance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTraning;
        private System.Windows.Forms.Label lblSche;
        private System.Windows.Forms.Panel pnlMain1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCompetition;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListBox lstSchedule;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Panel pnlPerformance;
        private System.Windows.Forms.ListBox lstPerformance;
        private System.Windows.Forms.Label lblPerformance;
    }
}

