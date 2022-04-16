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
    public partial class RolePriv : Form
    {
        public RolePriv()
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

        private void listRoleCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolename = listRoleCbb.Text;
            if (rolename != null)
            {
                BLL bll = new BLL();
                List<Privilege> listOption = bll.getListPrivilegesByUserNameOrRoleName(rolename);
                ConvertListAdminOptionToListView(privUserLv, listOption);
            }
        }

        private void ConvertListAdminOptionToListView(ListView ListViewOption, List<Privilege> listOption)
        {
            ListViewOption.Items.Clear();
            foreach (var l in listOption)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = l;
                item.Text = l.Username;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = l.Privilegename });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = l.Admin_option });
                ListViewOption.Items.Add(item);
            }
        }
    }
}
