using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types;
using Viewer4WSCAD.Types.Geometry;


namespace Viewer4WSCAD.Deserializers
{
    /// <summary>
    /// Class impementing deserialization for JSON input data.
    /// </summary>
    internal class JsonDeserializer : IDeserializer
    {
        public List<Root> GetGenericFigures(string json) => JsonConvert.DeserializeObject<List<Root>>(json);
    }


}
