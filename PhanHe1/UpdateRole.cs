using Business_Logic_Layer;
using Object;
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
    public partial class UpdateRole : Form
    {
        string activeRole;

        public UpdateRole()
        {
            InitializeComponent();
            LoadListRoles();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();

            updateRoleCbb.DataSource = listRoles;
            updateRoleCbb.DisplayMember = "Rolename";
        }

        private void updateRoleBtn_Click(object sender, EventArgs e)
        {
            string passwordInput = passwordTextbox.Text;

            if (passwordInput.Length == 0)
            {
                MessageBox.Show("Mật khẩu phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                updateRole(passwordInput);
            }
        }

        private void updateRole(String pwd)
        {
            BLL bll = new BLL();
            bool result = bll.updateRoleBLL(activeRole, pwd);

            if (result == true)
            {
                MessageBox.Show(activeRole + " đã cập nhật mật khẩu thành công", "Thành công",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đổi mật khẩu do lỗi bên hệ thống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadListRoles();
            passwordTextbox.Text = "";
        }

        private void updateRoleCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Role cl = cb.SelectedValue as Role;
                activeRole = cl.Rolename;
            }
        }

        private void updateRoleCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
