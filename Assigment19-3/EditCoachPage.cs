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
    public partial class EditCoachPage : Form
    {
        public static string checkID;
        public EditCoachPage()
        {
            InitializeComponent();
        }

        public EditCoachPage(string uI)
        {
            InitializeComponent();
            checkID = uI;
        }

        private void EditCoachPage_Load(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            Management.viewCoachProfile(details);

            txtUserID.Text = details.UserID;
            txtUsername.Text = details.UserName;
            txtPassword.Text = details.Password;
            txtRole.Text = details.Role;
            txtGender.Text = details.Gender;
            txtPhoneNum.Text = details.PhoneNum;
            txtEmail.Text = details.Email;
            txtLevel.Text = details.Level;
            txtSalary.Text = details.Salary;
        }

        private void btnConfrimEditC_Click(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            MessageBox.Show(details.editCoach(txtUsername.Text, txtPassword.Text, txtGender.Text, txtPhoneNum.Text, txtEmail.Text,txtLevel.Text,txtSalary.Text));
        }
    }
}
