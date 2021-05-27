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
            cbx_Action.SelectedItem = "Draw";
        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Shape> shapes = new List<Shape>();
        Rectangle selectionBox;

        private void pbx_Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Shape shape in shapes)
            {
                shape.Draw(gr);
            }
            if (selectionBox != null) selectionBox.Draw(gr);
        }

        private void pbx_Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;

            switch (cbx_Action.Text)
            {
                case "Draw":
                    AddShape(e);
                    break;
                case "Select":
                    Pen p = new Pen(Color.Black, 1.0F);
                    selectionBox = new Rectangle(p, startOfDrag.X, startOfDrag.Y);
                    break;
            }

        }

        private void AddShape(MouseEventArgs e)
        {

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
                

                switch (cbx_Action.Text)
                {
                    case "Move":                    
                        MoveSelectedShapes(e);
                        break;
                    case "Draw":
                        Shape shape = shapes.Last();
                        shape.GrowTo(e.X, e.Y);
                        break;
                    case "Select":
                        this.selectionBox.GrowTo(e.X, e.Y);
                        this.SelectShapes();
                        break;
                }

                lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void pbx_Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            lastMousePosition = Point.Empty;
            selectionBox = null;
            Refresh();
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

        private void DeselectAll()
        {
            foreach(Shape s in shapes)
            {
                s.Deselect();
            }
        }

        private void SelectShapes()
        {
            DeselectAll();
            foreach(Shape s in shapes)
            {
                if (selectionBox.FullSurrounds(s)) s.Select();
            }
        }

        private List<Shape> GetSelectedShapes()
        {
            return shapes.Where(s => s.Selected).ToList();
        }

        private void MoveSelectedShapes(MouseEventArgs e)
        {
            foreach (Shape s in GetSelectedShapes())
            {
                s.MoveBy(e.X - lastMousePosition.X, e.Y - lastMousePosition.Y);
            }

        }

        private void cbx_Action_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_Action.Text)
            {
                case "Group":
                    GroupSelectedShapes();
                    break;
                case "Delete":
                    DeleteSelectedShapes();
                    break;
                case "Duplicate":
                    DuplicateSelectedShapes();
                    break;
            }
        }

        private void GroupSelectedShapes()
        {
            var members = GetSelectedShapes();
            if (members.Count < 2) return; //Group has no effect
            CompositeShape compS = new CompositeShape(members);
            compS.Select();
            shapes.Add(compS);
            foreach (Shape m in members)
            {
                shapes.Remove(m);
                m.Deselect();
            }
            Refresh();
        }

        private void DeleteSelectedShapes()
        {
            foreach (Shape s in GetSelectedShapes())
            {
                shapes.Remove(s);
            }
            Refresh();
        }

        private void DuplicateSelectedShapes()
        {
            foreach (Shape s in GetSelectedShapes())
            {
                s.Deselect();
                Shape tempShape = s.Clone();
                tempShape.MoveBy(50, 50);
                tempShape.Select();
                shapes.Add(tempShape);
            }
            Refresh();
        }
    }
}
