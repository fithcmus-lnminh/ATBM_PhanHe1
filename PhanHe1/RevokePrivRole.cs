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
    public partial class RevokePrivRole : Form
    {
        string activeRole = "", activeTypePriv = "", activePriv = "", typeObjectGrantee = "ROLE";
        List<TypePriv> listTypePrivs;

        public RevokePrivRole()
        {
            InitializeComponent();
            listTypePrivs = new List<TypePriv>() {
                new TypePriv() { Description = "Quyền hệ thống", TableName = "ROLE_SYS_PRIVS" },
                new TypePriv() { Description = "Quyền đối tượng", TableName = "ROLE_TAB_PRIVS" },
            };

            LoadListUsers();
            LoadListTypePrivs();
            LoadListPrivs();
        }

        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();

            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
        }

        private void LoadListTypePrivs()
        {
            BLL bll = new BLL();

            listTypePrivCbb.DataSource = listTypePrivs;
            listTypePrivCbb.DisplayMember = "Description";
        }

        private void LoadListPrivs()
        {
            BLL bll = new BLL();
            var listPrivs = bll.getListPrivs(activeRole, activeTypePriv, typeObjectGrantee);
            List<string> listDescriptionPrivs = new List<string>();

            if (listPrivs.Count == 0)
            {
                activePriv = "";
            }

            foreach (var l in listPrivs)
            {
                string descriptionPriv = l.PrivName;

                if (String.Compare(l.PrivType, "ROLE_TAB_PRIVS", true) == 0)
                {
                    descriptionPriv = descriptionPriv + " ON "
                        + l.Owner + "." + l.TableName;
                }

                listDescriptionPrivs.Add(descriptionPriv);
            }

            listPrivCbb.DataSource = listDescriptionPrivs;
        }

        private void listRoleCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Role cl = cb.SelectedValue as Role;
                activeRole = cl.Rolename;
                LoadListTypePrivs();
                LoadListPrivs();
            }
        }

        private void listRoleCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listTypePrivCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                TypePriv cl = cb.SelectedValue as TypePriv;
                activeTypePriv = cl.TableName;
                LoadListPrivs();
            }
        }

        private void listPrivCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                string cl = cb.SelectedValue as string;
                activePriv = cl;
            }
        }
        private void revokeBtn_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            if (String.Compare(activePriv, "", true) == 0)
            {
                MessageBox.Show("Không có sẵn quyền để thu hồi từ người dùng", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool result = bll.revokePrivRoleBLL(activeRole, activePriv);

                if (result == true)
                {
                    MessageBox.Show("Thu hồi quyền " + activePriv + " từ role "
                        + activeRole + " thành công", "Thành công",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thu hồi quyền role do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                LoadListPrivs();
            }
        }
    }
}
