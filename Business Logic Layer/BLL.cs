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
    }
}
