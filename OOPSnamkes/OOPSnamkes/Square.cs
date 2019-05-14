using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    abstract class Square
    {
        private int number;
        private char type;
        private List<Player> occupier;
        private int transition;

        public void AddPlayer(Player player)
        {

        }

        public void RemovePlayer()
        {

        }

        private void SetNumber(int number)
        {

        }

        public abstract void SetTransition(int num);

    }
}
