using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using Oracle.ManagedDataAccess.Client;

namespace PhanHe1
{
    public partial class UserPriv : Form
    {
        public UserPriv()
        {
            InitializeComponent();
        }

        private void UserPriv_Load(object sender, EventArgs e)
        {
            DAL con = new DAL();
            OracleConnection conn = con.ConnectToOracle();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT USERNAME FROM USER_SYS_PRIVS";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listUserCbb.Items.Add(reader.GetValue(0).ToString());
            }

            cmd.CommandText = "SELECT * FROM USER_SYS_PRIVS";
            OracleDataAdapter da = new OracleDataAdapter();
            da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "dataTable");
            dt = ds.Tables["dataTable"];
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                privUserLv.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                privUserLv.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                privUserLv.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());

            }
            privUserLv.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            privUserLv.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            privUserLv.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            conn.Close();
        }

        private void listUserCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAL con = new DAL();
            OracleConnection conn = con.ConnectToOracle();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            privUserLv.Items.Clear();
            cmd.CommandText = "SELECT * FROM USER_SYS_PRIVS WHERE USERNAME = N'" + listUserCbb.Text + "'";
            OracleDataReader rd = cmd.ExecuteReader();
            int i = 0;
            while (rd.Read())
            {
                privUserLv.Items.Add(rd[0].ToString());
                privUserLv.Items[i].SubItems.Add(rd[1].ToString());
                privUserLv.Items[i].SubItems.Add(rd[2].ToString());
                i++;
            }
            conn.Close();
        }
    }
}