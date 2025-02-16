using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment19_3
{
    public partial class uiEdit : Form
    {
        public uiEdit()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 检查是否至少有一个文本框输入了内容
            if (string.IsNullOrWhiteSpace(txtName.Text) &&
                string.IsNullOrWhiteSpace(comboLevel.Text) &&
                string.IsNullOrWhiteSpace(txtFe.Text) &&
                string.IsNullOrWhiteSpace(txtStart.Text) &&
                string.IsNullOrWhiteSpace(txtEnd.Text) &&
                string.IsNullOrWhiteSpace(txtDate.Text) &&
                string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter at least one item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 如果所有文本框都为空，停止保存操作
            }

            // 获取用户输入的数据
            string trainingId = txtID.Text;
            string trainingName = txtName.Text;
            string trainingLevel = comboLevel.Text;
            string trainingFe = txtFe.Text;
            string timeStart = txtStart.Text;
            string timeEnd = txtEnd.Text;
            string dateString = txtDate.Text;

            // 检查Training ID是否为空
            if (string.IsNullOrWhiteSpace(trainingId))
            {
                MessageBox.Show("Please enter the training ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 停止保存操作
            }

            // 检查Training ID是否唯一
            string connectionString = ConfigurationManager.ConnectionStrings["myCs"].ConnectionString;
            string queryCheckId = "SELECT COUNT(*) FROM TrainingSche WHERE TrainingId = @TrainingId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand commandCheckId = new SqlCommand(queryCheckId, connection))
                {
                    commandCheckId.Parameters.AddWithValue("@TrainingId", trainingId);
                    connection.Open();
                    int count = (int)commandCheckId.ExecuteScalar();
                    if (count > 0)
                    {
                        // 如果Training ID已存在，执行更新操作

                        // 构建更新查询字符串
                        string updateQuery = "UPDATE TrainingSche SET ";
                        if (!string.IsNullOrWhiteSpace(trainingName))
                            updateQuery += "trainingName = @TrainingName, ";
                        if (!string.IsNullOrWhiteSpace(trainingLevel))
                            updateQuery += "level = @TrainingLevel, ";
                        if (!string.IsNullOrWhiteSpace(trainingFe))
                            updateQuery += "fees = @TrainingFee, ";
                        if (!string.IsNullOrWhiteSpace(timeStart))
                            updateQuery += "timeStart = @TimeStart, ";
                        if (!string.IsNullOrWhiteSpace(timeEnd))
                            updateQuery += "timeEnd = @TimeEnd, ";
                        if (!string.IsNullOrWhiteSpace(dateString))
                            updateQuery += "date = @Date, ";
                        if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                            updateQuery += "location = @Location, ";

                        // 移除最后一个逗号和空格
                        updateQuery = updateQuery.TrimEnd(',', ' ');

                        updateQuery += " WHERE TrainingId = @TrainingId";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@TrainingId", trainingId);
                            if (!string.IsNullOrWhiteSpace(trainingName))
                                updateCommand.Parameters.AddWithValue("@TrainingName", trainingName);
                            if (!string.IsNullOrWhiteSpace(trainingLevel))
                                updateCommand.Parameters.AddWithValue("@TrainingLevel", trainingLevel);
                            if (!string.IsNullOrWhiteSpace(trainingFe))
                            {
                                // 检查Training Fee是否是数字
                                decimal fee;
                                if (!decimal.TryParse(trainingFe, out fee))
                                {
                                    MessageBox.Show("Training Fee must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // 如果Training Fee不是数字，停止保存操作
                                }
                                else
                                {
                                    // 格式化Training Fee为最多两位小数
                                    string formattedFee = fee.ToString("#.##");
                                    updateCommand.Parameters.AddWithValue("@TrainingFee", formattedFee);
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(timeStart))
                            {
                                TimeSpan startTime;
                                if (!TimeSpan.TryParse(timeStart, out startTime))
                                {
                                    MessageBox.Show("Please make sure the time input format is correct.\nTime Format: 12:30", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // 如果时间格式不正确，停止保存操作
                                }
                                else
                                {
                                    updateCommand.Parameters.AddWithValue("@TimeStart", startTime);
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(timeEnd))
                            {
                                TimeSpan endTime;
                                if (!TimeSpan.TryParse(timeEnd, out endTime))
                                {
                                    MessageBox.Show("Please make sure the time input format is correct.\nTime Format: 12:30", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // 如果时间格式不正确，停止保存操作
                                }
                                else
                                {
                                    updateCommand.Parameters.AddWithValue("@TimeEnd", endTime);
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(dateString))
                            {
                                DateTime date;
                                if (!DateTime.TryParseExact(dateString, "yyyy/M/d", null, System.Globalization.DateTimeStyles.None, out date))
                                {
                                    MessageBox.Show("Please make sure the date is correctly formatted.\nDate Format: 2024/3/13", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // 如果日期格式不正确，停止保存操作
                                }
                                else
                                {
                                    updateCommand.Parameters.AddWithValue("@Date", date);
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                                updateCommand.Parameters.AddWithValue("@Location", txtLocation.Text);

                            updateCommand.ExecuteNonQuery();
                        }

                        // 清空DataGridView的数据源
                        dataTraining.DataSource = null;

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

                        MessageBox.Show("Updated information!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // 停止保存操作
                    }
                    else
                    {
                        MessageBox.Show("Invalid Training ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // 停止保存操作
                    }
                }
            }
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
                    dataTraining.DataSource = dataTable;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uiAdd uiAddForm = new uiAdd();
            this.Hide();
            uiAddForm.Show();
        }

        private void dataTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}