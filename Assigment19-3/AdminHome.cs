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
    public partial class AdminHome : Form
    {
        public static string name;
        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Hello, {name}";
            RefreshData();
        }

        private void RefreshData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(userID) from UserInfo where role = 'Member'", con);
            int NumMember = Convert.ToInt32(cmd.ExecuteScalar());
            lblMemberCount.Text = $"The total number of member is {NumMember}.";
            SqlCommand cmd2 = new SqlCommand("select count(userID) from UserInfo where role = 'Coach'", con);
            int NumCoach = Convert.ToInt32(cmd2.ExecuteScalar());
            lblCoachCount.Text = $"The total number of coach is {NumCoach}.";
            SqlCommand cmd3 = new SqlCommand("select count(userID) from UserInfo where role = 'Manager'", con);
            int NumManager = Convert.ToInt32(cmd3.ExecuteScalar());
            lblManagerCount.Text = $"The total number of manager is {NumManager}.";
            con.Close();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ManagementPage maP = new ManagementPage();
            maP.ShowDialog();
            RefreshData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewData viewData = new ViewData();
            viewData.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLoginForm = new frmLogin();
            frmLoginForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmLoginForm.Show();
        }
    }
}
