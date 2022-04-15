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
    public partial class DeleteRole : Form
    {
        string activeRole;

        public DeleteRole()
        {
            InitializeComponent();
            LoadListRoles();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();

            deleteRoleCbb.DataSource = listRoles;
            deleteRoleCbb.DisplayMember = "Rolename";
        }

        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            bool result = bll.deleteRoleBLL(activeRole);
            Console.WriteLine("result delete role: " + result);

            if (result == true)
            {
                MessageBox.Show(activeRole + " đã được xóa thành công khỏi hệ thống", "Thành công",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa role do lỗi bên hệ thống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadListRoles();
        }

        private void deleteRoleCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Role cl = cb.SelectedValue as Role;
                activeRole = cl.Rolename;
            }
        }
    }
}
