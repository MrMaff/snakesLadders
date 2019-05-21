using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSnamkes
{
    public class Game
    {
        private Queue<Player> players;
        private Board gameboard;
        public int NumberOfPlayers { get { return players.Count; } }

        public Game()
        {
            CreateBoard();
        }

        public void CreatePlayerQueue(List<Player> players)
        {   
            foreach (var person in players)
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
            if(null == players || players.Count <= 0)
            {
                Player currentPlayer = new Player();

                GetPlayers();
                CreateBoard();
                do
                {
                    currentPlayer = players.Dequeue();
                    currentPlayer.TakeTurn(gameboard);
                    players.Enqueue(currentPlayer);

                } while (currentPlayer.winner == false);
            }
        }

    }
}
