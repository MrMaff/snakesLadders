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
            this.players = new Queue<Player>();

            foreach (var person in players)
            {
                this.players.Enqueue(person);
                this.players.Last().SetSquare(gameboard.Squares[0]);
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

            Player currentPlayer = new Player();

            CreateBoard();
            GetPlayers();

            if ((null != players && players.Count >= 0))
            {
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
