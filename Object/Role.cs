using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Role
    {
        public Role() { }
        public Role(string name)
        {
            Rolename = name;
        }

        public string Rolename { get; set; }
    }
}
