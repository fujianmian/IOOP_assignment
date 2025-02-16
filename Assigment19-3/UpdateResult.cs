//using Assignment_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment19_3.RefreshCompetition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment19_3
{
    public partial class UpdateResultForm : Form
    {
        public UpdateResultForm()
        {
            InitializeComponent();

            //set default value to the datagrid view
            dataGridView1.Columns.Add("CompetitionID", "Competition ID");
            dataGridView1.Columns.Add("userID", "Student ID");
            dataGridView1.Columns.Add("Status", "Status");

            //load data to the data grid view
            RecommendStudent dbaction = new RecommendStudent();
            string query_RefreshDataGrid = "Select * from CompetitionMemb";
            dbaction.RefreshDataGrid(dataGridView1, query_RefreshDataGrid);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 获取选定行的每个单元格的值并放入文本框中
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                LblUpdate_CompetitionID.Text = selectedRow.Cells["CompetitionID"].Value.ToString();
                LblUpdate_StudentID.Text = selectedRow.Cells["userID"].Value.ToString();
                RecodComboBox.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }

        private void Btn_RecordCompetitionResult_Click(object sender, EventArgs e)
        {
            String CompetitionID_ToUpdate = LblUpdate_CompetitionID.Text.ToString();
            String StudentID_ToUpdate = LblUpdate_StudentID.Text.ToString();
            String CompetitionStatus_ToUpdate = RecodComboBox.Text.ToString();

            if (!string.IsNullOrEmpty(CompetitionID_ToUpdate) && !string.IsNullOrEmpty(StudentID_ToUpdate))
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    String query = "DELETE FROM CompetitionMemb " +
                        "WHERE CompetitionID = @CompetitionID and MemberID = @MemberID;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", CompetitionID_ToUpdate);
                        cmd.Parameters.AddWithValue("@MemberID", StudentID_ToUpdate);
                        cmd.ExecuteNonQuery();
                    }
                    query = "INSERT INTO CompetitionMemb (CompetitionID, MemberID, Status) VALUES (@CompetitionID, @MemberID, @Status);";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Status", CompetitionStatus_ToUpdate);
                        cmd.Parameters.AddWithValue("@CompetitionID", CompetitionID_ToUpdate);
                        cmd.Parameters.AddWithValue("@MemberID", StudentID_ToUpdate);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a competition and member first.");
            }
            


            //load data to the data grid view
            RecommendStudent dbaction = new RecommendStudent();
            string query_RefreshDataGrid = "Select * from CompetitionMemb";
            dbaction.RefreshDataGrid(dataGridView1, query_RefreshDataGrid);
        }

        private void btn_RecommendedStudent_Click(object sender, EventArgs e)
        {

        }

        private void btn_Competition_Click(object sender, EventArgs e)
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

        private void btn_RecommendedStudent_Click_1(object sender, EventArgs e)
        {
            AssignStudentForm AssignStudent = new AssignStudentForm();
            this.Hide();
            AssignStudent.Show();
        }

        private void Btn_UpdateResult_Click(object sender, EventArgs e)
        {
            Manager_UI MainPage = new Manager_UI();
            this.Hide();
            MainPage.Show();
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
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
