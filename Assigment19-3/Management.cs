using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3
{
    internal class Management
    {
        private string userID;
        private string userName;
        private string password;
        private string role;
        private string gender;
        private string phoneNum;
        private string email;
        private string level;
        private string salary;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string Level { get => level; set => level = value; }
        public string Salary { get => salary; set => salary = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Role { get => role; set => role = value; }

        //this is for manager add
        public Management(string uI, string uN, string pw, string g, string pN, string e)
        {
            userID = uI;
            userName = uN;
            password = pw;
            gender = g;
            phoneNum = pN;
            email = e;
        }

        //this is for coach add 
        public Management(string uI, string uN, string pw, string g, string pN, string e, string l, string s)
        {
            userID = uI;
            userName = uN;
            password = pw;
            gender = g;
            phoneNum = pN;
            email = e;
            level = l;
            salary = s;
        }

        //this is for member add
        public Management(string uI, string uN, string pw, string g, string pN, string e, string l)
        {
            userID = uI;
            userName = uN;
            password = pw;
            gender = g;
            phoneNum = pN;
            email = e;
            level = l;
        }

        public Management(string uI)
        {
            userID = uI;
        }

        public Management()
        {
            
        }


        public string addManager()
        {
            string status;
            if (checkBlankInput(userID))
            {
                status = "Please enter at least an userID to add.";
                return status;
            }
            con.Open();
            if (checkReplication() == "This userID has been used.")
            {
                status = "This userID has been used.";
                con.Close();
                return status;
            }

            SqlCommand cmd = new SqlCommand("insert into UserInfo(userID, userName, password, role, gender, phoneNum, email) values(@uI, @uN, @pw, 'Manager', @g, @pN, @e)", con);
            cmd.Parameters.AddWithValue("@uI", userID);
            cmd.Parameters.AddWithValue("@uN", userName);
            cmd.Parameters.AddWithValue("@pw", password);
            cmd.Parameters.AddWithValue("@g", gender);
            cmd.Parameters.AddWithValue("@pN", phoneNum);
            cmd.Parameters.AddWithValue("@e", email);
            
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Add successfully";
            }
            else
                status = "Add unsuccessfully";

            con.Close();
            return status;
        }

        public string addCoach()
        {
            string status;
            if (checkBlankInput(userID))
            {
                status = "Please enter at least an userID to add.";
                return status;
            }
            con.Open() ;
            if (checkReplication() == "This userID has been used.")
            {
                status = "This userID has been used.";
                con.Close();
                return status;
            }

            SqlCommand cmd = new SqlCommand("insert into UserInfo(userID, userName, password, role, gender, phoneNum, email) values(@uI, @uN, @pw, 'Coach', @g, @pN, @e)", con);
            SqlCommand cmd3 = new SqlCommand("insert into CoachMember(userID, userName, level) values(@uI,@uN,@l)", con);
            SqlCommand cmd4 = new SqlCommand("insert into CaochSalary(userId, userName, Level, salary) values(@uI,@uN,@l,@s)", con);
            cmd.Parameters.AddWithValue("@uI", userID);
            cmd.Parameters.AddWithValue("@uN", userName);
            cmd.Parameters.AddWithValue("@pw", password);
            cmd.Parameters.AddWithValue("@g", gender);
            cmd.Parameters.AddWithValue("@pN", phoneNum);
            cmd.Parameters.AddWithValue("@e", email);
            cmd3.Parameters.AddWithValue("@uI", userID);
            cmd3.Parameters.AddWithValue("@uN", userName);
            cmd3.Parameters.AddWithValue("@l", level);
            cmd4.Parameters.AddWithValue("@uI", userID);
            cmd4.Parameters.AddWithValue("@uN", userName);
            cmd4.Parameters.AddWithValue("@l", level);
            cmd4.Parameters.AddWithValue("@s", salary);

            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Add successfully";
            }
            else
                status = "Add unsuccessfully";

            con.Close();
            return status;

        }

        public string addMember()
        {
            string status;
            if (checkBlankInput(userID))
            {
                status = "Please enter at least an userID to add.";
                return status;
            }
            con.Open();
            if (checkReplication() == "This userID has been used.")
            {
                status = "This userID has been used.";
                con.Close();
                return status;
            }
            
            SqlCommand cmd = new SqlCommand("insert into UserInfo(userID, userName, password, role, gender, phoneNum, email) values(@uI, @uN, @pw, 'Member', @g, @pN, @e)", con);
            SqlCommand cmd3 = new SqlCommand("insert into CoachMember(userID, userName, level) values(@uI,@uN,@l)", con);
            cmd.Parameters.AddWithValue("@uI", userID);
            cmd.Parameters.AddWithValue("@uN", userName);
            cmd.Parameters.AddWithValue("@pw", password);
            cmd.Parameters.AddWithValue("@g", gender);
            cmd.Parameters.AddWithValue("@pN", phoneNum);
            cmd.Parameters.AddWithValue("@e", email);
            cmd3.Parameters.AddWithValue("@uI", userID);
            cmd3.Parameters.AddWithValue("@uN", userName);
            cmd3.Parameters.AddWithValue("@l", level);

            cmd3.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Add successfully";
            }
            else
                status = "Add unsuccessfully";
            
            con.Close();
            return status;
        }

        //to check if there is a replicated userID entered.
        public string checkReplication()
        {
            string status = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from UserInfo where userID = @uI", con);
                cmd.Parameters.AddWithValue("uI", userID);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    status = "This userID has been used.";
                }

            }
            return status;
        }

        public bool checkBlankInput(string input)
        {
            return string.IsNullOrEmpty(input); 
        }

        public void checkEditUser(string checkID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from UserInfo where userID = @uI", con);
            cmd.Parameters.AddWithValue("@uI", checkID);

            int check = Convert.ToInt32(cmd.ExecuteScalar());
            if (check > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from UserInfo where userID = @uI", con);
                cmd2.Parameters.AddWithValue("@uI", checkID);
                

                string role = cmd2.ExecuteScalar().ToString();
                if (role == "Coach")
                {
                    EditCoachPage z = new EditCoachPage(checkID);
                    z.ShowDialog();
                }
                else if (role == "Member")
                {
                    EditMemberPage y = new EditMemberPage(checkID);
                    y.ShowDialog();
                }
                else
                {
                    EditManagerPage w = new EditManagerPage(checkID);
                    w.ShowDialog();
                }

            }
            else
                MessageBox.Show("User not found.");
            con.Close();
        }

        public static void viewManagerProfile(Management o1)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from UserInfo where userID = @uI", con);
                cmd.Parameters.AddWithValue("uI", o1.userID);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    o1.userID = rd.GetString(0);
                    o1.userName = rd.GetString(1);
                    o1.password = rd.GetString(2);
                    o1.role = rd.GetString(3);
                    o1.gender = rd.GetString(4);
                    o1.phoneNum = rd.GetString(5);
                    o1.email = rd.GetString(6);

                }
            }
        }

        public static void viewCoachProfile(Management o2)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from UserInfo where userID = @uI", con);
                cmd.Parameters.AddWithValue("uI", o2.userID);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    o2.userID = rd.GetString(0);
                    o2.userName = rd.GetString(1);
                    o2.password = rd.GetString(2);
                    o2.role = rd.GetString(3);
                    o2.gender = rd.GetString(4);
                    o2.phoneNum = rd.GetString(5);
                    o2.email = rd.GetString(6);
                }
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Select level from CoachMember where userID = @uI", con);
                cmd2.Parameters.AddWithValue("uI", o2.userID);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    o2.level = rd2.GetString(0);
                }
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Select salary from CoachSalary where userID = @uI", con);
                cmd3.Parameters.AddWithValue("uI", o2.userID);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                while (rd3.Read())
                {
                    o2.salary = rd3.GetString(0);
                }

            }
            
        }

        public static void viewMemberProfile(Management o3)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from UserInfo where userID = @uI", con);
                cmd.Parameters.AddWithValue("uI", o3.userID);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    o3.userID = rd.GetString(0);
                    o3.userName = rd.GetString(1);
                    o3.password = rd.GetString(2);
                    o3.role = rd.GetString(3);
                    o3.gender = rd.GetString(4);
                    o3.phoneNum = rd.GetString(5);
                    o3.email = rd.GetString(6);
                }
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                con.Open();
                SqlCommand cmd5 = new SqlCommand("Select level from CoachMember where userID = @uI", con);
                cmd5.Parameters.AddWithValue("uI", o3.userID);
                SqlDataReader rd4 = cmd5.ExecuteReader();
                while (rd4.Read())
                {
                    o3.level = rd4.GetString(0);
                }
            }
        }

        public string editManager(string uN,string pw, string g, string pN, string e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                string status;
                con.Open();

                SqlCommand cmd = new SqlCommand("update UserInfo set userName = @uN, password = @pw, gender = @g, phoneNum = @pN, email = @e where userID = @uI", con);
                cmd.Parameters.AddWithValue("@uN", uN);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@g", g);
                cmd.Parameters.AddWithValue("@pN", pN);
                cmd.Parameters.AddWithValue("@e", e);
                cmd.Parameters.AddWithValue("@uI", userID);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    status = "Update Successfully.";
                else
                    status = "Unable to update.";
                con.Close();

                return status;
            }

        }

        public string editMember(string uN, string pw, string g, string pN, string e, string l)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                string status;
                con.Open();

                SqlCommand cmd = new SqlCommand("update UserInfo set userName = @uN, password = @pw, gender = @g, phoneNum = @pN, email = @e where userID = @uI", con);
                cmd.Parameters.AddWithValue("@uN", uN);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@g", g);
                cmd.Parameters.AddWithValue("@pN", pN);
                cmd.Parameters.AddWithValue("@e", e);
                cmd.Parameters.AddWithValue("@uI", userID);

                SqlCommand cmd2 = new SqlCommand("update CoachMember set userName = @uN, level = @l where userID = @uI", con);
                cmd2.Parameters.AddWithValue("@uN", uN);
                cmd2.Parameters.AddWithValue("@l", l);
                cmd2.Parameters.AddWithValue("@uI", userID);

                int j = cmd2.ExecuteNonQuery();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    if (j != 0)
                        status = "Update Successfully.";
                    else
                        status = "Unable to update";
                }
                else
                    status = "Unable to update.";
                con.Close();

                return status;
            }
            

        }

        public string editCoach(string uN, string pw, string g, string pN, string e, string l, string s)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString()))
            {
                string status;
                con.Open();

                SqlCommand cmd = new SqlCommand("update UserInfo set userName = @uN, password = @pw, gender = @g, phoneNum = @pN, email = @e where userID = @uI", con);
                cmd.Parameters.AddWithValue("@uN", uN);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@g", g);
                cmd.Parameters.AddWithValue("@pN", pN);
                cmd.Parameters.AddWithValue("@e", e);
                cmd.Parameters.AddWithValue("@uI", userID);

                SqlCommand cmd2 = new SqlCommand("update CoachMember set userName = @uN, level = @l where userID = @uI", con);
                cmd2.Parameters.AddWithValue("@uN", uN);
                cmd2.Parameters.AddWithValue("@l", l);
                cmd2.Parameters.AddWithValue("@uI", userID);

                SqlCommand cmd3 = new SqlCommand("update CoachSalary set userName = @uN, level = @l, salary = @s where userID = @uI", con);
                cmd3.Parameters.AddWithValue("@uN", uN);
                cmd3.Parameters.AddWithValue("@l", l);
                cmd3.Parameters.AddWithValue("@s", s);
                cmd3.Parameters.AddWithValue("@uI", userID);

                int i = cmd.ExecuteNonQuery();
                int j = cmd2.ExecuteNonQuery();
                int k = cmd3.ExecuteNonQuery();
                if (i != 0)
                {
                    if (j > 0)
                    {
                        if (k > 0)
                        {
                            status = "Update Successfully.";
                        }
                        else
                            status = "Unable to update.";
                    }
                    else
                        status = "Unable to update.";
                }
                else
                    status = "Unable to update.";
                con.Close();

                return status;
            }
        }

    }
}
