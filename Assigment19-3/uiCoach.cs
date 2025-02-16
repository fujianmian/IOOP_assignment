//using Assignment_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment19_3
{
    public partial class uiCoach : Form
    {
        public uiCoach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            uiAdd uiAddForm = new uiAdd();
            this.Hide();
            uiAddForm.Show();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            uiViewPaid uiViewPaidForm = new uiViewPaid();
            this.Hide();
            uiViewPaidForm.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            uiPerformance uiPerformanceForm = new uiPerformance();
            this.Hide();
            uiPerformanceForm.Show();
        }

        private void btnRecommendation_Click(object sender, EventArgs e)
        {
            uiSendRecomm uiSendRecommForm = new uiSendRecomm();
            this.Hide();
            uiSendRecommForm.Show();
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
