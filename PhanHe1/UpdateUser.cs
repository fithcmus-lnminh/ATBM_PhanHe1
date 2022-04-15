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
    public partial class UpdateUser : Form
    {
        string activeUser;

        public UpdateUser()
        {
            InitializeComponent();
            LoadListUsers();
        }

        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();

            updateUserCbb.DataSource = listUsers;
            updateUserCbb.DisplayMember = "Username";
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            string passwordInput = passwordTextbox.Text;

            if (passwordInput.Length == 0)
            {
                MessageBox.Show("Mật khẩu phải khác rỗng", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                updateUser(passwordInput);
            }
        }

        private void updateUser(String pwd)
        {
            BLL bll = new BLL();
            bool result = bll.updateUserBLL(activeUser, pwd);

            if (result == true)
            {
                 MessageBox.Show(activeUser + " đã cập nhật mật khẩu thành công", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đổi mật khẩu do lỗi bên hệ thống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadListUsers();
            passwordTextbox.Text = "";
        }

        private void updateUserCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                User cl = cb.SelectedValue as User;
                activeUser = cl.Username;
            }
        }
    }
}
