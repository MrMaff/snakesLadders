using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    public class Shaker
    {
        private int totalRoll = 0;

        Dice roll1 = new Dice();
        Dice roll2 = new Dice();

        public void GetTotal()
        {
            totalRoll = roll1.FaceValues + roll2.FaceValues;
        }
        static bool CompareDice(Dice roll1, Dice roll2)
        {
            bool equal = false;

            if (roll1.FaceValues == roll2.FaceValues)
            {
                equal = true;
            }
            return equal;
        }
    }

    class Dice
    {
        private int faceValue;
        private int min = 1;
        private int max = 6;

        public int FaceValues
        {
            get
            {
                return faceValue;
            }
        }
        public Dice()
        {
            Random rnd = new Random();
            faceValue = rnd.Next(min, max + 1);
        }
    }
}
