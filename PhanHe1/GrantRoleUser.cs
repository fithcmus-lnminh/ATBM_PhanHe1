using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Object;

namespace PhanHe1
{
    public partial class GrantRoleUser : Form
    {
        public GrantRoleUser()
        {
            InitializeComponent();
            LoadListUsers();
            LoadListRoles();
        }

        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();
            listUserCbb.DataSource = listUsers;
            listUserCbb.DisplayMember = "Username";
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            string username = listUserCbb.Text;
            string rolename = listRoleCbb.Text;
            string query = "grant " + rolename + " to " + username;
            BLL bll = new BLL();
            bll.grantUserToRole(query);
            MessageBox.Show("Đã cấp role cho người dùng");
        }
    }
}
