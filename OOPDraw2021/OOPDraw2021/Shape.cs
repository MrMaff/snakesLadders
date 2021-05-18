using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    public abstract class Shape
    {
        public Pen Pen { get; protected set; }
        public int X1 { get; protected set; }
        public int X2 { get; protected set; }
        public int Y1 { get; protected set; }
        public int Y2 { get; protected set; }

        public Shape(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = p;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Shape(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1)
        { }

        public abstract void Draw(Graphics g);
        public virtual void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }

        //Helper Method
        public Tuple<int, int, int, int> EnclosingRectangle()
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x;
            int h = Math.Max(Y1, Y2) - y;

            return new Tuple<int, int, int, int>(x, y, w, h);          
        }
    }
}
