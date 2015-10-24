using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class RacerInput
    {
        public RacerInput() 
        {
        }

        //method to input Hot Rod information
        public static void CollectHotRodInformation(HotRod hot)
        {
            Console.WriteLine("\n");
            ApplicationUtilities.DisplayDivider("Provide the information for the new Hot Rod");
            Console.WriteLine();
            hot.Name = InputUtilities.GetInput("Racer name");
            hot.Speed = InputUtilities.getIntegerInputValue("Racer speed");
            hot.Eng.Cylinders = InputUtilities.getIntegerInputValue("Number of cylinders");
            hot.Eng.Horsepower = InputUtilities.getIntegerInputValue("Horsepower");
            switch (InputUtilities.getStringInputValue("yes or no option for Has Blower"))
            {
                case ("yes"):
                    hot.Blower = true;
                    break;
                case ("Yes"):
                    hot.Blower = true;
                    break;
                case ("y"):
                    hot.Blower = true;
                    break;
                case ("Y"):
                    hot.Blower = true;
                    break;
                case ("YES"):
                    hot.Blower = true;
                    break;
                default:
                    hot.Blower = false;
                    break;
            }
        }

        //method to input Street Tuner information
        public static void CollectStreetTunerInformation(StreetTuner tuner)
        {
            Console.WriteLine();
            ApplicationUtilities.DisplayDivider("Provide the information for the new Street Tuner");
            Console.WriteLine();
            tuner.Name = InputUtilities.GetInput("Racer name");
            tuner.Speed = InputUtilities.getIntegerInputValue("Racer speed");
            tuner.Eng.Cylinders = InputUtilities.getIntegerInputValue("Number of cylinders");
            tuner.Eng.Horsepower = InputUtilities.getIntegerInputValue("Horsepower");
            switch (InputUtilities.getStringInputValue("yes or no option for Has Nitrous"))
            {
                case ("yes"):
                    tuner.Nitrous = true;
                    break;
                case ("Yes"):
                    tuner.Nitrous = true;
                    break;
                case("y"):
                    tuner.Nitrous = true;
                    break;
                case("Y"):
                    tuner.Nitrous = true;
                    break;
                case("YES"):
                    tuner.Nitrous = true;
                    break;
                default:
                    tuner.Nitrous = false;
                    break;
        }
        }

    }
}

