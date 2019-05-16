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

        public Square()
        { }
        public Square(int _number)
        {
            this.number = _number;
        }

        public Square(int _number, int transition)
        {
            this.number = _number;
            this.SetTransition(transition);
        }
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

    class Normal: Square
    {
        public Normal(int num) : base(num) { }
        public override void SetTransition(int num)
        {
            this.transition = 0;
            this.type = 'N';
        }
    }

    class Snake: Square
    {

        public Snake(int num,int transition) : base(num, transition) { }
        public Snake(int num)
        {
            this.type = 'S';
            SetTransition(num);
        }

        public override void SetTransition(int num)
        {
            this.transition = -1 * num;
            this.type = 'S';
        }
    }

    class Ladder: Square
    {
        public Ladder(int num, int transition) : base(num, transition) { }
        public Ladder(int num)
        {
            this.type = 'L';
            SetTransition(num);
        }

        public override void SetTransition(int num)
        {
            this.transition = num;
            
        }
    }

    class Final: Square
    {
        public Final(int num) : base(num) { }
        public override void SetTransition(int num)
        {
            this.transition = 0;
            this.type = 'W';
        }
    }
}
