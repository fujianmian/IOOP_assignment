using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static Assignment19_3.RefreshCompetition;
using System.Collections;
//using Assignment_1;

namespace Assignment19_3
{
    public partial class CompetitionForm : Form
    {

        public CompetitionForm()
        {
            InitializeComponent();


            // 添加 DataGridView 控件的列
            LstCompetition.Columns.Add("CompetitionId", "Competition ID");
            LstCompetition.Columns.Add("CompetitionName", "Competition Name");
            LstCompetition.Columns.Add("Date", "Date");
            LstCompetition.Columns.Add("Time", "Time");
            LstCompetition.Columns.Add("Location", "Location");


            //to initial the datetimepicker
            dateCompetition.Value = new DateTime(2024, 1, 1);
            DatabaseHelper dbHelper = new DatabaseHelper();
            string query = "SELECT * FROM Competition;";
            dbHelper.FillDataGridViewWithData(LstCompetition, query);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Competition_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddCompetition_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblCompetitionID.Text) ||
                string.IsNullOrWhiteSpace(lblCompetitionName.Text) ||
                dateCompetition.Value == null || 
                string.IsNullOrWhiteSpace(txtTime.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text)) 
            {
                MessageBox.Show("Please makesure all data is in the right place.");
                return;
            }
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<CompetitionInfo> CompetitionInfoList = dbHelper.AddCompetitionToList(lblCompetitionID, lblCompetitionName,
             dateCompetition, txtTime, txtLocation, LstCompetition);

            //insert the data into the database
            if (!(CompetitionInfoList.Count == 0))
                dbHelper.AddDataIntoDatabase(CompetitionInfoList);
            //refresh
            string query = "SELECT * FROM Competition;";
            dbHelper.FillDataGridViewWithData(LstCompetition, query);
        }

        private void btn_EditCompetition_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<CompetitionInfo> CompetitionInfoList = dbHelper.AddCompetitionToList(lblCompetitionID, lblCompetitionName,
             dateCompetition, txtTime, txtLocation, LstCompetition);

            //insert the data into the database
            if (!(CompetitionInfoList.Count == 0))
            {
                dbHelper.DeleteCompetitionRow(lblCompetitionID);
                dbHelper.AddDataIntoDatabase(CompetitionInfoList);
            }
                

            //refresh
            string query = "SELECT * FROM Competition;";
            dbHelper.FillDataGridViewWithData(LstCompetition, query);
        }

        private void LstCompetition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 获取选定行的每个单元格的值并放入文本框中
                DataGridViewRow selectedRow = LstCompetition.Rows[e.RowIndex];
                lblCompetitionID.Text = selectedRow.Cells["CompetitionId"].Value.ToString();
                lblCompetitionName.Text = selectedRow.Cells["CompetitionName"].Value.ToString();
                dateCompetition.Value = (DateTime)selectedRow.Cells["Date"].Value;
                txtTime.Text = selectedRow.Cells["Time"].Value.ToString();
                txtLocation.Text = selectedRow.Cells["Location"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCompetitionID.Clear();
            lblCompetitionName.Clear();
            dateCompetition.Value = new DateTime(2024,1,1);
            txtTime.Text = "";
            txtLocation.Text = "";

            //refresh
            DatabaseHelper dbHelper = new DatabaseHelper();
            string query = "SELECT * FROM Competition;";
            dbHelper.FillDataGridViewWithData(LstCompetition, query);
        }
        
        private void btn_DeleteCompetition_Click(object sender, EventArgs e)
        {
            //delete
            string CompetitionID_ToDelete = lblCompetitionID.Text.ToString();
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.DeleteCompetitionRow(lblCompetitionID);
            MessageBox.Show("This competition had been delete");
            //refresh
            string query = "SELECT * FROM Competition;";
            dbHelper.FillDataGridViewWithData(LstCompetition, query);
            //clear textbox
            lblCompetitionID.Clear();
            lblCompetitionName.Clear();
            dateCompetition.Value = new DateTime(2024, 1, 1);
            txtTime.Text = "";
            txtLocation.Text = "";
        }

        private void btn_MainPage_Click(object sender, EventArgs e)
        {
            Manager_UI MainPage = new Manager_UI();
            this.Hide();
            MainPage.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            FindStudentForm FindStudent = new FindStudentForm();
            this.Hide();
            FindStudent.Show();
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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLoginForm = new frmLogin();
            frmLoginForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmLoginForm.Show();
        }
    }
}
