using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Assignment19_3
{
    internal class User
    {
        private string userID;
        private string password;

        public User(string uI, string pw)
        {
            userID = uI;
            password = pw;
        }

        public string Login(string uI)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select count(*) from UserInfo where userID = @a and password = @b", con);
            cmd.Parameters.AddWithValue("@a", userID);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from UserInfo where userID = @a and password = @b", con);
                cmd2.Parameters.AddWithValue("@a", userID);
                cmd2.Parameters.AddWithValue("@b", password);
                SqlCommand cmd3 = new SqlCommand("Select userName from UserInfo where userID = @a",con);
                cmd3.Parameters.AddWithValue("@a", userID);

                string username = cmd3.ExecuteScalar().ToString();
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "Admin")
                {
                    AdminHome a = new AdminHome(username);
                    a.ShowDialog();
                }
            }
            else
                status = "Incorrect userID/password.";
            con.Close();

            return status;
        }
    }
}
