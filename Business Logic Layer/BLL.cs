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
        public List<ListUsers> getListUsers()
        {
            DAL res = new DAL();
            var users = res.getListUsersFromDatabase();
            return users;
        }
    }
}
