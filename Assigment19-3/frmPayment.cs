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
    public partial class frmPayment : Form
    {
        public static string name, UserID;
        public frmPayment()
        {
            InitializeComponent();
        }
        public frmPayment(string nm, string id)
        {
            InitializeComponent();
            UserID = id;
            name = nm;
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Fee' table. You can move, or remove it, as needed.
            //this.feeTableAdapter.Fill(this.database1DataSet.Fee);
            showInvoices();

            Training obj1 = new Training(UserID);
            lblTotal.Text = obj1.countFee();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Training obj1 = new Training(UserID);

            MessageBoxButtons bt = MessageBoxButtons.OK;
            MessageBoxIcon ic = MessageBoxIcon.Exclamation;
            if (lblTotal.Text == "You have not any fee.")
            {
                MessageBox.Show("You have not any fee to pay.","Error",bt,ic);
                showInvoices();
                lblTotal.Text = obj1.countFee();
            }
            else
            {
                MessageBox.Show(obj1.pay(),"Succesful",bt);

            }




        }

        public void showInvoices()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCs"].ToString());

            string query = "select invoiceID,trainingName,price,status,paidDate from Fee where memberID=@id";
            using (SqlDataAdapter command = new SqlDataAdapter(query, connection))
            {
                command.SelectCommand.Parameters.AddWithValue("@id", UserID);
                DataTable dt = new DataTable();
                command.Fill(dt);

                dgvBillList.DataSource = dt;

            }
        }
    }
}
