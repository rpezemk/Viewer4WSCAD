using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Viewer4WSCAD.Types.Geometry
{
    /// <summary>
    /// Class for Circle figure.
    /// </summary>
    public class Circle : AFigure
    {
        public Circle(Root root) : base(root)
        {
            var c = root.center.Split(";").Select(s => double.Parse(s)).ToList();
            Center = new Point() { X = c[0], Y = c[1] };
            Radius = (double) root.radius;
            Diameter = 2 * Radius;
            if (root.filled.HasValue)
            {
                IsFilled = root.filled.Value;
            }
            else
                IsFilled = false;
        }

        public double Diameter { get; set; }
        public Point Center { get; set; }
        public double Radius { get; set; }
        public bool IsFilled { get; set; }
        public override List<double> Boundaries => new List<double>() { Center.X - Radius, Center.Y + Radius, Center.X + Radius, Center.Y - Radius };

    }
}
