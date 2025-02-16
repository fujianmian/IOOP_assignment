using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3
{

    internal class Training
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());


        private string userID, trainName;
        private decimal fees;


        public Training(string ID)
        {
            userID = ID;
        }

        public Training()
        {

        }
        

        public ArrayList getTrainID(string id)
        {
            ArrayList list = new ArrayList();
            try
            { 
                con.Open();
                SqlCommand cmd = new SqlCommand("select trainingID from MemberEnroll where userID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
            
            
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            con.Close();
            return list;
        }

        public ArrayList getSche(string id)
        {
            ArrayList list = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TrainingSche where trainingID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add("Training Name :" + "\t" + reader.GetString(1));
                    list.Add("Start Time        :" + "\t" + reader.GetTimeSpan(3));
                    list.Add("End Time         :" + "\t" + reader.GetTimeSpan(4));
                    list.Add("Date                 :" + "\t" + reader.GetDateTime(5));
                    list.Add("Location           :" + "\t" + reader.GetString(6));
                    list.Add("\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return list;
        }

        public ArrayList getEnrollList(string lv)
        {
            ArrayList list = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select trainingID from TrainingSche where level=@lv", con);
            cmd.Parameters.AddWithValue("@lv", lv);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            con.Close();
            return list;

            
        }
        public string enroll(string uid,string nm, string tid)
        {
            string result = null;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into MemberEnroll(userID,userName,trainingID) values(@uid,@nm,@tid) ", con);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@nm", nm);
                cmd.Parameters.AddWithValue("@tid", tid);
                int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (i != 0)
                    result = "Enroll Succesful!";
            }
            catch
            {
                result = "You have already enroll the training.";
            }
            con.Close();
            return result;

        }
        public void updateFee(string tid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select trainingName, fees from TrainingSche where trainingID=@tid",con);
            cmd.Parameters.AddWithValue("@tid", tid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                trainName = reader.GetString(0);
                fees = reader.GetDecimal(1);
            }
            con.Close();
            con.Open() ;
            SqlCommand cmd2 = new SqlCommand("insert into Fee(trainingID,trainingName,price,memberID,status) values (@tid,@tnm,@p,@uid,'unpaid')", con);
            cmd2.Parameters.AddWithValue("@tid", tid);
            cmd2.Parameters.AddWithValue("@tnm", trainName);
            cmd2.Parameters.AddWithValue("@p", fees);
            cmd2.Parameters.AddWithValue("@uid", userID);
            cmd2.ExecuteNonQuery();
            con.Close();

        }
        public string unEnroll(string uid, string tid)
        {
            string result = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from MemberEnroll where userID=@uid and trainingID=@tid", con);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@tid", tid);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            if (i != 0)
            {
                result = "Unenroll Succesful.";
            }
            else
                result = "You have not enrolled in these training.";
            con.Close();
            return result;
        }
        public void deleteFee(string uid, string tid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Fee where memberID=@uid and trainingID=@tid", con);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@tid", tid);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close() ;
        }
        public string countFee()
        {
            string data;
            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(price) from Fee where memberID=@id and status='unpaid'", con);
            cmd.Parameters.AddWithValue("@id", userID);
            SqlCommand cmd2 = new SqlCommand("select count(*) from Fee where memberID=@id and status='unpaid'", con);
            cmd2.Parameters.AddWithValue("@id", userID);
            int count = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count != 0)
                data = "RM" + cmd.ExecuteScalar().ToString();
            else
                data = "You have not any fee.";

            con.Close();
            return data;
        }
        public string pay()
        {
            string result = null;
            DateTime dateTime = DateTime.Now.Date;
            con.Open();
            SqlCommand cmd = new SqlCommand("update Fee set status = 'paid', paidDate=@dt where memberID=@id and status='unpaid'", con);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@dt", dateTime.ToString("yyyy/MM/dd"));
            int i = cmd.ExecuteNonQuery();
            
            if (i != 0)
                result = "Pay succesful.";
            con.Close();
            return result;
        }










    }
}
