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
using System.Xml.Linq;

namespace Assignment19_3
{
    public partial class uiSendRecomm : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;

        public uiSendRecomm()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [dbo].[RecommendedMemb]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // 设置 DataGridView 的数据源
                        dataViewRecomme.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查所有文本框是否都有输入
                if (string.IsNullOrWhiteSpace(txtMember.Text) || string.IsNullOrWhiteSpace(txtCoach.Text) ||
                    string.IsNullOrWhiteSpace(txtCompetition.Text))
                {
                    MessageBox.Show("Please make sure that all the information entered has been entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // 如果有任何一个文本框为空，停止保存操作
                }

                // 获取用户输入的数据
                string memberID = txtMember.Text;
                string coachID = txtCoach.Text;
                string competitionID = txtCompetition.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 插入数据的 SQL 查询
                    string query = "INSERT INTO [dbo].[RecommendedMemb] (memberID, coachID, competitionID) " +
                                   "VALUES (@MemberID, @CoachID, @CompetitionID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@CoachID", coachID);
                        command.Parameters.AddWithValue("@CompetitionID", competitionID);

                        // 执行命令
                        int rowsAffected = command.ExecuteNonQuery();

                        // 根据受影响的行数显示消息
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 添加成功后清空输入框
                            txtMember.Text = "";
                            txtCoach.Text = "";
                            txtCompetition.Text = "";

                            // 刷新 DataGridView
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查输入的 Member ID 是否为空
                if (string.IsNullOrWhiteSpace(txtDelete.Text))
                {
                    MessageBox.Show("Please enter the Member ID you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 获取用户输入的 Member ID
                string memberIDToDelete = txtDelete.Text;

                // 使用参数化查询来避免 SQL 注入攻击
                string query = "DELETE FROM RecommendedMemb WHERE memberID = @memberID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberID", memberIDToDelete);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Successfully deleted Member ID {memberIDToDelete}!", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No record found for Member ID {memberIDToDelete}!", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // 删除操作完成后刷新 DataGridView
                RefreshDataGridView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 清空输入框
            txtDelete.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uiCoach uiCoachForm = new uiCoach();
            this.Hide();
            uiCoachForm.Show();
        }

        private void uiSendRecomm_Load(object sender, EventArgs e)
        {

        }

        private void dataViewRecomme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
