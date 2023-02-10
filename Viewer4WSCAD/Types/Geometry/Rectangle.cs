using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Viewer4WSCAD.Types.Geometry
{
    /// <summary>
    /// Class for Rectangle figure.
    /// </summary>
    public class Rectangle : AFigure
    {
        public Rectangle(Root root) : base(root)
        {
            var a = root.a.Split(";").Select(s => double.Parse(s)).ToList();
            var b = root.b.Split(";").Select(s => double.Parse(s)).ToList();
            A = new Point() { X = a[0], Y = a[1] };
            B = new Point() { X = b[0], Y = a[1] };
            C = new Point() { X = b[0], Y = b[1] };
            D = new Point() { X = a[0], Y = b[1] };
             
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
        public Point D { get; set; }
        public bool IsFilled { get; set; }
        public override List<double> Boundaries => new List<double>() { Math.Min(A.X, C.X), Math.Max(A.Y, C.Y), Math.Max(A.X, C.X), Math.Min(A.Y, C.Y) };
    }
}
