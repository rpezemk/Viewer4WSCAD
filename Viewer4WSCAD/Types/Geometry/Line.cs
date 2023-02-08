using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Viewer4WSCAD.BusinessLogic;
using PMatrix = Viewer4WSCAD.Helpers.PMatrix;

namespace Viewer4WSCAD.Types.Geometry
{

    internal class Line : AFigure
    {
        public Line(Root root) : base(root)
        {
            var a = root.a.Split(";").Select(s => double.Parse(s)).ToList();
            var b = root.b.Split(";").Select(s => double.Parse(s)).ToList();
            A = new Point() { X = a[0], Y = a[1] }; 
            B = new Point() { X = b[0], Y = b[1] }; 
        }

        public Point A { get; set; }
        public Point B { get; set; }

    }


    internal class Circle : AFigure
    {
        public Circle(Root root) : base(root)
        {
            var c = root.a.Split(";").Select(s => double.Parse(s)).ToList();
            Center = new Point() { X = c[0], Y = c[1] };
            Radius = (double) root.radius;
            if (root.filled.HasValue)
            {
                IsFilled = root.filled.Value;
            }
            else
                IsFilled = false;
        }
        public Point Center { get; set; }
        public double Radius { get; set; }
        public bool IsFilled { get; set; }
    }

    internal class Triangle : AFigure
    {
        public Triangle(Root root) : base(root)
        {
            var a = root.a.Split(";").Select(s => double.Parse(s)).ToList();
            var b = root.b.Split(";").Select(s => double.Parse(s)).ToList();
            var c = root.c.Split(";").Select(s => double.Parse(s)).ToList();
            A = new Point() { X = a[0], Y = a[1] };
            B = new Point() { X = b[0], Y = b[1] };
            C = new Point() { X = c[0], Y = c[1] };
            if (root.filled.HasValue)
            {
                IsFilled = root.filled.Value;
            }
            else
                IsFilled = false;
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public bool IsFilled { get; set; }
    }

    internal class Rectangle : AFigure
    {
        public Rectangle(Root root) : base(root)
        {
            var a = root.a.Split(";").Select(s => double.Parse(s)).ToList();
            var b = root.b.Split(";").Select(s => double.Parse(s)).ToList();
            A = new Point() { X = a[0], Y = a[1] };
            B = new Point() { X = b[0], Y = b[1] };
            if (root.filled.HasValue)
            {
                IsFilled = root.filled.Value;
            }
            else
                IsFilled = false;
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public bool IsFilled { get; set; }

    }
}
