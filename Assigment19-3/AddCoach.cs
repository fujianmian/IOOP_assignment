﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3
{
    public partial class AddCoach : Form
    {
        public AddCoach()
        {
            InitializeComponent();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            Management coach1 = new Management(txtUserID.Text, txtUsername.Text, txtPassword.Text, txtGender.Text, txtPhoneNum.Text, txtEmail.Text, txtLevel.Text, txtSalary.Text);
            MessageBox.Show(coach1.addCoach());
        }
    }
}
