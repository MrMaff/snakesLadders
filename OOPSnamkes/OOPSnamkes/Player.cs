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

        //Temporary Values that would otherwise be user input
        //private int numberOfPlayers = 5;
        //Player[] player = new Player[numberOfPlayers];

        public void SetName(string name)
        {
            //code needed here to set the name of this player

        }

        public void SetColour(string colour)
        {
            //code needed here to set the colour for this player
        }

        public void TakeTurn()
        {
            //code needed here for the actions required for 1 player to take their turn:
            // • Move the number of spaces indicated by a roll of the dice
            // • Apply the rules  of the square they land on.
        }

        private void Move(int rollTotal)
        {
            // Moves the player forward 'rollTotal' spaces from the current square
        }
        
        private void ApplyRules()
        {
            //Applys the rules of the square ie it either sets the the player as a winner or it move the transition spaces.
        }

        

        private bool CheckForWin()
        {
            bool tempBool = false;  //temp return value - should checkt the square to see if it is the final square.
            return tempBool;
        }

        private void Transition()
        {
            //moves the transitions spaces.
        }

    }
}
