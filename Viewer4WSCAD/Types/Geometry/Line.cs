using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

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
        public override List<double> Boundaries => new List<double>() { Math.Min(A.X, B.X), Math.Max(A.Y, B.Y), Math.Max(A.X, B.X), Math.Min(A.Y, B.Y) };
    }
}
