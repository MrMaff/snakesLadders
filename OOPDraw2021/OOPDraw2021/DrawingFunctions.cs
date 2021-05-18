using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw2021
{
    public class DrawingFunctions
    {
        public static void DrawClosedArc(Graphics g, Shape shape)
        {
            (int x, int y, int w, int h) = shape.EnclosingRectangle();
            if (w> 0 &&h >0)
            {
                g.DrawArc(shape.Pen, x, y, w, h, 0F, 360F);
            }
        }
    }
}
