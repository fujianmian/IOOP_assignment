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
    public partial class ManagementPage : Form
    {
        public ManagementPage()
        {
            InitializeComponent();
        }

        private void btnMPAdd_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.ShowDialog();
        }

        private void btnMPEdit_Click(object sender, EventArgs e)
        {
            SearchEditUser searchUser1 = new SearchEditUser();
            searchUser1.ShowDialog();
        }

        private void btnMPDelete_Click(object sender, EventArgs e)
        {
            DeletePage deleteUser = new DeletePage();
            deleteUser.ShowDialog();
        }
    }
}
