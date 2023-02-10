using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer4WSCAD.Types.Geometry
{
    /// <summary>
    /// Class for unimplemented figure
    /// </summary>
    internal class UnimplementedFigure : AFigure
    {
        public UnimplementedFigure(Root root) : base(root)
        {
        }

        public override List<double> Boundaries => new List<double>() { 0,0,0,0 };
    }
}
