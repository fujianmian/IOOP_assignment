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
    public partial class SearchEditUser : Form
    {
        public SearchEditUser()
        {
            InitializeComponent();
        }

        private void btnSearchEditID_Click(object sender, EventArgs e)
        {
            Management editID = new Management();
            editID.checkEditUser(txtSearchEditID.Text);
        }
    }
}
