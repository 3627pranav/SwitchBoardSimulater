using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    public class SwitchBoard
    {
        public List<Switch> Switches{get; set;}

        public SwitchBoard(int[] RequiredAppliances)
        {
            this.Switches = new List<Switch>();
            this.CreateSwitches(RequiredAppliances);
        }

        public void CreateSwitches(int[] RequiredAppliances)
        {
            for (int i = 0; i < RequiredAppliances.Max(); i++)
            {
                if (i < RequiredAppliances[0])
                {
                    Switch s = new Switch(this.Switches.Count);
                    s.Appliance = new Appliance(ApplianceType.Fan);
                    this.Switches.Add(s);
                }
                if (i < RequiredAppliances[1])
                {
                    Switch s = new Switch(this.Switches.Count);
                    s.Appliance = new Appliance(ApplianceType.Bulb);
                    this.Switches.Add(s);
                }
                if (i < RequiredAppliances[2])
                {
                    Switch s = new Switch(this.Switches.Count);
                    s.Appliance = new Appliance(ApplianceType.Ac);
                    this.Switches.Add(s);
                }
            }
        }

        public void ToggleSwitch(int SelectedAppliance)
        {
            this.Switches.First(n => n.Id == SelectedAppliance).ToggleSwitch();
        }

    }
}
