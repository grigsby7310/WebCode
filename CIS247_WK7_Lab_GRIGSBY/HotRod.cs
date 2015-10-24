using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    class HotRod : Racer
    {
        private bool blower;

        public HotRod() 
            :base()
        {
            blower = false;
        }

        public HotRod(String name, int speed, Engine eng, bool blower)
            :base(name, speed, eng)
        {

        }

        public bool Blower 
        {
            get { return blower; }
            set 
            {
                blower = value;
            }
        }

       public override bool IsDead() 
        {
           bool dead;

            Random rnd = new Random();

            if (Speed > 50 && rnd.NextDouble() > 0.6)
            {
                if (Eng.Horsepower < 300 && blower == true)
                    dead = false;
                else
                    dead = true;
            }
            else if (Speed > 100 && rnd.NextDouble() > 0.4)
            {
                if (Eng.Horsepower >= 300 && blower == true)
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
                                "        Blower: " + Blower.ToString();
           return strReturnValue;
       }
    }
}
