using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWPS.Definitions.Attributes;

namespace DWPS.Definitions.Controls
{
    public class CustomServerControl
    {
        public string Name { get; }

        public List<ElementAttribute> ControlAttributes;

        public override string ToString()
        {
            return this.getLanguageRepresentation();
        }

        private string getLanguageRepresentation()
        {
            StringBuilder actualControlScript = new StringBuilder();
            actualControlScript.Append("<dwps:");
            actualControlScript.Append(this.Name+" ");
            foreach(ElementAttribute controlAttribute in ControlAttributes)
            {
                actualControlScript.Append(controlAttribute.Name);
                actualControlScript.Append("=");
                actualControlScript.Append(controlAttribute.Value.ToString());
                if(ControlAttributes.IndexOf(controlAttribute)!=ControlAttributes.Count-1)
                    actualControlScript.Append(" ");
            }
            actualControlScript.Append("></dwps:");
            actualControlScript.Append(this.Name);
            actualControlScript.Append(">");
            return actualControlScript.ToString();
        }
    }
}
