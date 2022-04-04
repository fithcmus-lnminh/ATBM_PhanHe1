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
        public List<ListUsers> getListUsersFromDatabase()
        {
            var users = new List<ListUsers>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT username FROM all_users";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new ListUsers(reader.GetString(0)));
            }
            conn.Close();
            return users;
        }
    }
}
