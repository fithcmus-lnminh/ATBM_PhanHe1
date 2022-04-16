using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Privilege
    {
        public Privilege() { }
        public Privilege(string username, string privilegename, string admin_option)
        {
            Username = username;
            Privilegename = privilegename;
            Admin_option = admin_option;
        }

        public string Privilegename { get; set; }

        public string Username { get; set; }

        public string Admin_option { get; set; }

    }
}
