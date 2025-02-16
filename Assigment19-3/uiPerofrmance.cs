using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment19_3
{
    public partial class uiPerformance : Form
    {
        // 数据库连接字符串
        string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;

        public uiPerformance()
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
                    string query = "SELECT * FROM [dbo].[PerformanceRec]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // 设置 DataGridView 的数据源
                        dataPerformance.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查所有文本框是否都有输入
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(comboRating.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(comboAssessment.Text) ||
                    string.IsNullOrWhiteSpace(txtTraining.Text) || string.IsNullOrWhiteSpace(comboEvaluation.Text) ||
                    string.IsNullOrWhiteSpace(txtTrainName.Text))
                {
                    MessageBox.Show("Please make sure that all the information entered has been entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // 如果有任何一个文本框为空，停止保存操作
                }

                // 验证评分是否为有效整数
                if (!int.TryParse(comboRating.Text, out int techniqueRating) ||
                    !int.TryParse(comboAssessment.Text, out int flexibilityAssessment) ||
                    !int.TryParse(comboEvaluation.Text, out int tacticalEvaluation))
                {
                    MessageBox.Show("Please enter valid integer values for ratings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 获取用户输入的数据
                string memberID = txtUser.Text;
                string memberName = txtName.Text;
                string trainingID = txtTraining.Text;
                string trainName = txtTrainName.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 插入数据的 SQL 查询
                    string query = "INSERT INTO [dbo].[PerformanceRec] (memberID, memberName, trainingID, trainName, techniqueRating, flexibilityAssessment, tacticalEvaluation) " +
                                   "VALUES (@MemberID, @MemberName, @TrainingID, @TrainName, @TechniqueRating, @FlexibilityAssessment, @TacticalEvaluation)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@MemberName", memberName);
                        command.Parameters.AddWithValue("@TrainingID", trainingID);
                        command.Parameters.AddWithValue("@TrainName", trainName);
                        command.Parameters.AddWithValue("@TechniqueRating", techniqueRating);
                        command.Parameters.AddWithValue("@FlexibilityAssessment", flexibilityAssessment);
                        command.Parameters.AddWithValue("@TacticalEvaluation", tacticalEvaluation);

                        // 执行命令
                        int rowsAffected = command.ExecuteNonQuery();

                        // 根据受影响的行数显示消息
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshDataGridView();

                            // 添加成功后清空输入框
                            txtUser.Text = "";
                            txtName.Text = "";
                            txtTraining.Text = "";
                            txtTrainName.Text = "";
                            comboRating.SelectedIndex = -1;
                            comboAssessment.SelectedIndex = -1;
                            comboEvaluation.SelectedIndex = -1;
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
            // 检查输入的 Training ID 是否为空
            if (string.IsNullOrWhiteSpace(txtDelete.Text))
            {
                MessageBox.Show("Please enter the Training ID you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取用户输入的 Training ID
            string trainingIdToDelete = txtDelete.Text;

            // 使用参数化查询来避免 SQL 注入攻击
            string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;
            string query = "DELETE FROM PerformanceRec WHERE memberID = @memberID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@memberID", trainingIdToDelete);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Successfully deleted Member ID for {trainingIdToDelete}!", "Deleted Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No Member ID for {trainingIdToDelete} record found!", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                RefreshDataGridView();
            }

            // 清空输入框
            txtDelete.Text = "";
        }

        private void dataPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uiCoach uiCoachForm = new uiCoach();
            this.Hide();
            uiCoachForm.Show();
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
