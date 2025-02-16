//using Assignment_1;
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
    public partial class Manager_UI : Form
    {
        public Manager_UI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignStudentForm AssignStudent = new AssignStudentForm();
            this.Hide();
            AssignStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompetitionForm Competition = new CompetitionForm();
            this.Hide();
            Competition.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            FindStudentForm FindStudent = new FindStudentForm();
            this.Hide();
            FindStudent.Show();
        }

        private void Btn_UpdateResult_Click(object sender, EventArgs e)
        {
            UpdateResultForm updateResult = new UpdateResultForm();
            this.Hide();
            updateResult.Show();
        }

        private void Manager_UI_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLoginForm = new frmLogin();
            frmLoginForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmLoginForm.Show();
        }
    }
}
