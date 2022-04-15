using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class TypePriv
    {
        public TypePriv() { }
        
        public TypePriv(string description, string tableName)
        {
            Description = description;
            TableName = tableName;
        }
        public string Description { get; set; }
        public string TableName { get; set; }
    }
}
