using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Deserializers
{
    internal interface IDeserializer
    {
        List<Root> GetGenericFigures(string json);
    }
}
