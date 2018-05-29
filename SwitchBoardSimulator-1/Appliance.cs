using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    public class Appliance
    {
        
        public ApplianceType Type { get; set; }

        public Appliance(ApplianceType type)
        {
            this.Type = type;
        }
    }
}
