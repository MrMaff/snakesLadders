using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    public class Player
    {       
        private string name;  //Need a property so that the name can be read but not written to at a later date
        private string colour;
        public bool winner;        
        private Shaker shaker;
        private Square currentSquare;
        

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
        public void TakeTurn(Board GameBoard)
        {
                Move(shaker.GetTotal(), GameBoard);
        }
        
        /// <summary>
        /// Moves the player forward 'rollTotal' spaces from the current square
        /// </summary>
        /// <param name="rollTotal"></param>
        private void Move(int rollTotal, Board GameaBoard)
        {
            //A player must leave their current square then be placed in their new square.
            currentSquare.RemovePlayer(this);

            //Player.Position += total dice roll
            position += rollTotal;
            ApplyRules();

            //Given the new position, put the player in the new square.
            currentSquare.AddPlayer(this);

            
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
            if (currentSquare.Type == 'W')
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
            if (currentSquare.GetType() == )
            {

            }            
            currentSquare.SetTransition(position);   //Why change the transition value of the current square?

            //string currentSquareType;
            //currentSquareType = currentSquare.SetTransition
                     
            //currentSquare.SetTransition(position);
            //position += Transition;

            return transition;
        }

    }
}