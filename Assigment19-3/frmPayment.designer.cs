namespace Assignment19_3
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(281, 65);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(156, 46);
            this.lblBill.TabIndex = 17;
            this.lblBill.Text = "Bill List";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(87, 331);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(287, 32);
            this.lblFee.TabIndex = 18;
            this.lblFee.Text = "Total Training Fees:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(380, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(2, 34);
            this.lblTotal.TabIndex = 19;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(380, 405);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(99, 41);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvBillList
            // 
            this.dgvBillList.AllowUserToAddRows = false;
            this.dgvBillList.AllowUserToDeleteRows = false;
            this.dgvBillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBillList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillList.Location = new System.Drawing.Point(126, 150);
            this.dgvBillList.Name = "dgvBillList";
            this.dgvBillList.ReadOnly = true;
            this.dgvBillList.RowHeadersWidth = 51;
            this.dgvBillList.RowTemplate.Height = 24;
            this.dgvBillList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBillList.Size = new System.Drawing.Size(524, 150);
            this.dgvBillList.TabIndex = 16;
            // 
            // frmPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.dgvBillList);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvBillList;
    }
}