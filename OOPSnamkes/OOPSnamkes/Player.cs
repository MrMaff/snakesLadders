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
        private int numberOfPlayers = 5;
        Player[] player = new Player[numberOfPlayers];
        //private string[] names = { "Sean", "Max", "Emily", "Alex", "Jordan" };

        public void SetName(string name)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                do
                {
                    //Ask for player name -- using placeholder insted
                    player[i].name = name;

                    //Validation to ensure name != null
                    if (player[i].name == null)
                    {
                        Console.WriteLine("You must enter a valid name!");
                        tbx_Name.Clear();
                        player[i].name = tbx_Name.Text;
                    }
                } while (player[i].name != "");
                
            }

        }

        public void SetColour(string colour)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine($"{player[i].name}, Please choose a colour");
                player[i].colour = colour;

                //Removing that colour option from the list
                cbx_Colour.SelectedValue -= cbx_Colour.Colour;
            }
        }

        public void TakeTurn()
        {
            do
            {
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    player[i].
                    //ApplyRules();
                }
            } while (winner == true);
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
