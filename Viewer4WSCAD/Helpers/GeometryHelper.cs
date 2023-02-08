using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Viewer4WSCAD.BusinessLogic;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Helpers
{
    internal static class GeometryHelper
    {
        public static Point TransformBy(this Point inP, PMatrix t) => t * inP;

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

    }


}
