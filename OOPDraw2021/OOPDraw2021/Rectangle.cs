using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    public class Rectangle : Shape
    {

        public Rectangle(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {
        }

        public Rectangle(Pen p, int x1, int y1) : base(p, x1, y1, x1, y1)
        { }

        public override void Draw(Graphics g)
        {
            (int x, int y, int w, int h) = EnclosingRectangle();
            //int x = bounds.Item1;
            //int y = bounds.Item2;
            //int w = bounds.Item3;
            //int h = bounds.Item3;



            g.DrawRectangle(Pen, x, y, w, h);
        }

    }
}
