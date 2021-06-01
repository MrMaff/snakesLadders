using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OOPDraw2021
{
    public abstract class Shape
    {
        public Pen Pen { get; protected set; }
        public int X1 { get; protected set; }
        public int X2 { get; protected set; }
        public int Y1 { get; protected set; }
        public int Y2 { get; protected set; }
        public bool Selected { get; private set; }


        public Shape(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = new Pen(p.Color, p.Width);
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Shape(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1)
        { }

        public abstract void Draw(Graphics g);
        public abstract Shape Clone();

        public virtual void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }

        public virtual void MoveBy(int xDelta, int yDelta)
        {
            X1 += xDelta;
            Y1 += yDelta;
            X2 += xDelta;
            Y2 += yDelta;
        }

        public virtual void Select()
        {
            this.Selected = true;
            Pen.DashStyle = DashStyle.Dash;
        }

        public virtual void Deselect()
        {
            this.Selected = false;
            Pen.DashStyle = DashStyle.Solid;
        }

        //Helper Method
        public (int, int, int, int) EnclosingRectangle()
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x;
            int h = Math.Max(Y1, Y2) - y;

            return (x, y, w, h);          
        } 
    }
}
