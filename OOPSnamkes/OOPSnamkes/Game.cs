using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSnamkes  //MLO
{
    public class Game
    {
        private Queue<Player> players = new Queue<Player>();
        private Board gameboard;
        public int NumberOfPlayers { get { return players.Count; } }

        public Game()
        {
            CreateBoard();
        }

        public void CreatePlayerQueue(List<Player> newplayers)
        {   
            foreach (var person in newplayers)
            {
                this.players.Enqueue(person);
            }
        }

        private void GetPlayers()
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();
            if (addPlayerForm.DialogResult == DialogResult.OK)
            {
                CreatePlayerQueue(addPlayerForm.Players);
            }
            else
            {
                Console.Beep();
            }
            addPlayerForm.Dispose();
        }

        private void CreateBoard()
        {
            this.gameboard = new Board();
        }

        public void PlayGame()
        {

            GetPlayers();
            CreateBoard();

                Player currentPlayer = new Player();

                    do
                    {
                        currentPlayer = players.Dequeue();
                        currentPlayer.TakeTurn(gameboard);
                        players.Enqueue(currentPlayer);

                    } while (currentPlayer.winner == false);
      
        }

    }
}
