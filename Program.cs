using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class Player
    {
        protected string name;
        protected string colour;

        public Player(string _name, string _colour)
        {
            this.name = _name;
            this.colour = _colour;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
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
    class Program
    {


        static void Main(string[] args)
        {
            int numOfPlayers = 0;
            CollectData(ref numOfPlayers);
            int[] plrpstn = new int[5];
        }

        public static void CollectData(ref int numOfPlayers)
        {
            List<string> colourOptions = new List<string>(new string[] { "Red", "Green", "Blue", "Cyan", "Magenta" });

            bool intCheck = false;
            while (intCheck == false)
            {
                Console.WriteLine("Please enter the number of players(between 2 - 5): ");
                intCheck = int.TryParse(Console.ReadLine(), out numOfPlayers);

                if (numOfPlayers < 2 || numOfPlayers > 5)
                    intCheck = false;

                if (intCheck == false)
                {
                    Console.WriteLine("Invalid entry! Please try again!");
                }
            }

            Player[] players = new Player[numOfPlayers];

            //Collects names of players and colour chosen.
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("");
                string currentName = "";
                string currentColour = "";

                Console.WriteLine("Player {0}, please enter your name: ", i + 1);
                currentName = Console.ReadLine();

                bool colourCheck = false;
                while (colourCheck == false)
                {
                    int colourChoice = 0;
                    Console.WriteLine("Which colour would you like to use?");
                    for (int x = 0; x < colourOptions.Count; x++)
                        Console.WriteLine("{0}. {1}", x + 1, colourOptions[x]);

                    colourCheck = int.TryParse(Console.ReadLine(), out colourChoice);
                    if (colourChoice < 1 || colourChoice > 5)
                        colourCheck = false;
                    if (colourCheck == false)
                        Console.WriteLine("Invalid entry! Please try again!");
                    else
                    {
                        currentColour = colourOptions[colourChoice - 1];
                        colourOptions.RemoveAt(colourChoice - 1);
                    }
                    players[i] = new Player(currentName, currentColour);
                }
                Console.ReadKey();
            }


        }

        //changes player location
        static void Move(int place, int roll)
        {
            int dieroll = 0;
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

            Squares[99].Type = "W";
            return Squares;
        }

        static void ApplyRules(int position, int length)
        {
            Square currentsquare = squares[plrpstn[0]];
            if (currentsquare.Type == "S") ;
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

        static int GetDieValue()
        {
            int roll1;
            int roll2;
            bool doubleTurn = false;
            int total = 0;

            //Rolls dice twice
            roll1 = RollDice();
            Thread.Sleep(15);
            roll2 = RollDice();

            Console.WriteLine(roll1);
            Console.WriteLine(roll2);

            //Checks if values the same. If so, returns bool true
            doubleTurn = Double(roll1, roll2);

            //Adds total of two rolls
            total = CalculateTotal(roll1, roll2) + total;

            //If first two rolls double, rolls third dice
            if (doubleTurn == true)
            {
                total = total + RollDice();
            }

            return total;
        }

        static int RollDice()
        {
            int random = 0;

            //Creates dice values
            Random randomNumber = new Random();
            return random = randomNumber.Next(1, 7);
        }

        static bool Double(int roll1, int roll2)
        {
            bool doubleTurn = false;

            //Checks to see if values the same
            if (roll1 == roll2)
            {
                Console.WriteLine("You got a double!!");
                doubleTurn = true;
            }

            return doubleTurn;
        }

        static int CalculateTotal(int roll1, int roll2)
        {
            //Creates total of rolls
            int total = roll1 + roll2;
            return total;
        }
    }
}
