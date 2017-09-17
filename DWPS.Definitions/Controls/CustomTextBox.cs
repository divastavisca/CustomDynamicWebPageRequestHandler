using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWPS.Definitions.Attributes;


namespace DWPS.Definitions.Controls
{
    public class CustomTextBox : CustomServerControl
    {
        public string Text { get; set; }

        public string ForeColor { get; set; } 
        public CustomTextBox(List<ElementAttribute> attributes) : base("TextBox",attributes)
        {
            foreach(ElementAttribute attribute in attributes)
            {
                if(attribute.Name == "Text")
                {
                    Text = (string)attribute.Value;
                }
                if(attribute.Name == "ForeColor")
                {
                    ForeColor = (string)attribute.Value;
                }
            }
        }
    }
}
