using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    public class Player
    {
        //Console.WriteLine is a placeholder for a display to the screen

        private string name;
        private string colour;
        private Square currentSquare;
        public bool winner;
        public int playerNumber;

        //Temporary Values that would otherwise be user input
        private int numberOfPlayers = 5;
        private string[] names = { "Sean", "Max", "Emily", "Alex", "Jordan" };

        public void SetName()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player Player = new Player();
                do
                {
                    //Ask for player name -- using placeholder insted
                    Player.name = names[i];
                    if (names[i] == null)
                    {
                        Console.WriteLine("You must enter a valid name!");
                    }
                } while (Player.name != "");
                Player.playerNumber = i;
            }
            SetColour();
        }

        public void SetColour()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
               
            }
        }

        public void TakeTurn()
        {

        }

        private void ApplyRules()
        {

        }

        private void Move()
        {

        }

        private bool CheckForWin()
        {
            bool tempBool = false;
            return tempBool;
        }

        private void Transition()
        {

        }

    }
}
