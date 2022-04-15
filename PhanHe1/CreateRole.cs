using Business_Logic_Layer;
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
    public partial class CreateRole : Form
    {
        public CreateRole()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string rolenameInput = RoleNameTextbox.Text;
            string passwordInput = PasswordTextbox.Text;

            if (rolenameInput.Length == 0)
            {
                MessageBox.Show("Tên role phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (passwordInput.Length == 0)
            {
                MessageBox.Show("Mật khẩu phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                createRole(rolenameInput, passwordInput);
            }
        }

        private void createRole(String rolename, String pwd)
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();
            var listRoles = bll.getListRoles();
            bool isExist = true;

            foreach (var l in listUsers)
            {
                if (String.Compare(l.Username, rolename, true) == 0)
                {
                    isExist = false;
                    MessageBox.Show("Tên role đã tồn tại trong hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            foreach (var l2 in listRoles)
            {
                if (String.Compare(l2.Rolename, rolename, true) == 0)
                {
                    isExist = false;
                    MessageBox.Show("Tên role đã tồn tại trong hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (isExist == true)
            {
                bool result = bll.createRoleBLL(rolename, pwd);

                if (result == true)
                {
                    MessageBox.Show("Tạo thành công role " + rolename + " trong hệ thống", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoleNameTextbox.Text = "";
                    PasswordTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể tạo role do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
