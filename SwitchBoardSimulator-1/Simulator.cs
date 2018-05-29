using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    class Simulator
    {
        public static void Main(string[] args)
        {
            string[] Appliance = Enum.GetNames(typeof(ApplianceType));
            int[] RequiredAppliances = new int[Appliance.Length];
            for (int i = 0; i < Appliance.Length; i++)
            {
                Console.Write("\nNumber of  \"{0}\" require : ", Appliance[i]);
                int.TryParse(Console.ReadLine().Trim(), out RequiredAppliances[i]);
            }
            SwitchBoardSimulator Simulator = new SwitchBoardSimulator(RequiredAppliances);
            Simulator.StartSimulation();
        }
    }
}
