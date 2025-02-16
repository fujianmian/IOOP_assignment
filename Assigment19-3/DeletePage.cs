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

namespace Assignment19_3
{
    public partial class DeletePage : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());
        public DeletePage()
        {
            InitializeComponent();

        }


        private void RefreshUserInfoDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    string query = "SELECT * FROM [dbo].[UserInfo]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataUserForDelete.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeleteUser.Text))
            {
                MessageBox.Show("Please enter the userID you want to delete!");
                return;
            }

            string userIdToDelete = txtDeleteUser.Text;

            string query = "DELETE FROM UserInfo WHERE userID = @userid";
            string query1 = "SELECT role FROM UserInfo WHERE userID = @userid";
            string query2 = "DELETE FROM CoachSalary WHERE userID = @userid";
            string query3 = "DELETE FROM CoachMember WHERE userID = @userid";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                using (SqlCommand command1 = new SqlCommand(query1, con))
                {
                    command1.Parameters.AddWithValue("userid", userIdToDelete);

                    string role = command1.ExecuteScalar().ToString();

                    if (role == "Coach")
                    {
                        SqlCommand command2 = new SqlCommand(query2, con);
                        command2.Parameters.AddWithValue("userid", userIdToDelete);
                        command2.ExecuteNonQuery();
                        SqlCommand command3 = new SqlCommand(query3, con);
                        command3.Parameters.AddWithValue("userid", userIdToDelete);
                        command3.ExecuteNonQuery();
                    }
                    if (role == "Member")
                    {
                        SqlCommand command4 = new SqlCommand(query3, con);
                        command4.Parameters.AddWithValue("userid", userIdToDelete);
                        command4.ExecuteNonQuery();
                    }
                }
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@userid", userIdToDelete);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Successfully deleted UserID for {userIdToDelete}!");
                    }
                    else
                    {
                        MessageBox.Show($"No UserID {userIdToDelete} is found!");
                    }
                }
                RefreshUserInfoDataGridView();
            }

                txtDeleteUser.Text = "";
        }

        private void DeletePage_Load(object sender, EventArgs e)
        {
            RefreshUserInfoDataGridView();
        }
    }
}
