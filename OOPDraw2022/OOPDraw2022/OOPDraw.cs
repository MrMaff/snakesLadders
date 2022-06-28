using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw2022
{
    public partial class OOPDraw : Form
    {
        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Line> lines = new List<Line>();
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true; //Stops image flickering
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            foreach (Line line in lines)
            {
                line.Draw(gr);
            }

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            lines.Add(new Line(currentPen, e.X, e.Y));
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Line currentLine = lines.Last();
                currentLine.GrowTo(e.X, e.Y);
                lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
