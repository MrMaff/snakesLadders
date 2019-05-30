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
        public Board gameboard;
        public int NumberOfPlayers { get { return players.Count; } }
        public Player CurrentPlayer
            { get { return players.Peek();} }

        public Game()
        {
            CreateBoard();
        }

        public void CreatePlayerQueue(List<Player> newplayers)
        {   
            foreach (var person in newplayers)
            {
                this.players.Enqueue(person);
                this.players.Last().SetSquare(gameboard.Squares[0]);
            }
        }

        private bool GetPlayers()
        {
            bool readytoplay;
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();
            if (addPlayerForm.DialogResult == DialogResult.OK)
            {
                CreatePlayerQueue(addPlayerForm.Players);
                readytoplay = true;
            }
            else
            {
                Console.Beep();
                readytoplay = false;
            }
            addPlayerForm.Dispose();
            return readytoplay;
        }

        private void CreateBoard()
        {
            this.gameboard = new Board();
        }

        public void PlayGame()
        {
            
            CreateBoard();
            if (GetPlayers())
            {
                TableTop tableTop = new TableTop(this);

                tableTop.Show();
                //Player currentPlayer = new Player();
                //do
                //{
                //    currentPlayer = players.Dequeue();

                //    currentPlayer.TakeTurn(gameboard);
                //    players.Enqueue(currentPlayer);

                //} while (currentPlayer.winner == false);
            }

        }
        public void NextPlayer()
        {
            players.Enqueue(players.Dequeue());
        }

    }
}
