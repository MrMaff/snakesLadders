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

        public Dice Dice1 { get; } = new Dice();
        public Dice Dice2 { get; } = new Dice();
        public Dice Dice3 { get; } = new Dice();

        public int GetTotal()
        {
            bool equal;

            Dice1.Roll();
            Dice2.Roll();

            totalRoll = Dice1.FaceValue + Dice2.FaceValue;

            //equal = CompareDice();

            //if (equal)
            //{
            //    Roll3();
            //}
            return totalRoll;
        }
        private bool CompareDice()
        {
            bool equal = false;

            if (Dice1.FaceValue == Dice2.FaceValue)
            {
                equal = true;
            }
            return equal;
        }

        private void Roll3()
        {
            Dice3.Roll();

            totalRoll = totalRoll + Dice3.FaceValue;
        }
    }

}
