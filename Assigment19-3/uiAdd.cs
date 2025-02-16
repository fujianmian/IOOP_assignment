using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Linq;

namespace Assignment19_3
{
    public partial class uiAdd : Form
    {
        public uiAdd()
        {
            InitializeComponent();
            // 刷新DataGridView显示数据
            RefreshDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 检查所有文本框是否都有输入
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(comboLevel.Text) ||
                string.IsNullOrWhiteSpace(txtFe.Text) || string.IsNullOrWhiteSpace(txtStart.Text) || string.IsNullOrWhiteSpace(txtEnd.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please make sure that all the information entered has been entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 如果有任何一个文本框为空，停止保存操作
            }

            // 获取用户输入的数据
            string trainingId = txtID.Text;
            string trainingName = txtName.Text;
            string trainingLevel = comboLevel.Text; // 对应旧表中的 level 列
            string trainingFee = txtFe.Text; // 对应旧表中的 Fee 列
            string timeStart = txtStart.Text;
            string timeEnd = txtEnd.Text;
            string dateString = txtDate.Text;

            // 解析时间和日期字符串
            TimeSpan startTime;
            TimeSpan endTime;
            DateTime date;

            if (!TimeSpan.TryParse(timeStart, out startTime) || !TimeSpan.TryParse(timeEnd, out endTime) ||
                !DateTime.TryParseExact(dateString, "yyyy/M/d", null, System.Globalization.DateTimeStyles.None, out date))
            {
                MessageBox.Show("Please make sure the time and date input format is correct. \nTime Format：12:30\nDate Format：2024/3/13", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 如果时间或日期格式不正确，停止保存操作
            }

            // 检查Training ID是否唯一
            string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;
            string queryCheckId = "SELECT COUNT(*) FROM [TrainingSche] WHERE TrainingId = @TrainingId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand commandCheckId = new SqlCommand(queryCheckId, connection))
                {
                    commandCheckId.Parameters.AddWithValue("@TrainingId", trainingId);
                    connection.Open();
                    int count = (int)commandCheckId.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Training ID already exists, please enter other Training ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // 如果Training ID已存在，停止保存操作
                    }
                }
            }

            // 检查Training Fee是否是数字
            decimal fee;
            if (!decimal.TryParse(trainingFee, out fee))
            {
                MessageBox.Show("Training Fee is only a number！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 如果Training Fee不是数字，停止保存操作
            }

            // 格式化Training Fee，最多两位小数
            string formattedFee = fee.ToString("#.##");

            // 使用参数化查询来避免 SQL 注入攻击
            string query = "INSERT INTO [TrainingSche] (TrainingId, trainingName, level, fees, timeStart, timeEnd, date, location) " +
               "VALUES (@TrainingId, @TrainingName, @TrainingLevel, @TrainingFee, @TimeStart, @TimeEnd, @Date, @Location);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainingId", trainingId);
                    command.Parameters.AddWithValue("@TrainingName", trainingName);
                    command.Parameters.AddWithValue("@TrainingLevel", trainingLevel);
                    command.Parameters.AddWithValue("@TrainingFee", formattedFee);
                    command.Parameters.AddWithValue("@TimeStart", startTime);
                    command.Parameters.AddWithValue("@TimeEnd", endTime);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Location", txtLocation.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // 清空DataGridView的数据源
            dataTrainingShow.DataSource = null;

            // 刷新DataGridView
            RefreshDataGridView();

            // 清空输入控件，以便用户输入下一个资料
            txtID.Text = "";
            txtName.Text = "";
            comboLevel.SelectedIndex = -1;
            txtFe.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
            txtDate.Text = "";
            txtLocation.Text = "";
        }


        private void RefreshDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;
            string query = "SELECT * FROM dbo.TrainingSche";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // 设置 DataGridView 的数据源
                    dataTrainingShow.DataSource = dataTable;
                }
            }
        }

        private void dataTrainingShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 处理单元格内容点击事件
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

            // 定义删除查询
            string query = "DELETE FROM [TrainingSche] WHERE TrainingId = @TrainingId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainingId", trainingIdToDelete);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Successfully deleted Training ID for {trainingIdToDelete}!", "Deleted Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No Training ID for {trainingIdToDelete} record found!", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                RefreshDataGridView();
            }

            // 清空输入框
            txtDelete.Text = "";
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            uiEdit uiEditForm = new uiEdit();
            this.Hide();
            uiEditForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uiCoach uiCoachForm = new uiCoach();
            this.Hide();
            uiCoachForm.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiAdd_Load(object sender, EventArgs e)
        {

        }
    }
}