using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationUtilities.DisplayApplicationInformation();
            ApplicationUtilities.DisplayDivider("Program Start");

            Racer[] racerList = new Racer[2];

            racerList[0] = new HotRod();
            racerList[1] = new StreetTuner();

            for (int i = 0; i < 2; i++ )
            {
                if (racerList[i] is HotRod)
                {
                    RacerInput.CollectHotRodInformation((HotRod)racerList[i]);
                    RacerOutput.DisplayHotRodInformation((HotRod)racerList[i]);
                }
                else if (racerList[i] is StreetTuner)
                {
                    RacerInput.CollectStreetTunerInformation((StreetTuner)racerList[i]);
                    RacerOutput.DisplayStreetTunerInformation((StreetTuner)racerList[i]);
                }
                else
                    break;
            }

            ApplicationUtilities.TerminateApplication();
        }
    }
}
