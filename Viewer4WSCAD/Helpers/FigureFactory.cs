using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Helpers
{
    public class FigureFactory
    {

        public static readonly Dictionary<string, Type> FigureDictionary = new Dictionary<string, Type>()
        {
            { "line", typeof(Line) },
            { "circle", typeof(Circle) },
            { "triangle", typeof(Triangle) },
            { "rectangle", typeof(Rectangle) },
        };

        /// <summary>
        /// Factory method for creating figure (of concrete type)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public AFigure EmitFigure(Root root)
        {
            AFigure figure = null;
            Type figureType = null;
            var found = FigureDictionary.ToList().Find(r => r.Key == root.type);
            if (found.Value != null)
                figureType = found.Value;
            else
                figureType = typeof(UnimplementedFigure);
            figure = (AFigure) Activator.CreateInstance(figureType, new object[] { root });
            return figure;
        }
    }
}
