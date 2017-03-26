using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.DbInfo
{
    class Fields
    {
        private string _name;
        private string _type;
        private int _length;

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public int Length { get => _length; set => _length = value; }
    }
}
