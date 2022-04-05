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
    public partial class ListRole : Form
    {
        public ListRole()
        {
            InitializeComponent();
            LoadListRoles();
        }
        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            ConvertListUsersToListView(ListRolelv, listRoles);
        }

        private void ConvertListUsersToListView(ListView listViewUsers, List<Role> roles)
        {
            listViewUsers.Items.Clear();
            foreach (var l in roles)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = l;
                item.Text = l.Rolename;
                listViewUsers.Items.Add(item);
            }
        }
    }
}
