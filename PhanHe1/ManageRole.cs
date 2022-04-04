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
    public partial class ManageRole : Form
    {
        public ManageRole()
        {
            InitializeComponent();
        }

        private void listRoleBtn_Click(object sender, EventArgs e)
        {
            Form Role = new ListRole();
            Role.ShowDialog();
        }

        private void roleInfoBtn_Click(object sender, EventArgs e)
        {
            Form RolePriv = new RolePriv();
            RolePriv.ShowDialog();
        }

        private void roleUserBtn_Click(object sender, EventArgs e)
        {
            Form RoleUser = new RoleUser();
            RoleUser.ShowDialog();
        }

        private void grantPrivRoleBtn_Click(object sender, EventArgs e)
        {
            Form GrantPriv = new GrantRole();
            GrantPriv.ShowDialog();
        }

        private void revokePrivRoleBtn_Click(object sender, EventArgs e)
        {
            Form RevokePriv = new RevokePrivRole();
            RevokePriv.ShowDialog();
        }

        private void updatePrivRoleBtn_Click(object sender, EventArgs e)
        {
            Form UpdatePriv = new UpdatePrivRole();
            UpdatePriv.ShowDialog();
        }

        private void createRoleBtn_Click(object sender, EventArgs e)
        {
            Form CreateRole = new CreateRole();
            CreateRole.ShowDialog();
        }

        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            Form DeleteRole = new DeleteRole();
            DeleteRole.ShowDialog();
        }

        private void updateRoleBtn_Click(object sender, EventArgs e)
        {
            Form UpdateRole = new UpdateRole();
            UpdateRole.ShowDialog();
        }
    }
}
