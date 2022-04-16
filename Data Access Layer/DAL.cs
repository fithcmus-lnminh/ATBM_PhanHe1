using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using Object;
using System.Data;

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

        public List<Priv> GetListPrivsFromDatabase(String objectGrantee, String typePriv, String typeObjectGrantee)
        {
            var privs = new List<Priv>();
            OracleConnection conn = ConnectToOracle();

            try
            {
                OracleCommand oc = new OracleCommand();
                oc.Connection = conn;
                oc.CommandText = "SELECT * FROM " + typePriv + " WHERE " + typeObjectGrantee + " = '" + objectGrantee + "'";
                OracleDataReader reader = oc.ExecuteReader();

                Console.WriteLine("oc.CommandText: " + oc.CommandText);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string objectName = "";
                        string privName = reader["PRIVILEGE"].ToString();
                        string privType = typePriv;
                        string tableName = "";
                        string owner = "";

                        if (String.Compare(typeObjectGrantee, "GRANTEE", true) == 0) 
                        {
                            objectName = reader["GRANTEE"].ToString();
                            if (String.Compare(typePriv, "DBA_TAB_PRIVS", true) == 0)
                            {
                                tableName = reader["TABLE_NAME"].ToString();
                                owner = reader["OWNER"].ToString();
                            }
                        }
                        else if (String.Compare(typeObjectGrantee, "ROLE", true) == 0)
                        {
                            objectName = reader["ROLE"].ToString();
                            if (String.Compare(typePriv, "ROLE_TAB_PRIVS", true) == 0)
                            {
                                tableName = reader["TABLE_NAME"].ToString();
                                owner = reader["OWNER"].ToString();
                            }
                        }
                       
                        privs.Add(new Priv(objectName, privName, privType, tableName, owner));
                    }
                }
                else
                {
                    Console.WriteLine("Không có dữ liệu trả về");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return privs;
        }

        public bool createUserInDatabase(String username, String pwd)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Create_User_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@user_name", OracleDbType.Varchar2)).Value = username;
                oc.Parameters.Add(new OracleParameter("@u_password", OracleDbType.Varchar2)).Value = pwd;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@user_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@u_password"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool updateUserInDatabase(String username, String pwd)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Update_User_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@user_name", OracleDbType.Varchar2)).Value = username;
                oc.Parameters.Add(new OracleParameter("@new_password", OracleDbType.Varchar2)).Value = pwd;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@user_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@new_password"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool deleteUserInDatabase(String username)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Delete_User_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@user_name", OracleDbType.Varchar2)).Value = username;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@user_name"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool createRoleInDatabase(String rolename,  String pwd)
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Create_Role_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@role_name", OracleDbType.Varchar2)).Value = rolename;
                oc.Parameters.Add(new OracleParameter("@role_password", OracleDbType.Varchar2)).Value = pwd;
                
                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@role_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@role_password"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool updateRoleInDatabase(String rolename, String pwd)
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Update_Role_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@role_name", OracleDbType.Varchar2)).Value = rolename;
                oc.Parameters.Add(new OracleParameter("@new_password", OracleDbType.Varchar2)).Value = pwd;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@role_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@new_password"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool deleteRoleInDatabase(String rolename)
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Delete_Role_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@role_name", OracleDbType.Varchar2)).Value = rolename;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@role_name"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool revokePrivUserInDatabase(String user, String priv)
        {
            bool status = false;

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Revoke_Priv_User_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@user_name", OracleDbType.Varchar2)).Value = user;
                oc.Parameters.Add(new OracleParameter("@priv", OracleDbType.Varchar2)).Value = priv;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@user_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@priv"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool revokePrivRoleInDatabase(String role, String priv)
        {
            bool status = false;

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                oc.CommandText = "Revoke_Priv_Role_Procedure";
                // Kiểu của Command là StoredProcedure
                oc.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("ocCommandline: " + oc.CommandText);

                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@role_name", OracleDbType.Varchar2)).Value = role;
                oc.Parameters.Add(new OracleParameter("@priv", OracleDbType.Varchar2)).Value = priv;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@role_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@priv"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
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

