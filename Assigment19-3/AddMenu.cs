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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void btnAMAddManager_Click(object sender, EventArgs e)
        {
            AddManager addManager = new AddManager();
            addManager.ShowDialog();
        }

        private void btnAMAddCoach_Click(object sender, EventArgs e)
        {
            AddCoach addCoach = new AddCoach();
            addCoach.ShowDialog();
        }

        private void btnAMAddMember_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.ShowDialog(); 
        }
    }
}
