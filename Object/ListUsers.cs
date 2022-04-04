using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class ListUsers
    {
        public ListUsers() { }
        public ListUsers(string name)
        {
            Username = name;
        }
        public string Username { get; set; }
    }
}
