//Paste your code below
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello
            int[] plrpstn = new int[5];
        }
        
        //changes player location
        static void Move(int place, int roll)
        {
            place = place + roll;
        }
        
        static Square[] LoadBoard()
        {
            Square[] Squares = new Square[100];

            Squares[3].Action = 10;
            Squares[3].Type = "L";

            Squares[8].Action = 22;
            Squares[8].Type = "L";

            Squares[16].Action = -10;
            Squares[16].Type = "S";

            Squares[19].Action = 18;
            Squares[19].Type = "L";

            Squares[27].Action = 56;
            Squares[27].Type = "L";

            Squares[39].Action = 19;
            Squares[39].Type = "L";

            Squares[53].Action = -20;
            Squares[53].Type = "S";

            Squares[61].Action = -44;
            Squares[61].Type = "S";

            Squares[63].Action = -4;
            Squares[63].Type = "S";

            Squares[70].Action = 20;
            Squares[70].Type = "L";

            Squares[86].Action = -70;
            Squares[86].Type = "S";

            Squares[92].Action = -20;
            Squares[92].Type = "S";

            Squares[94].Action = -20;
            Squares[94].Type = "S";

            Squares[98].Action = -21;
            Squares[98].Type = "S";

            return Squares;
        }
        static void ApplyRules(int position, int length)
        {
            Square currentsquare = squares[plrpstn[0]];
            if (currentsquare.Type == "S");
            {
                position = position - length;
            }
            if (currentsquare.Type == "L")
            {
                position = position + length;
            }
            if (currentsquare.Type == "W")
            {
                string winplayer = currentplayer;
            }
        }
    }
    
    class Square
    {
        public string Type;
        public int Action;
        public ConsoleColor? PlayerColour;
        
        public Square()
        {
            this.Type = "N";
            this.Action = 0;
            this.PlayerColour = null;
        }
    }
}
