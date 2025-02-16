using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment19_3
{
    internal class Login
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

        private string username;
        private string password;

        public Login(string un, string p)
        {
            username = un;
            password = p;
        }




        public string login(string nm)
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count (*) from UserInfo where username=@un and password=@ps", con);
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@ps", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {

                SqlCommand cmd2 = new SqlCommand("select role from UserInfo where username=@un and password=@ps", con);
                cmd2.Parameters.AddWithValue("@un", username);
                cmd2.Parameters.AddWithValue("@ps", password);

                string userRole = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("select userID from UserInfo where username=@un and password=@ps", con);
                cmd3.Parameters.AddWithValue("@un", username);
                cmd3.Parameters.AddWithValue("@ps", password);

                string ID = cmd3.ExecuteScalar().ToString();


                if (userRole == "Member")
                {

                    frmMember a = new frmMember(nm,ID);
                    a.ShowDialog();
                    
                }
                else if (userRole == "Coach")
                {
                    uiCoach s = new uiCoach();
                    s.ShowDialog();
                }
                else if (userRole == "Manager")
                {
                    Manager_UI s = new Manager_UI();
                    s.ShowDialog();
                }
                else if (userRole == "Admin")
                {
                    AdminHome s = new AdminHome();
                    s.ShowDialog();
                }

            }
            else
                status = "Incorrect Username or Password";
            con.Close();

            return status;
        }



    }
}
