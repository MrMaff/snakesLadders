using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    public class Rectangle
    {
        public Pen Pen { get; private set; }
        public int X1 { get; private set; }
        public int X2 { get; private set; }
        public int Y1 { get; private set; }
        public int Y2 { get; private set; }

        public Rectangle(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = p;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Rectangle(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1)
        { }

        public void Draw(Graphics g)
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x;
            int h = Math.Max(Y1, Y2) - y;
            g.DrawRectangle(Pen, x, y, w, h);
        }

        public void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }
    }
}
