using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    class Shaker
    {
        private int totalroll;
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        
        public void GetTotal()
        {

        }

        static void CompareDice()
        {

        }

        static void Roll3()
        {

        }
    }

    class Dice
    {
        private int roll;

        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                this.roll = value;
            }
        }
        public Dice()
        {
            Random rnd = new Random();
            this. roll = rnd.Next(1, 7);
        }

    }
}
