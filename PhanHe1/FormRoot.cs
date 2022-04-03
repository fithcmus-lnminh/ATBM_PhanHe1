using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class FormRoot : Form
    {
        public FormRoot()
        {
            InitializeComponent();
        }

        private void FormRoot_Load(object sender, EventArgs e)
        {

        }

        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form User = new ManageUser();
            User.ShowDialog();
            Show();
        }

        private void manageRoleBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form Role = new ManageRole();
            Role.ShowDialog();
            Show();
        }
    }
}
