using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class StreetTuner : Racer
    {
        private bool nitrous;

        public StreetTuner() 
            :base()
        {
            nitrous = false;
        }

        public StreetTuner(String name, int speed, Engine eng, bool nitrous) 
            :base(name, speed, eng)
        {

        }
        
        public bool Nitrous
        {
            get { return nitrous; }
            set
            {
                nitrous = value;
            }
        }

        public override bool IsDead()
        {
            Random rnd = new Random();
            bool dead;

            if (Speed > 50 && rnd.NextDouble() > 0.6)
            {
                if (Eng.Horsepower < 300 && nitrous == true)
                    dead = false;
                else
                    dead = true;
            }
            else if (Speed > 100 && rnd.NextDouble() > 0.4)
            {
                if (Eng.Horsepower >= 300 && nitrous == true)
                    dead = true;
                else
                    dead = false;
            }
            else
                dead = false;

            return dead;
        }
        
        public override string ToString()
        {
            String strReturnValue;

            strReturnValue = base.ToString() + 
                                 "          Dead: " + IsDead() + "\n" +
                                 "       Nitrous: " + Nitrous.ToString();
            return strReturnValue;
        }
    }
}
