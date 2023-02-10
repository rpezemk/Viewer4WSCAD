using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Viewer4WSCAD.Deserializers;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Helpers
{
    internal static class GH
    {

        public static AFigure GetFigure(Root root)
        {
            AFigure fig = null;
            switch (root.type) 
            {
                case "circle": 
                    fig = new Circle(root);
                    break;
                case "line":
                    fig = new Line(root);
                    break;
                case "triangle":
                    fig = new Triangle(root);
                    break;
                case "rectangle":
                    fig = new Rectangle(root);
                    break;
            }

            return fig;
        }


        public static List<double> GetBounds(List<AFigure> aFigures)
        {
            double w, n, e, s;
            w = aFigures.Select(f => f.Boundaries[0]).Min();
            n = aFigures.Select(f => f.Boundaries[1]).Max();
            e = aFigures.Select(f => f.Boundaries[2]).Max();
            s = aFigures.Select(f => f.Boundaries[3]).Min();

            return new List<double>() { w, n, e, s };
        }

        public static List<AFigure> GetFigures(string strToDeserialize, IDeserializer deserializer)
        {
            List<AFigure> Figures = new List<AFigure>();
            var roots = deserializer.GetGenericFigures(strToDeserialize);

            Figures.Clear();
            foreach (var root in roots)
            {
                var fig = GH.GetFigure(root);
                Figures.Add(fig);
            }
            return Figures;
        }

    }


}
