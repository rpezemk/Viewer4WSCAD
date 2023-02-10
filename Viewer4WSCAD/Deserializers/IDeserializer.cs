using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.Deserializers
{
    /// <summary>
    /// Interface for deserialization to List of Root. 
    /// </summary>
    public interface IDeserializer
    {
        /// <summary>
        /// Deserialize text to List of Root.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        List<Root> GetGenericFigures(string text);
    }
}
