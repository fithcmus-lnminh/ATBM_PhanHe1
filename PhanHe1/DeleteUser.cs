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
    public partial class DeleteUser : Form
    {
        string activeUser;

        public DeleteUser()
        {
            InitializeComponent();
            LoadListUsers();
        }
        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();

            deleteUserCbb.DataSource = listUsers;
            deleteUserCbb.DisplayMember = "Username";
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            bool result = bll.deleteUserBLL(activeUser);

            if (result == true)
            {
                MessageBox.Show(activeUser + " đã được xóa thành công khỏi hệ thống", "Thành công",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa người dùng do lỗi bên hệ thống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadListUsers();
        }

        private void deleteUserCbb_SelectedValueChanged(object sender, EventArgs e)
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
