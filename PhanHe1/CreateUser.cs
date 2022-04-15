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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameTextbox.Text;
            string passwordInput = passwordTextbox.Text;

            if (usernameInput.Length == 0)
            {
                MessageBox.Show("Tên người dùng phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(passwordInput.Length == 0)
            {
                MessageBox.Show("Mật khẩu phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                createUser(usernameInput, passwordInput);
            }
        }

        private void createUser(String username, String pwd)
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();
            var listRoles = bll.getListRoles();
            bool isExist = true;

            foreach (var l in listUsers)
            {
                if (String.Compare(l.Username, username, true) == 0)
                {
                    isExist = false;
                    MessageBox.Show("Tên người dùng đã tồn tại trong hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }           
            }

            foreach (var l2 in listRoles)
            {
                if (String.Compare(l2.Rolename, username, true) == 0)
                {
                    isExist = false;
                    MessageBox.Show("Tên người dùng đã tồn tại trong hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (isExist == true)
            {
                bool result = bll.createUserBLL(username, pwd);

                if(result == true)
                {
                    MessageBox.Show("Tạo thành công người dùng " + username + " trong hệ thống", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usernameTextbox.Text = "";
                    passwordTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể tạo người dùng do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
