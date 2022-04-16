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
    public partial class GrantRole : Form
    {
        public GrantRole()
        {
            InitializeComponent();
            LoadListRoles();
            LoadListPrivilegeSYS();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
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
            string rolename = listRoleCbb.Text;
            string priname = listPriCbb.Text;
            string adminOption = withAdminOption.CheckState == CheckState.Checked ? "WITH ADMIN OPTION" : "";
            string query = "grant " + priname + " to " + rolename + " " + adminOption;
            BLL bll = new BLL();
            bll.grantUserToRole(query);
            MessageBox.Show("Cấp quyền cho role " + rolename + "thành công!");
        }
    }
}
