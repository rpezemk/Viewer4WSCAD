using System.Collections.Generic;
using System.Linq;
using Viewer4WSCAD.Deserializers;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Helpers
{

    /// <summary>
    /// Geometric helpers
    /// </summary>
    internal static class GeometryHelpers
    {
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
            List<AFigure> figures = new List<AFigure>();
            var roots = deserializer.GetGenericFigures(strToDeserialize);
            FigureFactory factory = new FigureFactory();
            figures.Clear();
            foreach (var root in roots)
            {
                var fig = factory.EmitFigure(root);
                figures.Add(fig);
            }
            return figures;
        }
    }


}
