using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    public abstract class Square
    {
        protected int number;
        protected char type;
        protected List<Player> occupier;
        protected int transition;

        public void AddPlayer(Player player)
        {
            occupier.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            occupier.Remove(player);
        }

        protected void SetNumber(int _number)
        {
            this.number = _number;
        }

        public abstract void SetTransition(int num);

    }

    class Normal:Square
    {
        public override void SetTransition(int num)
        {
            this.transition = 0;
            this.type = 'N';
        }
    }

    class Snake:Square
    {
        public override void SetTransition(int num)
        {
            this.transition = -1 * num;
            this.type = 'S';
        }
    }

    class Ladder:Square
    {
        public override void SetTransition(int num)
        {
            this.transition = num;
            this.type = 'L';
        }
    }

    class Final:Square
    {
        public override void SetTransition(int num)
        {
            this.transition = 0;
            this.type = 'W';
        }
    }
}
