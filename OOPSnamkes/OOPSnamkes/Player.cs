using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace OOPSnamkes
{
    public class Player
    {       
        private string name;  //Need a property so that the name can be read but not written to at a later date
        private string colour;
        public bool winner;        
        private Shaker shaker;
        private Square currentSquare;
        public string Name { get { return name; } }
        public string Colour { get { return colour; } }
        public string CurrentSqaure { get { return currentSquare.Number.ToString(); } }

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
                ApplyRules(GameBoard);
        }

        /// <summary>
        /// Moves the player forward 'rollTotal' spaces from the current square
        /// A player must leave their current square then be placed in their new square.
        /// </summary>
        /// <param name="rollTotal"></param>
        public void Move(int rollTotal, Board GameBoard)
        {
            currentSquare.RemovePlayer(this);

            int temp = currentSquare.Number + rollTotal - 1;

            if(temp >= 100)
            {
                this.currentSquare = GameBoard.Squares[99];
            }else
            {
                this.currentSquare = GameBoard.Squares[temp];
            }



            //Given the new position, put the player in the new square.
            currentSquare.AddPlayer(this);

            
            
        }

        public void SetSquare(Square CurrentSquare)
        {
            this.currentSquare = CurrentSquare;
            this.currentSquare.AddPlayer(this);
        }

        /// <summary>
        /// Applys the rules of the square ie it either sets the the player as a winner or it move the transition spaces.
        /// </summary>
        public void ApplyRules(Board GameBoard)
        {
            if(currentSquare.Type == 'S' || currentSquare.Type == 'L')
            {
                Move(currentSquare.Transition, GameBoard);
                MessageBox.Show($" You have landed on a {currentSquare.Type}");
            }
            
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
    }
}