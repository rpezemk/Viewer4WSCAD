using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Viewer4WSCAD.Helpers;

namespace Viewer4WSCAD.Types.Geometry
{
    /// <summary>
    /// Class for Triangle figure.
    /// </summary>
    public class Triangle : AFigure
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
        public override List<double> Boundaries => new List<double>() { MathHelpers.Min(A.X, B.X, C.X), MathHelpers.Max(A.Y, B.Y, C.Y), MathHelpers.Max(A.X, B.X, C.X), MathHelpers.Min(A.Y, B.Y, C.Y) };
    }
}
