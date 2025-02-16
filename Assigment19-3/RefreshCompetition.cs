using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment19_3
{
    public class RefreshCompetition
    {
        public void RefreshDataGridS_SearchStudent(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            //List<object[]> RecommendStudentGridData = new List<object[]>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                string query_RefreshDataGrid = "Select userID, userName From UserInfo where exists (Select MemberID from CompetitionMemb where CompetitionMemb.MemberID = UserInfo.userID)";
                using (SqlCommand cmd = new SqlCommand(query_RefreshDataGrid, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];

                            // 逐个单元格读取数据并添加到数组中
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData[i] = reader[i];
                            }

                            // 将行添加到 DataGridView 中
                            dataGridView.Rows.Add(rowData);
                        }
                    }
                }
            }
        }
        public void SearchCompetitionStudent(DataGridView dataGridView, TextBox TxtSearch)
        {
            dataGridView.Rows.Clear();
            string CompetitionID_ToSearch = TxtSearch.Text.ToString();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                string query_RefreshDataGrid = @"
                    SELECT ui.userID, ui.userName 
                    FROM UserInfo ui
                    JOIN CompetitionMemb cm ON cm.MemberID = ui.userID
                    JOIN Competition c ON c.CompetitionID = cm.CompetitionID
                    WHERE cm.CompetitionID = @competitionID";
                using (SqlCommand cmd = new SqlCommand(query_RefreshDataGrid, con))
                {
                    cmd.Parameters.AddWithValue("@competitionID", CompetitionID_ToSearch);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];

                            // read the data
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData[i] = reader[i];
                            }

                            dataGridView.Rows.Add(rowData);
                        }
                    }
                }
            }
        }


        public class RecommendStudent
        {
            public void RefreshDataGrid(DataGridView dataGridView, String query)
            {
                dataGridView.Rows.Clear();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object[] rowData = new object[reader.FieldCount];

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowData[i] = reader[i];
                                }

                                dataGridView.Rows.Add(rowData);
                            }
                        }
                    }

                }
            }
            public void AssignStudent(Label LblStudentID, Label LblCompetitionID)
            {
                string MemberID_ToDelete = LblStudentID.Text.ToString();
                string CompetitionID_ToDelete = LblCompetitionID.Text.ToString();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    string query = "Insert into CompetitionMemb values(@competitionID, @userID, 'havent started');";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userID", MemberID_ToDelete);
                        cmd.Parameters.AddWithValue("@competitionID", CompetitionID_ToDelete);
                        cmd.ExecuteNonQuery();
                    }
                }
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    string query = "DELETE FROM RecommendedMemb WHERE MemberID = @userID and CompetitionID = @competitionID;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userID", MemberID_ToDelete);
                        cmd.Parameters.AddWithValue("@competitionID", CompetitionID_ToDelete);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public class DatabaseHelper
        {
            public void FillDataGridViewWithData(DataGridView dataGridView, string query)
            {
                dataGridView.Rows.Clear();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DataGridViewRow row = new DataGridViewRow();

                                // 逐个单元格读取数据并添加到行中
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                                    cell.Value = reader[i];
                                    row.Cells.Add(cell);
                                }
                                dataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
            }

            public void AddDataIntoDatabase(List<CompetitionInfo> CompetitionInfoList)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Competition WHERE CompetitionID = @CompetitionID;";
                    string query = "INSERT INTO Competition (CompetitionID, CompetitionName, Date, Time, Location) VALUES (@CompetitionID, @CompetitionName, @Date, @Time, @Location);";

                    foreach (var data in CompetitionInfoList)
                    {
                        // 检查是否已经存在相同的 CompetitionID
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@CompetitionID", data.CompetitionID);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // 如果已经存在相同的 CompetitionID，则跳过本次插入
                                continue;
                            }
                        }

                        // 插入新的竞赛信息
                        using (SqlCommand insertCmd = new SqlCommand(query, con))
                        {
                            insertCmd.Parameters.Clear();
                            insertCmd.Parameters.AddWithValue("@CompetitionID", data.CompetitionID);
                            insertCmd.Parameters.AddWithValue("@CompetitionName", data.CompetitionName);
                            insertCmd.Parameters.AddWithValue("@Date", data.Date);
                            insertCmd.Parameters.AddWithValue("@Time", data.Time);
                            insertCmd.Parameters.AddWithValue("@Location", data.Location);
                            insertCmd.ExecuteNonQuery();
                        }

                    }
                }
            }

            public void DeleteCompetitionRow(TextBox lblCompetitionID)
            {
                string CompetitionID_ToDelete = lblCompetitionID.Text.ToString();


                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    string query = "DELETE FROM Competition WHERE CompetitionID = @CompetitionID;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", CompetitionID_ToDelete);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            public bool IsCompetitionIDExists(string competitionID)
            {
                bool isExists = false;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Competition WHERE CompetitionID = @CompetitionID;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionID);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            isExists = true;
                        }
                    }
                }

                // 返回竞赛 ID 是否存在的布尔值
                return isExists;
            }

            public List<CompetitionInfo> AddCompetitionToList(TextBox lblCompetitionID, TextBox lblCompetitionName,
            DateTimePicker dateCompetition, TextBox txtTime, TextBox txtLocation,
            DataGridView LstCompetition)
            {
                List<CompetitionInfo> CompetitionInfoList = new List<CompetitionInfo>();
                String CompetitionID = lblCompetitionID.Text.ToString();
                DatabaseHelper dbHelper = new DatabaseHelper();

                bool AddCompetition_status = true;

                // Check CompetitionID format
                bool isNumeric = true;
                if (CompetitionID.Length == 5)
                {
                    try { int ThirdDigit = int.Parse(CompetitionID[2].ToString()); }
                    catch (FormatException)
                    { isNumeric = false; }
                    try { int ThirdDigit = int.Parse(CompetitionID[3].ToString()); }
                    catch (FormatException)
                    { isNumeric = false; }
                    try { int ThirdDigit = int.Parse(CompetitionID[4].ToString()); }
                    catch (FormatException)
                    { isNumeric = false; }
                }

                if (!(CompetitionID.Length == 5 && isNumeric && CompetitionID[0] == 'C' && (CompetitionID[1] == 'A' || CompetitionID[1] == 'B' || CompetitionID[1] == 'C')))
                {
                    CompetitionID = null;
                    lblCompetitionID.Text = "";
                    AddCompetition_status = false;
                    return CompetitionInfoList;
                }

                // Check CompetitionName
                String CompetitionName = lblCompetitionName.Text.ToString();

                // Check CompetitionDate
                DateTime CompetitionDate = dateCompetition.Value;

                // Check Time
                String Time = txtTime.Text.ToString();
                TimeSpan resultTimeSpan;
                bool Timesuccess = TimeSpan.TryParse(Time, out resultTimeSpan);
                if (!Timesuccess)
                {
                    return CompetitionInfoList;
                }

                // Get CompetitionLocation
                string CompetitionLocation = txtLocation.Text.ToString();

                // Create CompetitionInfo object and add to the list
                CompetitionInfo competitionInfo = new CompetitionInfo(CompetitionID, CompetitionName, CompetitionDate, resultTimeSpan, CompetitionLocation);
                CompetitionInfoList.Add(competitionInfo);

                // Add to DataGridView if the competition status is valid
                if (AddCompetition_status == true)
                {
                    LstCompetition.Rows.Add(CompetitionID, CompetitionName, CompetitionDate, resultTimeSpan, CompetitionLocation);
                }
                return CompetitionInfoList;
            }

        }
    }

    public class CompetitionInfo
    {
        public string CompetitionID { get; set; }
        public string CompetitionName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }

        // for future use




        public CompetitionInfo(string competitionID, string competitionName, DateTime date, TimeSpan time, string location)
        {
            CompetitionID = competitionID;
            CompetitionName = competitionName;
            Date = date;
            Time = time;
            Location = location;

        }
    }
}

