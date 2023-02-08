using System;
using System.Windows;

namespace Viewer4WSCAD.Helpers
{

    public static class MathHelpers
    {
        public static double Log2Lin(double inVal, double maxScale = 10)
        {
            return Math.Pow(maxScale, inVal);
        }

    }


    public class PMatrix
    {
        public double A { get; set; } = 1;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;
        public double D { get; set; } = 1;

        public static Point operator *(PMatrix m, Point p)
        {
            Point res = new Point();
            res.X = m.A * p.X + m.B * p.Y; 
            res.Y = m.C * p.X + m.D * p.Y; 
            return res;
        }

        public double Scale { get => A * D - B * C; }

    }
}
