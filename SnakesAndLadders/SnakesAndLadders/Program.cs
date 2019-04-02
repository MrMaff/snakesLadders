﻿using System;
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
        protected int position;

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

        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }

    class Square
    {
        protected string type;
        protected int action;
        protected ConsoleColor? playerColour;

        public string Type
        {
            get { return this.type; }
            set
            {
                if ((value == "S") || (value == "L") || (value == "N"))
                {
                    this.type = value;
                }
                else this.type = "N";
            }
        }


        public int Action
        {
            get { return this.action; }
            set { this.action = value; }
        }

        public ConsoleColor? PlayerColour
        {
            get { return this.playerColour; }
            set { this.playerColour = value; }
        }

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
        static void Move(Player player, int roll)
        {
            player.Position += roll;

        }

        static Square[] LoadBoard()
        {
            Square[] Squares = new Square[100];

            for (int i = 0; i < Squares.Length; i++)
            {
                Squares[i] = new Square();
            }

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

        //static void ApplyRules(int position, int length)
        //{
        //    Square currentsquare = squares[plrpstn[0]];
        //    if (currentsquare.Type == "S") ;
        //    {
        //        position = position - length;
        //    }
        //    if (currentsquare.Type == "L")
        //    {
        //        position = position + length;
        //    }
        //    if (currentsquare.Type == "W")
        //    {
        //        string winplayer = currentplayer;
        //    }
        //}

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

        public static void DisplayBoard(Square[] Squares)
        {
            Console.Clear();
            ConsoleColor BackgroundColour = Console.BackgroundColor;

            //Loops through the rows
            for (int y = 0; y < 10; y++)
            {
                //goes through the top of a row
                for (int i = 0; i <= 100; i++)
                {
                    //checks to see if there is new column
                    if (i % 10 == 0)
                    {
                        //works out what square it is in
                        int temp = CalculateLocation(i, y);

                        //checks to see if the current square is occupied
                        if (Squares[temp - 1].PlayerColour != null)
                        {
                            //changes the colour
                            Console.BackgroundColor = (ConsoleColor)Squares[temp - 1].PlayerColour;
                        }
                        else
                        {
                            //puts the colour back
                            Console.BackgroundColor = BackgroundColour;
                        }
                        //prints the column divider
                        Console.Write("█");
                    }
                    else
                    {
                        //prints the row divider
                        Console.Write("▀");
                    }
                }
                //moves to the next line
                Console.Write("\n");


                //does the middle of the row
                for (int i = 0; i <= 100; i++)
                {
                    //checks to see if its at the number location
                    if (i % 10 == 2)
                    {
                        //finds the current square
                        int temp = CalculateLocation(i, y);

                        //prints the square number
                        Console.Write(temp);

                        //accounts for any extra characters
                        i += temp.ToString().Length - 1;
                    }
                    //checks to see if it is at a new column
                    else if (i % 10 == 0)
                    {
                        //finds the current square
                        int temp = CalculateLocation(i, y);

                        //checks to see if that square is occupied
                        if (Squares[temp - 1].PlayerColour != null)
                        {
                            Console.BackgroundColor = (ConsoleColor)Squares[temp - 1].PlayerColour;
                        }
                        else
                        {
                            Console.BackgroundColor = BackgroundColour;
                        }
                        //prints the new column
                        Console.Write("█");
                    }
                    //checks to see if its at a point for printing square details
                    else if (i % 10 == 6)
                    {
                        //finds the current square
                        int temp = CalculateLocation(i, y);

                        temp--;

                        //checks to see if that square has any actions
                        if (Squares[temp].Type != "N")
                        {
                            //Collects the details to print
                            string toPrint = Squares[temp].Type + Math.Sqrt(Math.Pow(Squares[temp].Action, 2)).ToString();

                            //writes the to the screen
                            Console.Write(toPrint);
                            i += toPrint.Length - 1;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                //goes to a new line
                Console.Write("\n");

                //loops through the bottom of each row
                for (int i = 0; i <= 100; i++)
                {
                    //checks to see if it has hit a new column
                    if (i % 10 == 0)
                    {
                        //finds the current square
                        int temp = CalculateLocation(i, y);

                        //checks to see if this square is occupied
                        if (Squares[temp - 1].PlayerColour != null)
                        {
                            //changes the colour to the player colour
                            Console.BackgroundColor = (ConsoleColor)Squares[temp - 1].PlayerColour;
                        }
                        else
                        {
                            //changes the colour back to its original equation
                            Console.BackgroundColor = BackgroundColour;
                        }
                        //prints the column border
                        Console.Write("█");
                    }
                    else
                    {
                        //prints the row border
                        Console.Write("▄");
                    }
                }
                //prints the new line
                Console.Write("\n");
            }


            //goes back to the top of the screen.
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = BackgroundColour;




            //PrintSnakes(Squares);
            //PrintLadders(Squares);
            //JustText(Squares);
        }

        public static int CalculateLocation(int i, int y)
        {

            //complicated maths
            int temp = (((i - (i % 10)) / 10) + 1);
            int temp2 = temp;
            temp += y * 10;
            temp = temp + (y % 2) * (9 - (temp2 - 1) * 2);
            temp = 101 - temp;
            return temp;
        }

        public static void PrintLadders(Square[] Squares)
        {
            for (int i = 0; i < Squares.Length; i++)
            {
                if (Squares[i].Type == "L")
                {
                    int startingPointX;
                    int startingPointY;
                    int endingPointX;
                    int endingPointY;
                    int newLocation = i + Squares[i].Action;
                    double gradient;

                    if ((i / 10) % 2 == 0)
                    {
                        startingPointX = (((i % 10)) * 10) + 6;
                        startingPointY = ((10 - (i / 10)) * 3) - 2;
                    }
                    else
                    {
                        startingPointX = ((9 - (i % 10)) * 10) + 6;
                        startingPointY = ((10 - (i / 10)) * 3) - 2;
                    }

                    if ((newLocation / 10) % 2 == 0)
                    {
                        endingPointX = (((newLocation % 10)) * 10) + 6;
                        endingPointY = ((10 - (newLocation / 10)) * 3) - 2;
                    }
                    else
                    {
                        endingPointX = ((9 - (newLocation % 10)) * 10) + 6;
                        endingPointY = ((10 - (newLocation / 10)) * 3) - 2;
                    }

                    gradient = (double)(startingPointY - endingPointY) / (double)(endingPointX - startingPointX);
                    if (gradient == double.PositiveInfinity)
                    {
                        double x = startingPointX;
                        for (int y = startingPointY; y >= endingPointY; y--)
                        {
                            PrintSomething((int)x, (int)y);
                            PrintSomething((int)x + 1, (int)y);
                        }
                    }
                    else if (gradient < 0)
                    {
                        double y = startingPointY;
                        for (int x = startingPointX; x >= endingPointX; x--)
                        {
                            PrintSomething((int)x, (int)y);
                            PrintSomething((int)x + 1, (int)y);
                            if (gradient < -1)
                            {
                                PrintSomething((int)x + 1, (int)y + 1);
                                PrintSomething((int)x, (int)y + 1);
                            }
                            y -= (-gradient);
                        }
                    }
                    else
                    {
                        double y = startingPointY;
                        for (int x = startingPointX; x <= endingPointX; x++)
                        {
                            PrintSomething((int)x, (int)y);
                            PrintSomething((int)x + 1, (int)y);
                            if (gradient > 1)
                            {
                                PrintSomething((int)x + 1, (int)y + 1);
                                PrintSomething((int)x, (int)y + 1);
                            }
                            y -= (gradient);
                        }
                    }


                }
            }
        }

        public static void PrintSomething(int x, int y, ConsoleColor Colour = ConsoleColor.Magenta)
        {
            Console.SetCursorPosition(x, y);
            ConsoleColor temp;
            temp = Console.ForegroundColor;
            Console.ForegroundColor = Colour;
            Console.Write("█");
            Console.ForegroundColor = temp;
        }

        private static void JustText(Square[] Squares)
        {
            ConsoleColor temp2 = Console.BackgroundColor;
            //Loops through the rows
            for (int y = 0; y < 10; y++)
            {

                //does the middle of the row
                for (int i = 0; i <= 100; i++)
                {
                    //checks to see if its at the number location
                    if (i % 10 == 2)
                    {
                        //finds the current square
                        int temp = CalculateLocation(i, y);

                        Console.SetCursorPosition(i, (y * 3) + 1);

                        //prints the square number
                        Console.Write(temp);

                        //accounts for any extra characters
                        i += temp.ToString().Length - 1;
                    }
                }
            }
        }

        public static void PrintSnakes(Square[] Squares)
        {
            for (int i = 0; i < Squares.Length; i++)
            {
                if (Squares[i].Type == "S")
                {
                    int startingPointX;
                    int startingPointY;
                    int endingPointX;
                    int endingPointY;
                    int newLocation = i + Squares[i].Action;
                    double gradient;

                    if ((i / 10) % 2 == 0)
                    {
                        startingPointX = (((i % 10)) * 10) + 6;
                        startingPointY = ((10 - (i / 10)) * 3) - 2;
                    }
                    else
                    {
                        startingPointX = ((9 - (i % 10)) * 10) + 6;
                        startingPointY = ((10 - (i / 10)) * 3) - 2;
                    }

                    if ((newLocation / 10) % 2 == 0)
                    {
                        endingPointX = (((newLocation % 10)) * 10) + 6;
                        endingPointY = ((10 - (newLocation / 10)) * 3) - 2;
                    }
                    else
                    {
                        endingPointX = ((9 - (newLocation % 10)) * 10) + 6;
                        endingPointY = ((10 - (newLocation / 10)) * 3) - 2;
                    }

                    gradient = (double)(startingPointY - endingPointY) / (double)(endingPointX - startingPointX);
                    if (gradient == double.NegativeInfinity)
                    {
                        double x = startingPointX;
                        for (int y = startingPointY; y <= endingPointY; y++)
                        {
                            ConsoleColor Colour;
                            if (y % 2 == 0)
                            {
                                Colour = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Colour = ConsoleColor.DarkYellow;
                            }
                            PrintSomething((int)x, (int)y, Colour);
                            PrintSomething((int)x + 1, (int)y, Colour);
                        }
                    }
                    else if (gradient < 0)
                    {
                        double y = startingPointY;
                        for (int x = startingPointX; x <= endingPointX; x++)
                        {
                            ConsoleColor Colour;
                            if (x % 2 == 0)
                            {
                                Colour = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Colour = ConsoleColor.DarkYellow;
                            }
                            PrintSomething((int)x, (int)y, Colour);
                            PrintSomething((int)x + 1, (int)y, Colour);
                            if (gradient < -1)
                            {
                                PrintSomething((int)x + 1, (int)y + 1, Colour);
                                PrintSomething((int)x, (int)y + 1, Colour);
                            }
                            y -= (gradient);

                        }
                    }
                    else
                    {
                        double y = startingPointY;
                        for (int x = startingPointX; x >= endingPointX; x--)
                        {
                            ConsoleColor Colour;
                            if (x % 2 == 0)
                            {
                                Colour = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Colour = ConsoleColor.DarkYellow;
                            }
                            PrintSomething((int)x, (int)y, Colour);
                            PrintSomething((int)x + 1, (int)y, Colour);
                            if (gradient > 1)
                            {
                                PrintSomething((int)x + 1, (int)y + 1, Colour);
                                PrintSomething((int)x, (int)y + 1, Colour);
                            }
                            y -= (-gradient);
                        }
                    }



                }
            }
        }
    }
}