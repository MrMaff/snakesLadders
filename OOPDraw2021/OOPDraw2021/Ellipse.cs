using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    class Ellipse : Shape
    {
        public Ellipse(Pen p, int x1, int y1) : base(p, x1, y1)
        {
        }

        public Ellipse(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {
        }

        public override Shape Clone()
        {
            return new Ellipse(Pen, X1, Y1, X2, Y2);
        }

        public override void Draw(Graphics g)
        {
            DrawingFunctions.DrawClosedArc(g, this);
        }
    }
}
