using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3

{
    public partial class frmCompetition : Form
    {
        public frmCompetition()
        {
            InitializeComponent();
        }

        private void frmCompetition_Load(object sender, EventArgs e)
        {
            showCompetition();
            //getWin();
           // getLose();
        }

        private void lblShowWin_Click(object sender, EventArgs e)
        {

        }
        private void getWin()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

            string query = "select count(status) from Competition where status='win'";

            SqlDataAdapter command = new SqlDataAdapter(query, connection);
            connection.Open();

            int result = Convert.ToInt32(command.SelectCommand.ExecuteScalar());
            //lblShowWin.Text = result.ToString();
            connection.Close();


        }
        private void getLose()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

            string query = "select count(status) from Competition where status='lose'";

            SqlDataAdapter command = new SqlDataAdapter(query, connection);
            connection.Open();

            int result = Convert.ToInt32(command.SelectCommand.ExecuteScalar());
            //lblShowLose.Text = result.ToString();
            connection.Close();


        }
        public void showCompetition()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());
            //try
            //{
                string query = "select * from Competition";
                SqlDataAdapter command = new SqlDataAdapter(query, con);

                con.Open();
                DataTable dt = new DataTable();
                command.Fill(dt);
                dgvComprtition.DataSource = dt;
                con.Close();

          //  }
            //catch (Exception ex)
            //{

           // }



        }
    }


}
