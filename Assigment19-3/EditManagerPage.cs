using System;
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
    public partial class EditManagerPage : Form
    {
        public static string checkID;
        public EditManagerPage()
        {
            InitializeComponent();
        }

        public EditManagerPage(string uI)
        {
            InitializeComponent();
            checkID = uI;
        }

        private void EditManagerPage_Load(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            Management.viewManagerProfile(details);

            txtUserID.Text = details.UserID;
            txtUsername.Text = details.UserName;
            txtPassword.Text = details.Password;
            txtRole.Text = details.Role;
            txtGender.Text = details.Gender;
            txtPhoneNum.Text = details.PhoneNum;
            txtEmail.Text = details.Email;
        }

        private void btnConfrimEditM_Click(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            MessageBox.Show(details.editManager(txtUsername.Text, txtPassword.Text, txtGender.Text, txtPhoneNum.Text, txtEmail.Text));
        }
    }
}
