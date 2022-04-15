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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            LoadListUsers();
        }
        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();
            ConvertListUsersToListView(ListUserlv, listUsers);
        }

        private void ConvertListUsersToListView(ListView listViewUsers, List<User> ListUsers)
        {
            listViewUsers.Items.Clear();
            foreach (var l in ListUsers)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = l;
                item.Text = l.Username;
                listViewUsers.Items.Add(item);
            }
        }

    }
}
