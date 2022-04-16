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
    public partial class GrantPrivUser : Form
    {
        public GrantPrivUser()
        {
            InitializeComponent();
			LoadListUsers();
			LoadListPrivilegeSYS();
		}
		private void LoadListUsers()
		{
			BLL bll = new BLL();
			var listUsers = bll.getListUsers();
			listUserCbb.DataSource = listUsers;
			listUserCbb.DisplayMember = "Username";
		}

		private void LoadListPrivilegeSYS()
        {
			BLL bll = new BLL();
			var listPri = bll.getListPrivilegeSYS();
			listPriCbb.DataSource = listPri;
			listPriCbb.DisplayMember = "Rolename";
		}

        private void grantBtn_Click(object sender, EventArgs e)
        {
			string username = listUserCbb.Text;
			string priname = listPriCbb.Text;
			string adminOption = withAdminOption.CheckState == CheckState.Checked ? "WITH ADMIN OPTION" : "";
			string query = "grant " + priname + " to " + username + " " + adminOption;
			BLL bll = new BLL();
			bll.grantUserToRole(query);
			MessageBox.Show("Đã cấp quyền (privilege) cho username: " + username);
		}
    }
}
