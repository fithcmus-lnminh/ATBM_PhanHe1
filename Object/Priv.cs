using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Priv
    {
        public Priv() { }

        public Priv(string objectGrantee, string privName, string privType, string tableName, string owner)
        {
            ObjectGrantee = objectGrantee;
            PrivName = privName;
            PrivType = privType;
            TableName = tableName;
            Owner = owner;
        }
        public string ObjectGrantee { get; set; }
        public string PrivName { get; set; }
        public string PrivType { get; set; }
        public string TableName { get; set; }
        public string Owner { get; set; }

    }
}
