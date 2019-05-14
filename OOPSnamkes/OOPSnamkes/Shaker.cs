using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    class Shaker
    {
        private int roll;
        Dice roll1 = new Dice();
        Dice roll2 = new Dice();

        //CompareRoll(Dice roll1, Dice roll2);

        //static bool CompareRoll(Dice roll1, Dice roll2)
        //{
        //    bool equal = false;
        //    return equal;
        //}
    }

    class Dice
    {
        public int faceValue;
        private int min = 1;
        private int max = 7;

        public Dice()
        {
            Random rnd = new Random();
            faceValue = rnd.Next(min, max);
        }
    }
}
