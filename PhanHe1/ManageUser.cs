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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void listUserBtn_Click(object sender, EventArgs e)
        {
            Form List = new ListUser();
            List.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Priv = new UserPriv();
            Priv.ShowDialog();
        }

        private void grantPrivUserBtn_Click(object sender, EventArgs e)
        {
            Form GrantPriv = new GrantPrivUser();
            GrantPriv.ShowDialog();
        }

        private void revokePrivUserBtn_Click(object sender, EventArgs e)
        {
            Form RevokePriv = new RevokePrivUser();
            RevokePriv.ShowDialog();
        }

        private void updatePrivUserBtn_Click(object sender, EventArgs e)
        {
            Form UpdatePriv = new UpdatePrivUser(); 
            UpdatePriv.ShowDialog();
        }

        private void grantRoleUserBtn_Click(object sender, EventArgs e)
        {
            Form GrantRole = new GrantRoleUser();
            GrantRole.ShowDialog();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            Form CreateUser = new CreateUser();
            CreateUser.ShowDialog();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            Form DeleteUser = new DeleteUser();
            DeleteUser.ShowDialog();
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            Form UpdateUser = new UpdateUser();
            UpdateUser.ShowDialog();
        }
    }
}
