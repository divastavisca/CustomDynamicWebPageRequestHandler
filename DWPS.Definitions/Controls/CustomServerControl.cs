using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWPS.Definitions.Attributes;

namespace DWPS.Definitions.Controls
{
    public abstract class CustomServerControl
    {
        public string Name { get; private set; }

        public List<ElementAttribute> ControlAttributes { get; private set; }

        public CustomServerControl(string controlName,List<ElementAttribute> attributes)
        {
            Name = controlName;
            ControlAttributes = attributes;
        }

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
        public string GetHTMLRepresentation();
    }
}
