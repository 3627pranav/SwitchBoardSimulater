using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    public class Switch
    {
        public int Id { get; set; }

        public bool State{ get;set; }
        
        public Appliance Appliance{ get;set;}

        public Switch(int id)
        {
            this.Id = id;
            this.State = false;
        }

        public void ToggleSwitch()
        {
            if (this.State)
                this.State = false;
            else
                this.State = true;
        }

        public bool CurrentState()
        {
            return this.State;
        }

    }
}
