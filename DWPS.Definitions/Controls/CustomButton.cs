using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWPS.Definitions.Attributes;

namespace DWPS.Definitions.Controls
{
    public class CustomButton : CustomServerControl
    {
        public string Text { get; set; }

        public string Color { get; set; } 
        public CustomButton(List<ElementAttribute> buttonAttributes) : base("Button",buttonAttributes)
        {
            foreach (ElementAttribute attribute in buttonAttributes)
            {
                if (attribute.Name == "Text")
                {
                    Text = (string)attribute.Value;
                }
                if(attribute.Name == "Color")
                {
                    Color = (string)attribute.Value;
                }

            }
        }
        public string GetHTMLRepresentation()
        {
            return string.Empty;
        }
    }
}
