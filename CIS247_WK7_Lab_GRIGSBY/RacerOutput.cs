using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class RacerOutput
    {
        //method to display Hot Rod output to user
        public static void DisplayHotRodInformation(Racer theRacer)
        {
            ApplicationUtilities.DisplayDivider("Hot Rod");
            ApplicationUtilities.DisplayDivider("Hot Rod Information");
            Console.WriteLine();
            Console.WriteLine(theRacer.ToString());
            ApplicationUtilities.PauseExecution();
        }

        //method to display Street Tuner output to user
        public static void DisplayStreetTunerInformation(Racer anotherRacer) 
        {
            ApplicationUtilities.DisplayDivider("Street Tuner");
            ApplicationUtilities.DisplayDivider("Street Tuner Information");
            Console.WriteLine();
            Console.WriteLine(anotherRacer.ToString());
            ApplicationUtilities.PauseExecution();
        }
    }
}

