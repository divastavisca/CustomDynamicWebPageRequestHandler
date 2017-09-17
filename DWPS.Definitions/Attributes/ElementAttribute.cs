using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWPS.Definitions.Attributes
{
    public class ElementAttribute
    {
        public string Name { get; private set; }
        public object Value { get; private set; }

        public ElementAttribute(string name,object value)
        {
            Name = name;
            Value = value;
        }
    }
}
