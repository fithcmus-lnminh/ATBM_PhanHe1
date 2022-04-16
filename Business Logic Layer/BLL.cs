using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Object;

namespace Business_Logic_Layer
{
    public class BLL
    {
        public List<User> getListUsers()
        {
            DAL res = new DAL();
            var users = res.GetListUsersFromDatabase();
            return users;
        }
        public List<Role> getListRoles()
        {
            DAL res = new DAL();
            var roles = res.GetListRolesFromDatabase();
            return roles;
        }
        public List<string> getListRolesFromUser(string username)
        {
            DAL res = new DAL();
            var roles = res.GetListRolesFromUserFromDatabase(username);
            return roles;
        }
        public List<string> getListUserFromRole(string rolename)
        {
            DAL res = new DAL();
            var users = res.GetListUsersFromRoleFromDatabase(rolename);
            return users;
        }
        public bool createUserBLL(String username, String pwd)
        {
            DAL res = new DAL();
            return res.createUserInDatabase(username, pwd);
        }

        public bool updateUserBLL(String username, String pwd)
        {
            DAL res = new DAL();
            return res.updateUserInDatabase(username, pwd);
        }

        public bool deleteUserBLL(String username)
        {
            DAL res = new DAL();
            return res.deleteUserInDatabase(username);
        }

        public bool createRoleBLL(String rolename, String pwd)
        {
            DAL res = new DAL();
            return res.createRoleInDatabase(rolename, pwd);
        }

        public bool updateRoleBLL(String rolename, String pwd)
        {
            DAL res = new DAL();
            return res.updateRoleInDatabase(rolename, pwd);
        }

        public bool deleteRoleBLL(String rolename)
        {
            DAL res = new DAL();
            return res.deleteRoleInDatabase(rolename);
        }

         public List<Priv> getListPrivs(String name, String typePriv, String typeObjectGrantee)
        {
            DAL res = new DAL();
            var privs = res.GetListPrivsFromDatabase(name, typePriv, typeObjectGrantee);
            return privs;
        }       
        
        public bool revokePrivUserBLL(String user, String priv)
        {
            DAL res = new DAL();
            return res.revokePrivUserInDatabase(user, priv);
        }
        public bool revokePrivRoleBLL(String role, String priv)
        {
            DAL res = new DAL();
            return res.revokePrivRoleInDatabase(role, priv);
        }

        public List<Privilege> getListPrivilegesByUserNameOrRoleName(string username)
        {
            DAL res = new DAL();
            var privileges = res.GetPrivilegesByUserNameOrRoleName(username);
            return privileges;
        }

        public void grantUserToRole(string query)
        {
            DAL res = new DAL();
            res.GrantUserToRole(query);
        }

        public void revokeUserFromRole(string query)
        {
            DAL res = new DAL();
            res.RevokeUserFromRole(query);
        }

        public List<Role> getListPrivilegeSYS()
        {
            DAL res = new DAL();
            var privileges = res.GetListPrivilegeSYSDAL();
            return privileges;
        }

        public void grantPriToRole(string query)
        {
            DAL res = new DAL();
            res.grantPriToRoleDAL(query);
        }
    }
}
