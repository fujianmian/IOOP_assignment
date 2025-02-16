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
    public partial class EditMemberPage : Form
    {
        public static string checkID;
        public EditMemberPage()
        {
            InitializeComponent();
        }
        
        public EditMemberPage(string uI)
        {
            InitializeComponent();
            checkID = uI;
        }

        private void EditMemberPage_Load(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            Management.viewMemberProfile(details);

            txtUserID.Text = details.UserID;
            txtUsername.Text = details.UserName;
            txtPassword.Text = details.Password;
            txtRole.Text = details.Role;
            txtGender.Text = details.Gender;
            txtPhoneNum.Text = details.PhoneNum;
            txtEmail.Text = details.Email;
            txtLevel.Text = details.Level;
        }

        private void btnConfrimEditMember_Click(object sender, EventArgs e)
        {
            Management details = new Management(checkID);
            MessageBox.Show(details.editMember(txtUsername.Text, txtPassword.Text, txtGender.Text, txtPhoneNum.Text, txtEmail.Text, txtLevel.Text));
        }
    }
}
