using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreatePlayers(List<Player> players)
        {   
            foreach (var person in players)
            {
                this.players.Enqueue(person);
            }
        }

        private void CreateBoard()
        {
            this.gameboard = new Board();
        }

        public void PlayGame()
        {

        }

    }
}
