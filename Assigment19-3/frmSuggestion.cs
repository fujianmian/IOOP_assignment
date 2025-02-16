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
    public partial class frmSuggestion : Form
    {
        private string name;
        private string UserID;
        public frmSuggestion()
        {
            InitializeComponent();
        }

        public frmSuggestion(string un, string id)
        {
            InitializeComponent();
            name = un;
            UserID = id;
            
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            if (txtSuggestion.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Text Cannot Be Empty!","Error",buttons,icon);
                txtSuggestion.Text = "";

            }
            else
            {
                Member obj1 = new Member(UserID, name, txtSuggestion.Text);
                MessageBox.Show(obj1.sendSuggestion());
                txtSuggestion.Text = "";
            }
            
        }

        private void txtSuggestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Perform button click action
                btnSend.PerformClick();
                // Prevent the key event from being passed on
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


    }
}
