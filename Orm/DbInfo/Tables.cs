using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.DbInfo
{
    class Tables
    {
        private string _name;
        private List<Fields> _fields;

        public string Name { get => _name; set => _name = value; }
        internal List<Fields> Fields { get => _fields; set => _fields = value; }
    }
}
