using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    public enum ApplianceType {Fan,Bulb,Ac };
    public class SwitchBoardSimulator
    {

        public SwitchBoard Board
        {
            get; set;
        }
        public SwitchBoardSimulator(params int[] RequiredAppliances)
        {
            this.Board = new SwitchBoard(RequiredAppliances);
        }

        public void PrintSwitchStatus()
        {
            for (int i = 0; i < this.Board.Switches.Count; i++)
            {
                if (this.Board.Switches[i].CurrentState())
                    Console.WriteLine("{0}. {1} {2} is {3}", i, this.Board.Switches[i].Appliance.Type, this.Board.Switches[i].Id, "ON");
                else
                    Console.WriteLine("{0}. {1} {2} is {3}", i, this.Board.Switches[i].Appliance.Type, this.Board.Switches[i].Id, "OFF");
            }
        }

        public void PrintDeviceMenu(int SelectedAppliance)
        {
            Switch SelectedDevice = this.Board.Switches[SelectedAppliance];
            if (SelectedDevice.CurrentState())
                Console.WriteLine("1. {0} {1} is {2}", SelectedDevice.Appliance.Type, this.Board.Switches[SelectedAppliance].Id, "ON");
            else
                Console.WriteLine("1. {0} {1} is {2}", SelectedDevice.Appliance.Type, this.Board.Switches[SelectedAppliance].Id, "OFF");
            Console.WriteLine("2. Back");
        }

        public void StartSimulation()
        {
            while (true)
            {
                PrintSwitchStatus();

                Console.Write("select a device :");
                int.TryParse(Console.ReadLine(), out int SelectedAppliance);
                while (SelectedAppliance > this.Board.Switches.Count)
                {
                    Console.Write("select correct device :");
                    int.TryParse(Console.ReadLine(), out SelectedAppliance);
                    Console.WriteLine();
                }

                PrintDeviceMenu(SelectedAppliance);
                Console.Write("Select An Option : ");
                int.TryParse(Console.ReadLine(), out int SelectedOption);
                Console.WriteLine();
                if (SelectedOption == 1)
                {
                    this.Board.ToggleSwitch(SelectedAppliance);
                }
            }
        }
    }
}