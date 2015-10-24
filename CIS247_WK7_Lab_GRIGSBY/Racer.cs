using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer
{
    abstract class Racer
    {
        private String name;
        private int speed;
        private Engine eng;

        public Racer() 
        {
            name = "";
            speed = 0;
            eng = new Engine();
        }

        public Racer(String name, int speed, Engine eng) 
        {
            Name = name;
            Speed = speed;
            Eng = eng;
        }

        public Engine Eng 
        {
            get { return eng; }
            set 
            {
                if (value == null)
                    eng = new Engine();
                else
                    eng = value;
            }
        }

        public String Name 
        {
            get { return name; }
            set 
            {
                if (value != " ")
                    name = value;
                else
                    name = "no name";
            }
        }

        public int Speed 
        {
            get { return speed; }
            set 
            {
                if (value > -1)
                    speed = value;
                else
                    speed = 0;
            }
        }

        public abstract bool IsDead();

        public virtual String ToString() 
        {
            String strReturnValue;

            strReturnValue = "          Name: " + Name + "\n" +
                             "         Speed: " + Speed + "\n" +
                             "     Cylinders: " + Eng.Cylinders + "\n" +
                             "    Horsepower: " + Eng.Horsepower + "\n";

            return strReturnValue;
        }
    }
}
