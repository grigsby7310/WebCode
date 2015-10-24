using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class ApplicationUtilities
    {
        public static void DisplayApplicationInformation()
        {
            Console.WriteLine("Welcome to the Racer Application");
            Console.WriteLine("CIS247a, Week 7 Solution");
            Console.WriteLine("Name: Kyle Grigsby");
            Console.WriteLine("This program implements a complete inheritance hierarchy using abstract\nclasses and dynamic binding");
            Console.WriteLine();
        }
        public static void DisplayDivider(string outputTitle)
        {
            Console.WriteLine("\n********* " + outputTitle + " *********");
        }
        public static void BenefitDivider(string outputTitle) 
        {
            Console.WriteLine("     ========= " + outputTitle + " =========");
        }
        public static void TerminateApplication()
        {
            DisplayDivider("Program Termination");
            Console.WriteLine();
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }
        public static void PauseExecution()
        {
            Console.Write("\nProgram paused, press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}

