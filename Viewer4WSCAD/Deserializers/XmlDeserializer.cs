using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types;

namespace Viewer4WSCAD.Deserializers
{
    /// <summary>
    /// Class impementing deserialization for XML input data.
    /// </summary>
    internal class XmlDeserializer : IDeserializer
    {
        public List<Root> GetGenericFigures(string xml) => SerializationHelpers.XmlDeserializeObject<List<Root>>(xml);
    }
}
