using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3
{
    internal class Member
    {
        private string name;
        private string password;
        private string gender;
        private string phone;
        private string email;
        private string UserID;
        private string suggestion;


        public Member( string id, string nm, string sg)
        {
            name = nm;
            UserID = id;
            suggestion = sg;
        }

        public Member(string id)
        {
            UserID = id;
        }


        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());


        public string getOriLevel(string id)
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select level from CoachMember where userID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                SqlDataReader r = cmd.ExecuteReader() ;
                while (r.Read())
                {
                    status = r.GetString(0);
                }
            }
            catch (Exception ex)
            {

            }

            con.Close();
            return status;
        }
        public string getLevel(string id)
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select level from CoachMember where userID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            
            try
            {
                string level = cmd.ExecuteScalar().ToString();
                if (level == "A")
                    status = "Beginner";
                else if (level == "B")
                    status = "Intermediate";
                else if (level == "C")
                    status = "Advance";
                else
                    status = null;
            }
            catch (Exception ex)
            {
                
            }
            
            con.Close();
            return status;
        }

        public string getEmail(string id)
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select email from UserInfo where userID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    status = r.GetString(0);

                }
            }
            catch (Exception ex)
            {

            }
           
            con.Close();
            return status;
        }
        
        public static void viewProfile(Member o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserInfo where userID=@id", con);
            cmd.Parameters.AddWithValue("@id", o1.UserID);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                o1.name = r.GetString(1);
                o1.password = r.GetString(2);
                o1.gender = r.GetString(4);
                o1.phone = r.GetString(5);
                o1.email = r.GetString(6);
            }
            con.Close();
        }
        public string updateProfile(string nm, string ps, string g, string ph, string e)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("update UserInfo set userName=@nm,password=@ps,gender=@g,phoneNum=@ph,email=@e where userID=@id", con);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@ps", ps);
            cmd.Parameters.AddWithValue("@g", g);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@e", e);
            cmd.Parameters.AddWithValue("@id", UserID);
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Update Successfully";
                }
                else
                    status = "Unable to Update";
            }
            catch (Exception ex)
            {
                status = "Invalid Input! Please Input the corret fommat.";
            }
           
            con.Close();
            return status;
        }

        public string sendSuggestion()
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Suggestion (userID, userName, suggestion) values (@id, @nm, @sg)", con);
            
            cmd.Parameters.AddWithValue("@id", UserID);
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@sg", suggestion);


            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Send Successfully.";
            }
            else
                status = "Unable Send";
            
          con.Close();
            return status;
            
        }


        public ArrayList getPerformance()
        {
            ArrayList list = new ArrayList();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PerformanceRec where memberID=@id", con);
                cmd.Parameters.AddWithValue("@id", UserID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add("Training Id                        :" + reader.GetString(2));
                    list.Add("Training Name                 :" + reader.GetString(3));
                    list.Add("Technique Rating           :" + reader.GetString(4));
                    list.Add("Flexibility Assessment    :"+ reader.GetString(5));
                    list.Add("Tactical Evaluation          :" + reader.GetString(6));

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return list;
        }

    }


}
