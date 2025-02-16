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
using static Assignment19_3.RefreshCompetition;

namespace Assignment19_3
{
    public partial class FindStudentForm : Form
    {
        public FindStudentForm()
        {
            InitializeComponent();

            FindStudentGrid.Columns.Add("userID", "Student Id");
            FindStudentGrid.Columns.Add("userName", "Student Name");


            RefreshCompetition dbSearh = new RefreshCompetition();
            dbSearh.RefreshDataGridS_SearchStudent(FindStudentGrid);
        }

        private void FindStudentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
        {
            String CompetitionID_ToSearch = TxtSearch.Text.ToString();
            if (CompetitionID_ToSearch[0] != 'C' || CompetitionID_ToSearch.Length != 5)
            {
                MessageBox.Show("Please enter a correct Competition ID");
                TxtSearch.Text = string.Empty;
                return;
            }
            else if (CompetitionID_ToSearch[1] != 'A' && CompetitionID_ToSearch[1] != 'B' && CompetitionID_ToSearch[1] != 'C')
            {
                MessageBox.Show("Please enter a correct Competition ID");
                TxtSearch.Text = string.Empty;
                return;
            }
            else if (!char.IsDigit(CompetitionID_ToSearch[2]) ||  !char.IsDigit(CompetitionID_ToSearch[3]) || !char.IsDigit(CompetitionID_ToSearch[4]))
            {
                MessageBox.Show("Please enter a correct Competition ID");
                TxtSearch.Text = string.Empty;
                return;
            }

            RefreshCompetition dbSearh = new RefreshCompetition();
            dbSearh.SearchCompetitionStudent(FindStudentGrid, TxtSearch);

        }

        private void BtnClearSearchStudent_Click(object sender, EventArgs e)
        {
            TxtSearch.Text = string.Empty;
        }

        private void btn_Competition_Click(object sender, EventArgs e)
        {
            CompetitionForm Competition = new CompetitionForm();
            this.Hide();
            Competition.Show();
        }

        private void btn_RecommendedStudent_Click(object sender, EventArgs e)
        {
            AssignStudentForm AssignStudent = new AssignStudentForm();
            this.Hide();
            AssignStudent.Show();
        }

        private void Btn_UpdateResult_Click(object sender, EventArgs e)
        {
            UpdateResultForm updateResult = new UpdateResultForm();
            this.Hide();
            updateResult.Show();
        }

        private void BtnMainPage_Click(object sender, EventArgs e)
        {
            Manager_UI MainPage = new Manager_UI();
            this.Hide();
            MainPage.Show();
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
