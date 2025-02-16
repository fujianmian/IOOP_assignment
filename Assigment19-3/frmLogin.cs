//using Assigment19_3;
//using Assignment_Manager_v1;
//using Assignmentv2;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment19_3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;

            Login obj1 = new Login(txtName.Text, txtPassword.Text);
            this.Hide();
            stat = obj1.login(txtName.Text);
            if (stat != null)
            {
                this.Show();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(stat, "Error!", buttons, icon);
                txtName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtName.Focus();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next textbox
                txtPassword.Focus();
                // Select all text in the textbox
                // Prevent the key event from being passed on
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Perform button click action
                btnLogin.PerformClick();
                // Prevent the key event from being passed on
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


    }
}