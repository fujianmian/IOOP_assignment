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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace Assignment19_3
{
    public partial class frmTraining : Form
    {
        public static string userID,userName;
        private string level;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

        public frmTraining()
        {
            InitializeComponent();
            
        }
        public frmTraining(string nm, string id)
        {
            //get userID from frmMember
            InitializeComponent();
            userID = id;
            userName = nm;
        }


        private void frmTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.TrainingSche' table. You can move, or remove it, as needed.
            //this.trainingScheTableAdapter.Fill(this.database1DataSet1.TrainingSche);

            Member obj1 = new Member(userID);
            level = obj1.getOriLevel(userID);

            showTrainingList();
            showEnrollList();


        }
        private void showEnrollList()
        {
            clbTraining.Items.Clear();
            Training obj2 = new Training(userID);
            ArrayList EnrollList = new ArrayList();
            EnrollList = obj2.getEnrollList(level);
            foreach (var i in EnrollList)
            {
                clbTraining.Items.Add(i);
            }
         
        }

        private void clbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

            string query = "select * from TrainingSche where level=@lv";
            using (SqlDataAdapter command = new SqlDataAdapter(query, connection))
            {
                command.SelectCommand.Parameters.AddWithValue("@lv", level);
                DataTable dt = new DataTable();
                command.Fill(dt);
                dgvTrainList.DataSource = dt;
                
            }
            
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
  

            if (clbTraining.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select The Training!", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
           {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to enroll this training?", "Enroll Training", buttons);
                if (result == DialogResult.Yes)
                {
                    foreach (string s in clbTraining.CheckedItems)
                    {
                        Training obj1 = new Training(userID);
                        string status = obj1.enroll(userID, userName, s);
                        MessageBox.Show(status);

                        if (status == "Enroll Succesful!")
                        {
                            obj1.updateFee(s);

                        }
                    }
                    clbTraining.ClearSelected();

                }
                else
                {
                    clbTraining.ClearSelected();
                }

           }

        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {

            if (clbTraining.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select The Training!", "Worning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to unenroll this training?", "Enroll Training", buttons,MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    foreach (string s in clbTraining.CheckedItems)
                    {
                        Training obj1 = new Training();
                        string status = obj1.unEnroll(userID, s);
                        MessageBox.Show(status);

                        if (status == "Unenroll Succesful.")
                        {
                            obj1.deleteFee(userID,s);

                        }
                    }
                    clbTraining.ClearSelected();

                }
                else
                {
                    clbTraining.ClearSelected();
                }

            }
        }

        public void showTrainingList()
        {

            string query = "select * from TrainingSche where level=@lv";
            SqlDataAdapter command = new SqlDataAdapter(query, con);
            con.Open() ;
            command.SelectCommand.Parameters.AddWithValue("@lv", level);
            DataTable dt = new DataTable();
            command.Fill(dt);
            con.Close();
            dgvTrainList.DataSource = dt;

            
        }
  
    }
}
