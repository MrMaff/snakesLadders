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

        Dice roll1;
        Dice roll2;

        public int GetTotal()
        {
            bool equal;

            roll1 = new Dice();
            roll2 = new Dice();

            totalRoll = roll1.FaceValues + roll2.FaceValues;

            equal = CompareDice();

            if (equal)
            {
                Roll3();
            }
            return totalRoll;
        }
        private bool CompareDice()
        {
            bool equal = false;

            if (roll1.FaceValues == roll2.FaceValues)
            {
                equal = true;
            }
            return equal;
        }

        private void Roll3()
        {
            Dice roll3 = new Dice();

            totalRoll = totalRoll + roll3.FaceValues;
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
