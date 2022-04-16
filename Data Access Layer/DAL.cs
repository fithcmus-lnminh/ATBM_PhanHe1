using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
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

		public List<Privilege> GetPrivilegesByUserNameOrRoleName(string name)
		{
			var privileges = new List<Privilege>();
			OracleConnection conn = ConnectToOracle();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "SELECT GRANTEE, PRIVILEGE, ADMIN_OPTION FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + name + "'";
			using (DbDataReader reader = oc.ExecuteReader())
			{

				while (reader.Read())
				{
					// Chỉ số (index) của cột GRANTEE trong câu lệnh SQL.
					int UsernaneIndex = reader.GetOrdinal("GRANTEE"); // 0
					string Username = reader.GetString(UsernaneIndex);

					// Chỉ số của cột PRIVILEGE là 1.
					int privilegeIndex = reader.GetOrdinal("PRIVILEGE");// 1
					string privilege = reader.GetString(privilegeIndex);


					int admin_optionIndex = reader.GetOrdinal("ADMIN_OPTION");
					string admin_option = reader.GetString(admin_optionIndex);

					privileges.Add(new Privilege(Username, privilege, admin_option));
				}
			}
			conn.Close();
			return privileges;
		}

		public void GrantUserToRole(string query)
		{
			OracleConnection conn = ConnectToOracle();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = query;
			oc.ExecuteNonQuery();
		}

		public List<Role> GetListPrivilegeSYSDAL()
		{
			var pri = new List<Role>();
			OracleConnection conn = ConnectToOracle();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "SELECT distinct(privilege) FROM dba_sys_privs";
			var reader = oc.ExecuteReader();
			while (reader.Read())
			{
				pri.Add(new Role(reader.GetString(0)));
			}
			conn.Close();
			return pri;
		}

		public void grantPriToRoleDAL(string query)
		{
			OracleConnection conn = ConnectToOracle();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = query;
			oc.ExecuteNonQuery();
		}
	}
}
