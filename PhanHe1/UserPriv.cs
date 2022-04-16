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
	public partial class UserPriv : Form
	{
		public UserPriv()
		{
			InitializeComponent();
			LoadListUsers();
		}
		private void LoadListUsers()
		{
			BLL bll = new BLL();
			var listUsers = bll.getListUsers();
			listUserCbb.DataSource = listUsers;
			listUserCbb.DisplayMember = "Username";
		}

		private void listUserCbb_SelectedIndexChanged(object sender, EventArgs e)
		{
			string username = "ANONYMOUS";
			username = listUserCbb.Text;
			if (username != null)
			{
				BLL bll = new BLL();
				List<Privilege> listPrivilege = bll.getListPrivilegesByUserNameOrRoleName(username);
				ConvertListPrivilegesToListView(privUserLv, listPrivilege);
			}
		}

		private void ConvertListPrivilegesToListView(ListView ListViewPrivileges, List<Privilege> ListPrivileges)
		{
			ListViewPrivileges.Items.Clear();
			foreach (var l in ListPrivileges)
			{
				ListViewItem item = new ListViewItem();
				item.Tag = l;
				item.Text = l.Username;
				item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = l.Privilegename });
				item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = l.Admin_option });
				ListViewPrivileges.Items.Add(item);
			}
		}
	}
}
