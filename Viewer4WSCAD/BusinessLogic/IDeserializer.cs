using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.BusinessLogic
{
    internal interface IDeserializer
    {
        List<Root> GetFigures(string json);
    }
}
