using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class Engine
    {
        private int cylinders;
        private int horsepower;

        public Engine() 
        {
            cylinders = 0;
            horsepower = 0;
        }

        public int Horsepower 
        {
            get { return horsepower; }
            set 
            {
                if (value > 0)
                    horsepower = value;
                else
                    horsepower = 0;
            }
        }

        public int Cylinders 
        {
            get { return cylinders; }
            set 
            {
                if (value > -1)
                    cylinders = value;
                else
                    cylinders = 0;
            }
        }

        public String ToString() 
        {
            String strReturnValue;

            strReturnValue = "          Cylinders: " + cylinders + "\n" +
                             "         Horsepower: " + horsepower + "\n";

            return strReturnValue;
        }
    }
}
