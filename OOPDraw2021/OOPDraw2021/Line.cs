using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    public class Line
    {
        public Pen Pen { get; private set; }
        public int X1 { get; private set; }
        public int X2 { get; private set; }
        public int Y1 { get; private set; }
        public int Y2 { get; private set; }
    
        public Line(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = p;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2; 
        }

        public Line(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1)
        { }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, X1, Y1, X2, Y2);
        }

        public void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }

    }
}
