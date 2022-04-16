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

namespace PhanHe1
{
    public partial class RoleUser : Form
    {
        public RoleUser()
        {
            InitializeComponent();
            LoadListRoles();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
        }

        private void ListUsers_To_ListView(ListView privUserLv, List<string> quyen)
        {
            privUserLv.Items.Clear();
            foreach (var privs in quyen)
            {
                ListViewItem item = new ListViewItem();
                item.Text = privs;
                privUserLv.Items.Add(item);
                item.Tag = privs;
            }
        }

        private void listRoleCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rolename = listRoleCbb.Text;
            BLL bll = new BLL();
            var users = bll.getListUserFromRole(rolename);
            ListUsers_To_ListView(privUserLv, users);
        }
    }
}
