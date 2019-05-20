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
        public bool winner;
        private int position;
        private Shaker shaker;
        private Square currentSquare;
        private Board board;
        private Normal normal;
        private Snake snake;
        private Ladder ladder;
        private Final final;

        public Player()
        {
            shaker = new Shaker();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetColour(string colour)
        {            
            this.colour = colour;
        }

        /// <summary>
        /// The actions required for 1 player to take their turn:
        /// • Move the number of spaces indicated by a roll of the dice,
        /// • Apply the rules  of the square they land on.
        /// </summary>
        public void TakeTurn()
        {
            do
            {
                Move(shaker.GetTotal());
            } while (winner == false);            
        }
        
        /// <summary>
        /// Moves the player forward 'rollTotal' spaces from the current square
        /// </summary>
        /// <param name="rollTotal"></param>
        private void Move(int rollTotal)
        {
            //Player.Position += total dice roll
            position += rollTotal;

            ApplyRules();
        }

        /// <summary>
        /// Applys the rules of the square ie it either sets the the player as a winner or it move the transition spaces.
        /// </summary>
        private void ApplyRules()
        {
            position += Transition(); 
            
            CheckForWin();
        }


        /// <summary>
        /// Checks if the currentsquare == finalsquare. If so, winner == true and that player wins.
        /// </summary>
        /// <returns></returns>
        private bool CheckForWin()
        {
            if (currentSquare.GetType() == final.GetType())
            {
                winner = true;
            }

            return winner;
        }

        /// <summary>
        /// //Redefines the Player.position based off the transition effect
        /// </summary>
        /// <returns></returns>
        private int Transition()
        {            
            int transition = 0;

            currentSquare.SetTransition(position); 

            //string currentSquareType;
            //currentSquareType = currentSquare.SetTransition
                     
            //currentSquare.SetTransition(position);
            //position += Transition;

            return transition;
        }

    }
}