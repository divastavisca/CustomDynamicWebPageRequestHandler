using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWPS.Definitions.Attributes
{
    public class Runat : ElementAttribute
    {
        public Runat() : base("runat",DWPS.Definitions.ServerConstants.RunatValues.Server)
        {

        }
    }
}
