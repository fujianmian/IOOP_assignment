using System;
using System.Collections;
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
    public partial class frmMember : Form
    {
        public static string name, userID;

        public frmMember()
        {
            InitializeComponent();
        }

        public frmMember(string nm,string ID)//nm(login username) id(login userID)
        {
            InitializeComponent();
            name = char.ToUpper(nm[0]) + nm.Substring(1);
            userID = ID;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Training obj1 = new Training();
            Member obj2 = new Member(userID);

            lblWelcome.Text = $"Welcome, {name}";
            lblName.Text = name;
            lblLevel.Text = obj2.getLevel(userID);
            lblEmail.Text = obj2.getEmail(userID);
            lblID.Text = userID.ToString();
            

            //get Schedule
            ArrayList data = new ArrayList();
            data = obj1.getTrainID(userID);
            foreach(string item in data)
            {
                ArrayList schedule = new ArrayList();
                schedule = obj1.getSche(item);
                foreach (var sche in schedule)
                {
                    lstSchedule.Items.Add(sche) ;

                }
            }

            //show performance
            ArrayList list = new ArrayList();
            list = obj2.getPerformance();
            foreach (string pf in list)
            {
                lstPerformance.Items.Add(pf) ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTraining form2 = new frmTraining(name,userID);
            form2.ShowDialog();


        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment a = new frmPayment(name,userID);
            a.ShowDialog();
        }

        private void btnCompetition_Click(object sender, EventArgs e)
        {
            frmCompetition a = new frmCompetition();
            a.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }



        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnSuggestion_Click(object sender, EventArgs e)
        {
            frmSuggestion a = new frmSuggestion(name,userID);
            a.ShowDialog();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            pnlPerformance.Visible = !pnlPerformance.Visible;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLoginForm = new frmLogin();
            frmLoginForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmLoginForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile from3 = new frmProfile(name,userID);
            from3.ShowDialog();
        }








        
    }
}
