using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw2021
{
    public partial class OOPDraw : Form
    {
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true;
            cbx_LineWidth.SelectedItem = "Medium";
            cbx_Colour.SelectedItem = "Green";
            cbx_Shape.SelectedItem = "Line";
        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Shape> shapes = new List<Shape>();

        private void pbx_Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Shape shape in shapes)
            {
                shape.Draw(gr);
            }
        }

        private void pbx_Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            switch (cbx_Shape.Text)
            {
                case "Line":
                    shapes.Add(new Line(currentPen, e.X, e.Y));
                    break;
                case "Rectangle":
                    shapes.Add(new Rectangle(currentPen, e.X, e.Y));
                    break;
                case "Ellipse":
                    shapes.Add(new Ellipse(currentPen, e.X, e.Y));
                    break;
                case "Cirlce":
                    shapes.Add(new Circle(currentPen, e.X, e.Y));
                    break;
            }


        }

        private void pbx_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Shape shape = shapes.Last();
                shape.GrowTo(e.X, e.Y);
                lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void pbx_Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void cbx_LineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = currentPen.Width;
            switch (cbx_LineWidth.Text)
            {
                case "Thin":
                    width = 2.0F;
                    break;
                case "Medium":
                    width = 4.0F;
                    break;
                case "Thick":
                    width = 8.0F;
                    break;
            }
            currentPen = new Pen(currentPen.Color, width);
        }

        private void cbx_Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color colour = currentPen.Color;
            switch(cbx_Colour.Text)
            {
                case "Red":
                    colour = Color.Red;
                    break;
                case "Green":
                    colour = Color.Green;
                    break;
                case "Blue":
                    colour = Color.Blue;
                    break;
            }
            currentPen = new Pen(colour, currentPen.Width);
        }
    }
}
