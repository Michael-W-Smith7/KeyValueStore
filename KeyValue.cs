using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    struct KeyValue<t>
    {
        public string Key;
        public t Value;

        
        public KeyValue(string _key, t _val)
        {
            Key = _key;
            Value = _val;
        }
    }
}
