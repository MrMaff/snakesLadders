using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    public class Dice
    {
        private int min;
        private int max;
        private int faceValue;
        public int FaceValue { get { return faceValue; }}

        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public Dice()
        {
            min = 1;
            max = 6;
            Roll();
        }

        public void Roll()
        {
            this.faceValue = rnd.Next(min, max + 1);
        }
    }

}
