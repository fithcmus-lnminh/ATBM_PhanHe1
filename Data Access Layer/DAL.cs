using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Object;

namespace Data_Access_Layer
{
    public class DAL
    {
        public OracleConnection ConnectToOracle()
        {
            //Connection String 
            string connectionString = "User Id=dbadmin; password=dbadmin;" +
            "Data Source=localhost:1521/xe; Pooling=false;";

            //Create Connection
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }
        public List<User> GetListUsersFromDatabase()
        {
            var users = new List<User>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT username FROM all_users";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(reader.GetString(0)));
            }
            conn.Close();
            return users;
        }
        public List<Role> GetListRolesFromDatabase()
        {
            var roles = new List<Role>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT role FROM dba_roles";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                roles.Add(new Role(reader.GetString(0)));
            }
            conn.Close();
            return roles;
        }
    }
}
