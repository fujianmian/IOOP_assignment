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

namespace Assignment19_3
{
    public partial class ViewData : Form
    {

        public ViewData()
        {
            InitializeComponent();
        }

        private void RefreshSuggestionDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    string query = "SELECT * FROM [dbo].[Suggestion]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCoachSalaryDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    string query = "SELECT * FROM [dbo].[CaochSalary]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMemberAndCoachDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    string query = "SELECT * FROM [dbo].[CoachMember]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCompetitionDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
                {
                    string query = "SELECT * FROM [dbo].[CompetitionMemb]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        dataView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewSuggestion_Click(object sender, EventArgs e)
        {
            RefreshSuggestionDataGridView();
        }

        private void btnViewCoachSalary_Click(object sender, EventArgs e)
        {
            RefreshCoachSalaryDataGridView();
        }

        private void btnViewMemberAndCoach_Click(object sender, EventArgs e)
        {
            RefreshMemberAndCoachDataGridView();
        }

        private void ViewCompetition_Click(object sender, EventArgs e)
        {
            RefreshCompetitionDataGridView();
        }

        private void ViewUserInfo_Click(object sender, EventArgs e)
        {
            RefreshUserInfoDataGridView();
        }
    }
}
